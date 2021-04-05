using Abp.Authorization;
using MyFirstProject.Authorization.Roles;
using MyFirstProject.Authorization.Users;

namespace MyFirstProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
