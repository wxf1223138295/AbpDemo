using Abp.MultiTenancy;
using Shawn.Gocent.Authorization.Users;

namespace Shawn.Gocent.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
