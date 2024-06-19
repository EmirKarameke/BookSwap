using BookSwap.Auth.Roles.RolePermissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class RolePermissionRepository : RepositoryBase<RolePermission<Guid>, Guid>, IRolePermissionRepository<Guid>
    {
        public RolePermissionRepository(BookSwapContext context) : base(context)
        {
        }
    }
}
