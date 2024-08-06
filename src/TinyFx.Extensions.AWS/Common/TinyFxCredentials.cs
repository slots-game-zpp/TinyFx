using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace TinyFx.Extensions.AWS.Common
{
    internal class TinyFxCredentials : AWSCredentials
    {
        public string AccessKey { get; private set; }

        public string SecretKey { get; private set; }

        public string Token { get; private set; }
        private ImmutableCredentials _cr;
        public TinyFxCredentials(string accessKey, string secretKey, string token)
        {
            AccessKey = accessKey;
            SecretKey = secretKey;
            Token = token;
            _cr = new ImmutableCredentials(AccessKey, SecretKey, Token);
        }

        public override ImmutableCredentials GetCredentials()
        {
            return _cr;
        }
    }
}
