using Abp.AutoMapper;
using Shawn.Gocent.Authentication.External;

namespace Shawn.Gocent.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
