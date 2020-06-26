using Abp.Authorization;
using TechPOS.Authorization.Roles;
using TechPOS.Authorization.Users;

namespace TechPOS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
