using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.SshNet.Workers
{
    public class SshKeysSend : WorkerBase
    {
        public override void Execute()
        {
            /*
            #客户端上传ssh-key powershell
            ssh-keygen
            type $env:USERPROFILE\.ssh\id_rsa.pub | ssh root@10.0.0.101 "cat >> .ssh/authorized_keys"
            */
            OutputText("上传 ssh-key 开始", true);
            var file = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.ssh\id_rsa.pub");
            if (!File.Exists(file))
                throw new Exception($"d_rsa.pub文件不存在，请先在PowerShell下执行ssh-keygen生成。path: {file}");
            Client.UploadFile(file, "~/");
            ExecuteCmd("cat id_rsa.pub >> ~/.ssh/authorized_keys");
            ExecuteCmd("rm -f id_rsa.pub");
            OutputText("上传 ssh-key 结束", true);
        }
    }
}
