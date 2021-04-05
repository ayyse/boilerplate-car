using System.Collections.Generic;
using MyFirstProject.Roles.Dto;

namespace MyFirstProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}