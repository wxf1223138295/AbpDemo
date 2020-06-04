using Abp.Authorization;
using Shawn.Gocent.Authorization.Roles;
using Shawn.Gocent.Authorization.Users;

namespace Shawn.Gocent.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
