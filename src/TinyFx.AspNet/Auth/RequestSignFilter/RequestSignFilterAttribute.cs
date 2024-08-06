using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Logging;
using TinyFx.Net;
using TinyFx.Security;

namespace TinyFx.AspNet
{
    /// <summary>
    /// 第三方访问我方API时的sign验证器
    /// </summary>
    public class RequestSignFilterAttribute : ActionFilterAttribute
    {
        private RequestSignFilterElement _element;
        private RequestBodySignValidator _validator;
        private bool _enabled;

        public RequestSignFilterAttribute(string name = null)
        {
            var section = ConfigUtil.GetSection<RequestSignFilterSection>();
            if (section == null)
                throw new Exception($"启用{nameof(RequestSignFilterAttribute)}但没有Section配置");
            name ??= section.DefaultFilterName;
            if (!section.Filters.TryGetValue(name, out _element))
                throw new Exception($"启用{nameof(RequestSignFilterAttribute)}时配置RequestSignFilter:Filters中不存在name: {name}");
            if (string.IsNullOrEmpty(_element.HeaderName) || string.IsNullOrEmpty(_element.PublicKey))
                throw new Exception($"启用{nameof(RequestSignFilterAttribute)}时filter配置HeaderName和PublicKey不能为空。name: {name}");

            _enabled = _element.Enabled;
            _validator = new RequestBodySignValidator()
            {
                PublicKey = _element.PublicKey,
                KeyMode = _element.KeyMode,
                HashName = string.IsNullOrEmpty(_element.HashName) ? HashAlgorithmName.SHA256 : new HashAlgorithmName(_element.HashName),
                Encoding = _element.Encoding == default || _element.Encoding == null ? Encoding.UTF8 : _element.Encoding,
                Cipher = _element.Cipher,
            };
        }
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (_enabled && !await _validator.VerifyByHeader(_element.HashName, context.HttpContext))
            {
                throw new CustomException(GResponseCodes.G_UNAUTHORIZED, $"{nameof(RequestSignFilterAttribute)}验证失败。name:{_element.Name}");
            }
            await base.OnActionExecutionAsync(context, next);
        }
    }
}
