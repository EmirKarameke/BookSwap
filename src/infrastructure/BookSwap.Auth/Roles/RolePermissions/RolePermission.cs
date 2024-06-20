using BookSwap.Auth.Permissions;
using BookSwap.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth.Roles.RolePermissions
{
    [Table("RolePermissions")]
    public class RolePermission<Tkey> : IEntity<Tkey>
        where Tkey : struct
    {
        public Tkey Id { get; set; }

        public Role<Tkey> Role { get; set; }
        public Tkey RoleId { get; set; }

        public Permission<Tkey> Permission { get; set; }
        public Tkey PermissionId { get; set; }
    }
}
