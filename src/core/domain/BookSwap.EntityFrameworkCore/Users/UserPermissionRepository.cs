using BookSwap.Auth.Permissions;
using BookSwap.Auth.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class UserPermissionRepository : RepositoryBase<UserPermission<Guid>, Guid>, IUserPermissionRepository<Guid>
    {
        public UserPermissionRepository(BookSwapContext context) : base(context)
        {
        }
    }
}
