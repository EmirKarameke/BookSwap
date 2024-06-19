using BookSwap.Auth.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class PermissionRepository : RepositoryBase<Permission<Guid>, Guid>, IPermissionRepository<Guid>

    {
        public PermissionRepository(BookSwapContext context) : base(context)
        {
        }
    }
}
