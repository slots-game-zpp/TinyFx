using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Net;

namespace TinyFx.AspNet
{
    public class MinLengthExAttribute : MinLengthAttribute
    {
        public string Code { get; set; }
        public MinLengthExAttribute(int length, string code, string message = null)
            : base(length)
        {
            Code = code ?? GResponseCodes.G_BAD_REQUEST;
            ErrorMessage = message;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"{ErrorMessage}|{Code}";
        }
    }
}
