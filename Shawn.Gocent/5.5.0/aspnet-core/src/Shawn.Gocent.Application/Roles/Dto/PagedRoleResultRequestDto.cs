using Abp.Application.Services.Dto;

namespace Shawn.Gocent.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

