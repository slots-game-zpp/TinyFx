using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Reflection;
using TinyFx.Xml;

namespace TinyFx.Extensions.DotNetty.NettyInfoCommand
{
    public class ProtoDataBuilder
    {
        private List<CommandDescriptor> _commands;
        private XmlDocumentParser _xmlParser;

        private Dictionary<string, MessageData> _tempMsgs =new();
        private int _orderId = 0;

        private List<MessageData> _planMsgs;
        private List<MessageData> _doMsgs = new();
        private Dictionary<string, MessageData> _okMsgs = new();
        private static HashSet<string> NotSupportFieldType = new HashSet<string>() {
            "System.DateTimeOffset", "System.DateTime", "System.TimeSpan"
        };
        private ProtoData _data;
        public ProtoDataBuilder(NettyInfoReq request)
        {
            _commands = CommandContainer.Instance.GetCommands().FindAll(item 
                => request.HasDemo || (!request.HasDemo && item.CommandId > 0));
            _xmlParser = DotNettyUtil.XmlParser;
            _data = new ProtoData();
            _data.PackageName = request.Package;
            _data.Description = string.Join(' ', CommandContainer.Instance.Assemblies.Select(asm => asm.GetName().Name).Where(name => name != "TinyFx.Extensions.DotNetty"));
        }
        public ProtoData Build()
        {
            _planMsgs = GetPlanMessages();
            while (_planMsgs.Count > 0)
            {
                foreach (var msg in _planMsgs)
                {
                    if (msg.DotNetType == typeof(ProtoResponse) || msg.DotNetType == typeof(ProtoResponse<>))
                    {
                        AddOkMsg(msg);
                        continue;
                    }
                    _doMsgs.Add(msg);
                }
                _planMsgs.Clear();
                ParseDoMsgs();
                _doMsgs.Clear();
            }
            _data.Messages = _okMsgs.Values.ToList();
            _data.Messages.Sort();
            return _data;
        }

        #region GetPlanMessages
        private List<MessageData> GetPlanMessages()
        {
            AddDefaultResponseProto();
            foreach (var cmd in _commands)
            {
                if (cmd.CommandType == typeof(NettyInfoCmd))
                    continue;
                if (!cmd.IsPush && cmd.RequestType != typeof(object))
                {
                    AddTempMessage(GetMessageData(cmd.RequestType));
                }
                if (cmd.ResponseType != typeof(object))
                {
                    var msg = GetMessageData(cmd.ResponseType);
                    AddTempMessage(msg);
                    if(msg.DotNetType != typeof(ProtoResponse))
                        AddTempMessage(GetGenericResponseProto(msg));
                }
            }
            return _tempMsgs.Values.ToList();
        }
        private void AddDefaultResponseProto()
        {
            var msg = new MessageData()
            {
                Name = "ProtoResponse",
                DotNetType = typeof(ProtoResponse),
                Description = "protobuf返回客户端的基础结构",
                Fields = new List<FieldData>(),
                OrderId = _orderId++
            };
            msg.Fields.Add(new FieldData
            {
                Name = "Success",
                Tag = 1,
                Description = "是否成功",
                TypeString = "bool"
            });
            msg.Fields.Add(new FieldData
            {
                Name = "Code",
                Tag = 2,
                Description = "状态码",
                TypeString = "string"
            });
            msg.Fields.Add(new FieldData
            {
                Name = "Message",
                Tag = 3,
                Description = "消息",
                TypeString = "string"
            });
            _tempMsgs.Add(msg.Name, msg);
        }
        private MessageData GetMessageData(Type type)
        {
            if (type.IsGenericType)
                throw new Exception($"proto的message不能是泛型类型。{type.FullName}");
            var msg = new MessageData
            {
                DotNetType = type,
                Name = type.Name,
                Description = _xmlParser.GetSummary(type),
                OrderId = _orderId++    
            };
            return msg;
        }
        private MessageData GetGenericResponseProto(MessageData src)
        {
            if (ReflectionUtil.IsBulitinType(src.DotNetType))
                throw new Exception("使用ProtoResponse<T>中T必须是自定义类型");
            var msg = new MessageData()
            {
                Name = GetProtoResponseName(src.Name),
                //DotNetType = typeof(ProtoResponse<>).MakeGenericType(src.DotNetType),
                DotNetType = typeof(ProtoResponse<>),
                Description = $"【ProtoResponse<{src.Name}>】",
                Fields = new List<FieldData>(),
                OrderId = _orderId++,
            };

            msg.Fields.Add(new FieldData
            {
                Name = "Success",
                Tag = 1,
                Description = "是否成功",
                TypeString = "bool"
            });
            msg.Fields.Add(new FieldData
            {
                Name = "Code",
                Tag = 2,
                Description = "状态码",
                TypeString = "string"
            });
            msg.Fields.Add(new FieldData
            {
                Name = "Message",
                Tag = 3,
                Description = "消息",
                TypeString = "string"
            });
            msg.Fields.Add(new FieldData
            {
                Name = "Result",
                Tag = 4,
                Description = src.Description,
                TypeString = src.DotNetType.Name
            });
            return msg;
        }
        private static string GetProtoResponseName(string srcName)
            => $"{srcName}Rsp";
        private void AddTempMessage(MessageData msg)
        {
            if (_tempMsgs.ContainsKey(msg.Name))
            {
                if (_tempMsgs[msg.Name].DotNetType == msg.DotNetType)
                    return;
                throw new Exception($"proto的message名称不能重复。name: {msg.Name} type1: {_tempMsgs[msg.Name].DotNetType.FullName} type2: {msg.DotNetType.FullName}");
            }
            _tempMsgs.Add(msg.Name, msg);
        }
        #endregion

