using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Linux
{
    public static class LinuxCommands
    {
        public static string DeleteDirFile(string dir)
        {
            dir = RepairDir(dir);
            return $"sudo rm -rf {dir}/*";
        }
        public static string CopyDirFile(string src, string dest)
        {
            src = RepairDir(src);
            dest = RepairDir(dest);
            return $"sudo cp -rf {src}/. {dest}";
        }
        private static string RepairDir(string dir)
            => dir.Trim().TrimEnd('/');
        
    }
}
