using Amazon.EC2.Model;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.AWS.Common;

namespace TinyFx.Extensions.AWS
{
    public class AwsSection : AWSOptions, IConfigSection
    {
        public string SectionName => "AWS";

        public bool Enabled { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string VpcName { get; set; }

        public LoadBalancingElement LoadBalancing { get; set; }

        public void Bind(IConfiguration configuration)
        {
            configuration?.Bind(this);
            if (LoadBalancing != null)
            {
                if (LoadBalancing.RegisterTargetGroup && string.IsNullOrEmpty(LoadBalancing.TargetGroupName))
                {
                    LoadBalancing.TargetGroupName = Regex.Replace(ConfigUtil.Project.ProjectId, "[^a-zA-Z0-9]", "-"); 
                }
            }
        }
    }
}
