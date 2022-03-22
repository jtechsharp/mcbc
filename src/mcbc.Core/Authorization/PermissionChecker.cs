using Abp.Authorization;
using mcbc.Authorization.Roles;
using mcbc.Authorization.Users;

namespace mcbc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
