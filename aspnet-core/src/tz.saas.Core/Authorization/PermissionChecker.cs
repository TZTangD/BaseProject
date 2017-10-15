using Abp.Authorization;
using tz.saas.Authorization.Roles;
using tz.saas.Authorization.Users;

namespace tz.saas.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
