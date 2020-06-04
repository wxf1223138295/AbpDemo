using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Shawn.Gocent.MultiTenancy;

namespace Shawn.Gocent.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
