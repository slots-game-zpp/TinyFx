using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TinyFx.IO;

namespace TinyFx.Extensions.SshNet.Workers
{
    public class UploadInstaller : UploadFile
    {
        public UploadInstaller(Stream localFile, string serverPath, SshClientEx client = null) : base(localFile, serverPath, null, client)
        {
        }

        public override void Execute()
        {
            base.Execute();
            OutputText("解压授权 installer.rar 开始", true);
            ExecuteCmd("sudo yum install epel-release -y");
            ExecuteCmd("sudo yum install unar -y");
            var path = $"{ServerDir}/installer";
            ExecuteCmd($"rm -rf {path}");
            //ExecuteCmd($"mkdir -p {path}");
            ExecuteCmd($"unar -o {ServerDir} {ServerPath}");
            ExecuteCmd($"rm -rf {ServerPath}");
            ExecuteCmd($"chmod +x {path}/install.sh");
            OutputText("解压授权 installer.rar 完成", true);
        }
    }
}
