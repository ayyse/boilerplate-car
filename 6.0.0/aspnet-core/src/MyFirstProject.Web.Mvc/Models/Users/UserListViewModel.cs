using System.Collections.Generic;
using MyFirstProject.Roles.Dto;

namespace MyFirstProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
