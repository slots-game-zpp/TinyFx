using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;
using AutoMapper;
using Demo.ConsoleEXE;
using Demo.ConsoleEXE.DAL;
using Demo.Shared;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProtoBuf.Grpc.Client;
using Renci.SshNet.Security;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using TinyFx.BIZ.DataSplit;
using TinyFx.BIZ.DataSplit.DAL;
using TinyFx.Common;
using TinyFx.Configuration;
using TinyFx.Data;
using TinyFx.DbCaching;
using TinyFx.Extensions.AutoMapper;
using TinyFx.Extensions.AWS;
using TinyFx.Extensions.AWS.LoadBalancing;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.IP2Country;
using TinyFx.Randoms;
using TinyFx.Security;
using TinyFx.ShortId;
using TinyFx.Text;

namespace TinyFx.Demos
{
    internal class TestDemo : DemoBase
    {
        public override async Task Execute()
        {
            var t = TimeSpan.Parse("7.00:00:00");
            Console.WriteLine(t);
        }
    }


    public class UserInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
