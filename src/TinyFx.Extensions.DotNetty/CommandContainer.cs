using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Collections;
using TinyFx.Reflection;
using TinyFx.Security;

namespace TinyFx.Extensions.DotNetty
{
    public class CommandContainer
    {
        public static readonly CommandContainer Instance = new CommandContainer();
        private Dictionary<Assembly, bool> _asmDic = new();
        public List<Assembly> Assemblies => _asmDic.Keys.ToList();
        private ConcurrentDictionary<Type, CommandDescriptor> _typeCommands = new();
        private ConcurrentDictionary<int, CommandDescriptor> _idCommands = new();
        private List<CommandDescriptor> _commands;
        internal int CommandTypeMaxLength = 0; // 仅用于显示
        private const int _autoCommandIdStart = 100000;

        public void AddCommands(List<Assembly> asms)
        {
            foreach (var asm in asms)
                _asmDic.Add(asm, false);
            while (true)
            {
                var allExec = true;
                var items = _asmDic.ToList();
                items.ForEach(item => {
                    if (!item.Value)
                    {
                        allExec = false;
                        ParseAssembly(item.Key);
                        _asmDic[item.Key] = true;
                    }
                });
                if (allExec)
                    break;
            }
            AutoCommandId();
            // Exception
            _idCommands.TryAdd(DotNettyUtil.ExceptionCommandId, new CommandDescriptor 
            { 
                CommandId = DotNettyUtil.ExceptionCommandId,
                ResponseType = typeof(ProtoResponse),
                ResponsePacketType = typeof(ProtoResponse)
            });
        }
        private void ParseAssembly(Assembly asm)
        {
            var cmdTypes = from t in asm.GetTypes()
                           where t.GetCustomAttribute<CommandAttribute>() != null
                                && ReflectionUtil.IsSubclassOfGeneric(t, typeof(RespondCommand<,>))
                           select t;
            foreach (var type in cmdTypes)
            {
                var cmdObj = (CommandBase)ReflectionUtil.CreateInstance(type);
                var attr = type.GetCustomAttribute<CommandAttribute>();
                var cmd = new CommandDescriptor
                {
                    CommandId = attr.Id,
                    CheckLogin = attr.CheckLogin,
                    CommandType = type,
                    RequestType = type.BaseType.GetGenericArguments()[0],
                    ResponseType = type.BaseType.GetGenericArguments()[1],
                    RespondExecute = cmdObj.ExecuteAsync
                };
                cmd.ResponsePacketType = cmd.ResponseType == typeof(object) ? typeof(ProtoResponse)
                    : typeof(ProtoResponse<>).MakeGenericType(cmd.ResponseType);
                cmdObj.Descriptor = cmd;
                DIUtil.AddSingleton(cmdObj);
                AddAssembly(cmd.RequestType);
                AddAssembly(cmd.ResponseType);
                AddTypeCommand(type, cmd);
            }
            var pushTypes = from t in asm.GetTypes()
                            where t.GetCustomAttribute<ProtoPushAttribute>() != null
                            select t;
            foreach (var type in pushTypes)
            {
                var attr = type.GetCustomAttribute<ProtoPushAttribute>();
                var cmd = new CommandDescriptor
                {
                    CommandId = attr.CommandId,
                    CheckLogin = false,
                    CommandType = type,
                    RequestType = null,
                    ResponseType = type,
                    ResponsePacketType = typeof(ProtoResponse<>).MakeGenericType(type)
                };
                AddAssembly(cmd.ResponseType);
                AddTypeCommand(type, cmd);
            }
        }
        private void AutoCommandId()
        {
            //
            var cmds = new List<CommandDescriptor>();
            foreach (var cmd in _typeCommands.Values)
            {
                if (cmd.CommandId != 0) //自定义commandId
                    AddIdCommand(cmd.CommandId, cmd);
                else
                    cmds.Add(cmd);
                CommandTypeMaxLength = System.Math.Max(cmd.CommandType.FullName.Length, CommandTypeMaxLength);
            }
            // 自动CommandId
            cmds.Sort((x, y) => {
                if (x.IsPush.CompareTo(y.IsPush) != 0)
                    return x.IsPush.CompareTo(y.IsPush);
                else {
                    var c1 = SecurityUtil.MD5Hash(x.CommandType.FullName);
                    var c2 = SecurityUtil.MD5Hash(y.CommandType.FullName);
                    return c1.CompareTo(c2);
                }
            });
            var cmdid = _autoCommandIdStart;
            foreach (var cmd in cmds)
            {
                do
                {
                    cmdid++;
                }
                while (_idCommands.ContainsKey(cmdid));

                cmd.CommandId = cmdid;
                AddIdCommand(cmdid, cmd);
            }
        }

        public bool TryGet(int commandId, out CommandDescriptor cmd)
           => _idCommands.TryGetValue(commandId, out cmd);
        public bool TryGet(Type commandType, out CommandDescriptor cmd)
            => _typeCommands.TryGetValue(commandType, out cmd);
        public List<CommandDescriptor> GetCommands()
        {
            if (_commands == null)
            {
                _commands = _idCommands.Values.ToList();
                _commands.Sort((x, y) => {
                    var sign = x.CommandId < 0 && y.CommandId < 0 ? -1 : 1;
                    return sign * x.CommandId.CompareTo(y.CommandId);
                });
            }
            return _commands;
        }

        #region Utils
        private void AddAssembly(Type type)
        {
            if (type == typeof(object))
                return;
            var asm = type.Assembly;
            if (!_asmDic.ContainsKey(asm))
                _asmDic.Add(asm, false);
        }
        private void AddTypeCommand(Type type, CommandDescriptor cmd)
        {
            if (!_typeCommands.TryAdd(type, cmd))
                throw new Exception($"定义Command时CommandType重复: {type.FullName} : {cmd.CommandId}");
        }
        private void AddIdCommand(int cmdid, CommandDescriptor cmd)
        {
            if (!_idCommands.TryAdd(cmdid, cmd))
                throw new Exception($"定义Command时CommandId重复: {cmd.CommandType.FullName} : {cmd.CommandId}");
        }
        #endregion

    }
    public class CommandDescriptor
    {
        public int CommandId { get; set; }
        public bool CheckLogin { get; set; } = true;
        public Type CommandType { get; set; }
        public Type RequestType { get; set; }
        public bool IsPush => RequestType == null;
        public Type ResponseType { get; set; }
        /// <summary>
        /// 序列化时Body类型
        /// </summary>
        public Type ResponsePacketType { get; set; }
        public Func<RequestContext, Task> RespondExecute { get; set; }

        /*
        public string CommandName => CommandType.Name;
        public string CommandTypeDesc { get; set; }
        public string RequestTypeName => RequestType.Name;
        public string RequestTypeDesc { get; set; }
        public string ResponseTypeName => ResponseType.Name;
        public string ResponseTypeDesc { get; set; }
        */
    }
}
