using System.Runtime.Serialization;
using Google.Authenticator;

namespace UmbracoTwoFactorSandbox.Web.TwoFactor
{
    [DataContract]
        public class TwoFactorAuthInfo
        {
            [DataMember(Name = "qrCodeSetupImageUrl")]
            public string QrCodeSetupImageUrl { get; set; }

            [DataMember(Name = "secret")]
            public string Secret { get; set; }
        }
    }
