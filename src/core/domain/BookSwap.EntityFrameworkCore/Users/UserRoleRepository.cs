using BookSwap.Auth.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class UserRoleRepository : RepositoryBase<UserRole<Guid>, Guid>, IUserRoleRepository<Guid>
    {
        public UserRoleRepository(BookSwapContext context) : base(context)
        {
        }
    }
}
