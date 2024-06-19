using BookSwap.Auth.Users;
using BookSwap.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Users
{
    public class UserRepository : RepositoryBase<IUser<Guid>, Guid>, IUserRepository<Guid>
    {
        BookSwapContext context;
        public UserRepository(BookSwapContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IUser<Guid>> GetEmployee(string userNameOrEmail)
        {
            return await context.Employees.FirstOrDefaultAsync(i => i.EmailOrUserName == userNameOrEmail);
        }
    }
}
