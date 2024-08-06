using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.Extensions.CommandLineParser
{
    public abstract class VerbCommand<TOptions>: IVerbCommand
    {
        public TOptions Options { get; set; }
        public abstract void Execute();

        public void SetOptions(object opts)
        {
            Options = (TOptions)opts;
        }
    }
    public interface IVerbCommand
    {
        void Execute();
        void SetOptions(object opts);
    }
}
