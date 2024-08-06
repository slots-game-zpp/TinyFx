using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Net;

namespace TinyFx.AspNet
{
    public class RegularExpressionExAttribute : RegularExpressionAttribute
    {
        public string Code { get; set; }
        public RegularExpressionExAttribute(string pattern, string code, string message = null)
            : base(pattern)
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
