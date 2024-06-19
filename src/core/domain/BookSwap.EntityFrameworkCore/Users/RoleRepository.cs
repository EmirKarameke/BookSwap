using BookSwap.Auth.Roles;
using BookSwap.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class RoleRepository : RepositoryBase<Role<Guid>, Guid>, IRoleRepository<Guid>
    {
        public RoleRepository(BookSwapContext context) : base(context)
        {
        }
    }
}
