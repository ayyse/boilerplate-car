using System.Collections.Generic;
using MyFirstProject.Roles.Dto;

namespace MyFirstProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
