using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Common;
using TinyFx.Reflection;

namespace TinyFx.Demos.Core
{
    internal class CSharpCodeExecutorDemo : DemoBase
    {
        public override async Task Execute()
        {
            var src = @"
using System;
namespace Sample
{
    public class Program
    {
        public static void Main(string str)
        {
            Console.WriteLine(str);
        }
    }
}
";
            //动态编译
            var cs = new CSharpCodeExecutor(src);
            cs.ExecuteStaticMethod("Sample.Program", "Main", "aaa");
        }
    }
}
