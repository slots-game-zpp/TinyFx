﻿using Amazon.ACMPCA;
using Amazon.EC2;
using Amazon.ECS;
using Amazon.ElasticFileSystem;
using Amazon.ElasticLoadBalancingV2;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Extensions.AWS;
using TinyFx.Extensions.AWS.Common;
using TinyFx.Hosting.Services;
using TinyFx.Logging;

namespace TinyFx
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder AddAWSEx(this IHostBuilder builder)
        {
            var section = ConfigUtil.GetSection<AwsSection>();
            if (section == null || !section.Enabled)
                return builder;

            var watch = new Stopwatch();
            watch.Start();
            builder.ConfigureServices(services => 
            {
                var awsOpts = ConfigUtil.Configuration.GetAWSOptions();
                if (!string.IsNullOrEmpty(section.AccessKey) && !string.IsNullOrEmpty(section.SecretKey))
                {
                    awsOpts.Profile = null;
                    awsOpts.Credentials = new BasicAWSCredentials(section.AccessKey, section.SecretKey);
                }
                else
                {
                    if (string.IsNullOrEmpty(section.Profile))
                        throw new Exception("启用AWS时，Profile不能为空");
                }
                services.AddDefaultAWSOptions(awsOpts)
                    .AddAWSService<IAmazonElasticLoadBalancingV2>()
                    .AddAWSService<IAmazonEC2>()
                    .AddAWSService<IAmazonECS>()
                    .AddAWSService<IAmazonElasticFileSystem>()
                    .AddAWSService<IAmazonS3>()
                    .AddAWSService<IAmazonACMPCA>();

                var regSvc = DIUtil.GetService<ITinyFxHostRegisterService>();
                regSvc.AddProvider(new AwsHostRegisterProvider());
            });

            watch.Stop();
            LogUtil.Info("配置 => [AWS] [{ElapsedMilliseconds} 毫秒]", watch.ElapsedMilliseconds);
            return builder;
        }
    }
}