        #region ParseDoMsgs
        private void ParseDoMsgs()
        {
            foreach (var msg in _doMsgs)
            {
                if (msg.IsEnum)
                    BuildEnum(msg);
                else
                    BuildClass(msg);
                AddOkMsg(msg);
            }
        }
        private void BuildEnum(MessageData msg)
        {
            var info = EnumUtil.GetInfo(msg.DotNetType);
            if (!info.Exist(0))
                throw new Exception($"proto类枚举必须提供等于0的默认值。{msg.DotNetType.FullName}");
            foreach (var item in info.GetList())
            {
                var field = new FieldData()
                {
                    Name = item.Name,
                    Tag = item.Value,
                    Description = _xmlParser?.GetSummary(item.FieldInfo),
                };
                msg.Fields.Add(field);
            }
            msg.Fields.Sort();
        }
        private void BuildClass(MessageData msg)
        {
            var propList = new SortedDictionary<int, PropertyInfo>();
            foreach (var prop in msg.DotNetType.GetProperties())
            {
                int? tag = prop.GetCustomAttribute<ProtoMemberAttribute>()?.Tag
                    ?? prop.GetCustomAttribute<DataMemberAttribute>()?.Order;
                if (tag.HasValue)
                {
                    if (propList.ContainsKey(tag.Value))
                        throw new Exception($"属性定义的ProtoMemberAttribute或DataMemberAttribute的Tag或Order存在重复: {msg.DotNetType.FullName}.{prop.Name}={tag.Value}");
                    propList.Add(tag.Value, prop);
                }
            }

            foreach (var item in propList)
            {
                var prop = item.Value;
                if (NotSupportFieldType.Contains(prop.PropertyType.FullName))
                    throw new Exception($"proto文件生成工具不支持此类型:{prop.PropertyType.FullName}。属性：{msg.DotNetType.FullName}.{prop.Name}。时间类型请使用unix timestamp");
                var attr = prop.GetCustomAttribute<ProtoMemberAttribute>();
                var field = new FieldData {
                    Name = attr?.Name ?? prop.Name,
                    DotNetType = prop.PropertyType,
                    Tag = attr?.Tag??item.Key,
                    Description = _xmlParser.GetSummary(prop),
                    Parent = msg
                };
                var format = attr != null ? (DataFormat)(int)attr.DataFormat: DataFormat.Default;
                ParseField(field, format);
                msg.Fields.Add(field);
            }
            msg.Fields.Sort();
        }
        private void AddOkMsg(MessageData msg)
        {
            if (_okMsgs.ContainsKey(msg.Name))
            {
                if (_okMsgs[msg.Name].DotNetType != msg.DotNetType)
                    throw new Exception($"Proto类型定义包含重复名称 {msg.Name}: {_okMsgs[msg.Name].DotNetType.FullName} {msg.DotNetType.FullName}");
            }
            else
                _okMsgs.Add(msg.Name, msg);
        }
        #endregion

