using Abp.Authorization;
using tzky.saas.Authorization.Roles;
using tzky.saas.Authorization.Users;

namespace tzky.saas.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