        #region ParseField
        private void ParseField(FieldData field, DataFormat format)
        {
            // 简单类型
            if (ParseEmbed(field, format))
                return;
            // Enum
            if (ParseEnum(field))
                return;
            // Array
            if (ParseArray(field, format))
                return;
            // Map => IDictionary<,>
            if (ParseMap(field, format))
                return;
            // List => ICollection<>
            if (ParseList(field, format))
                return;
            //Class  
            if (ParseClass(field))
                return;
            throw new Exception($"proto未知的属性类型：{field.Parent.DotNetType.FullName}.{field.Name}");
        }
        private bool ParseEmbed(FieldData field, DataFormat format)
        {
            field.Type = GetEmbedTypes(field.DotNetType, format);
            if (field.Type != ProtoTypes.Unknow)
            {
                field.TypeString = GetEmbedProtoTypeString(field.Type);
                return true;
            }
            else
                return false;
        }
        private bool ParseEnum(FieldData field)
        {
            var type = field.DotNetType;
            if (type.IsEnum)
            {
                field.Type = ProtoTypes.Enum;
                field.TypeString = field.DotNetType.Name;
                AddPlanTypes(type);
                return true;
            }
            return false;
        }
        private bool ParseClass(FieldData field)
        {
            if (!ReflectionUtil.IsBulitinType(field.DotNetType))
            {
                field.Type = ProtoTypes.Class;
                field.TypeString = field.DotNetType.Name;
                AddPlanTypes(field.DotNetType);
                return true;
            }
            else
                return false;
        }
        private bool ParseArray(FieldData field, DataFormat format)
        {
            var type = field.DotNetType;
            if (type.IsArray)
            {
                var name = type.FullName.Replace("[]", string.Empty);
                var emType = type.Assembly.GetType(name);
                field.Type = ProtoTypes.List;
                field.TypeString = $"repeated {GetEmbedTypeString(emType, format)}";
                return true;
            }
            else
                return false;
        }
        private bool ParseList(FieldData field, DataFormat format)
        {
            var type = field.DotNetType;
            if (ReflectionUtil.IsSubclassOfGeneric(type, typeof(ICollection<>)))
            {
                var emType = type.GenericTypeArguments[0];
                field.Type = ProtoTypes.List;
                field.TypeString = $"repeated {GetEmbedTypeString(emType, format)}";
                return true;
            }
            else
                return false;
        }
        private bool ParseMap(FieldData field, DataFormat format)
        {
            var type = field.DotNetType;
            if (ReflectionUtil.IsSubclassOfGeneric(type, typeof(IDictionary<,>)))
            {
                field.Type = ProtoTypes.Map;
                var emKey = type.GenericTypeArguments[0];
                if (GetEmbedTypes(emKey, format) == ProtoTypes.Unknow)
                    throw new Exception("proto只允许简单类型做key");
                var keyStr = GetEmbedTypeString(emKey, format);
                var emValue = type.GenericTypeArguments[1];
                var valueStr = GetEmbedTypeString(emValue, format);
                field.TypeString = $"map<{keyStr}, {valueStr}>";
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Utils
        private ProtoTypes GetEmbedTypes(Type type, DataFormat format)
        {
            var ret = ProtoTypes.Unknow;
            switch (type.FullName)
            {
                #region 不变的
                case SimpleTypeNames.Boolean:
                    ret = ProtoTypes.Bool;
                    break;
                case SimpleTypeNames.Single:
                    ret = ProtoTypes.Float;
                    break;
                case SimpleTypeNames.Double:
                    ret = ProtoTypes.Double;
                    break;
                case SimpleTypeNames.String:
                    ret = ProtoTypes.String;
                    break;
                case SimpleTypeNames.Byte:
                case SimpleTypeNames.Char:
                case SimpleTypeNames.UInt16:
                case SimpleTypeNames.UInt32:
                    ret = format == DataFormat.FixedSize
                        ? ProtoTypes.Fixed32 : ProtoTypes.UInt32;
                    break;
                case SimpleTypeNames.SByte:
                case SimpleTypeNames.Int16:
                case SimpleTypeNames.Int32:
                    switch (format)
                    {
                        case DataFormat.ZigZag:
                            ret = ProtoTypes.SInt32;
                            break;
                        case DataFormat.FixedSize:
                            ret = ProtoTypes.SFixed32;
                            break;
                        default:
                            ret = ProtoTypes.Int32;
                            break;
                    }
                    break;
                case SimpleTypeNames.Int64:
                    switch (format)
                    {
                        case DataFormat.ZigZag:
                            ret = ProtoTypes.SInt64;
                            break;
                        case DataFormat.FixedSize:
                            ret = ProtoTypes.SFixed64;
                            break;
                        default:
                            ret = ProtoTypes.Int64;
                            break;
                    }
                    break;
                case SimpleTypeNames.UInt64:
                    ret = format == DataFormat.FixedSize
                        ? ProtoTypes.Fixed64 : ProtoTypes.UInt64;
                    break;
                #endregion
                #region 可变的
                case SimpleTypeNames.DateTime:
                    switch (format)
                    {
                        case DataFormat.FixedSize:
                            ret = ProtoTypes.SInt64;
                            break;
                        default:
                            // .google.protobuf.Timestamp
                            ret = ProtoTypes.DateTime;
                            break;
                    }
                    break;
                case SimpleTypeNames.DateTimeOffset:
                    // .google.protobuf.Timestamp
                    ret = ProtoTypes.DateTimeOffset;
                    break;
                case SimpleTypeNames.TimeSpan:
                    switch (format)
                    {
                        case DataFormat.FixedSize:
                            ret = ProtoTypes.SInt64;
                            break;
                        default:
                            // .google.protobuf.Duration
                            ret = ProtoTypes.TimeSpan;
                            break;
                    }
                    break;

                case SimpleTypeNames.Decimal:
                    // .bcl.Decimal 或者 string
                    ret = ProtoTypes.Decimal;
                    break;

                case SimpleTypeNames.Guid:
                    switch (format)
                    {
                        case DataFormat.FixedSize:
                            ret = ProtoTypes.Bytes;
                            break;
                        default:
                            // .bcl.Guid 或者 string
                            ret = ProtoTypes.Guid;
                            break;
                    }
                    break;
                case SimpleTypeNames.Bytes:
                    ret = ProtoTypes.Bytes;
                    break;
                    #endregion
            }
            return ret;
        }
        private string GetEmbedProtoTypeString(ProtoTypes protpType)
        {
            string ret = null;
            switch (protpType)
            {
                /*
                case ProtoTypes.Class:
                case ProtoTypes.Enum:
                    ret = field.DotNetType.Name;
                    break;
                case ProtoTypes.List:
                    ret = $"repeated {field.DotNetType.Name}";
                    break;
                case ProtoTypes.Map:
                    ret = $"map<{field.KeyName}, {field.ValueName}>";
                    break;
                */
                case ProtoTypes.DateTimeOffset:
                case ProtoTypes.DateTime:
                    ret = ".google.protobuf.Timestamp";
                    break;
                case ProtoTypes.TimeSpan:
                    ret = ".google.protobuf.Duration";
                    break;
                case ProtoTypes.Guid:
                case ProtoTypes.Decimal:
                    ret = "string";
                    break;
                default:
                    ret = protpType.ToString().ToLower();
                    break;
            }
            return ret;
        }
        private string GetEmbedTypeString(Type type, DataFormat format)
        {
            // 简单
            var protoType = GetEmbedTypes(type, format);
            if (protoType != ProtoTypes.Unknow)
                return GetEmbedProtoTypeString(protoType);
            // Enum
            if (type.IsEnum)
            {
                AddPlanTypes(type);
                return type.Name;
            }
            // Class
            if (!ReflectionUtil.IsBulitinType(type))
            {
                AddPlanTypes(type);
                return type.Name;
            }
            throw new Exception("protobuf-net不支持多层嵌套类型");
        }
        private void AddPlanTypes(Type type)
        {
            if (!ReflectionUtil.IsBulitinType(type) && !type.IsEnum)
            {
                if (type.IsGenericType)
                    throw new Exception($"proto类不能是泛型类型。{type.FullName}");
                var hasAttr = false;
                foreach (var attr in type.GetCustomAttributes())
                {
                    if (attr.GetType().FullName == "ProtoBuf.ProtoContractAttribute" || attr.GetType().FullName == "System.Runtime.Serialization.DataContractAttribute")
                        hasAttr = true;
                }
                if (!hasAttr)
                    throw new Exception($"proto类型必须使用ProtoContractAttribute或DataContractAttribute定义。{type.FullName}");
            }
            _planMsgs.Add(CreateMessageData(type));
        }
        private MessageData CreateMessageData(Type type)
        {
            var ret = new MessageData()
            {
                Name = type.Name,
                DotNetType = type,
                Description = _xmlParser?.GetSummary(type),
                Fields = new List<FieldData>(),
                OrderId = _orderId++
            };
            return ret;
        }
        #endregion
    }
}
