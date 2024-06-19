using BookSwap.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth.Users
{
    public interface IUserRepository<TKey> : IRepositoryBase<IUser<TKey>, TKey>
        where TKey : struct
    {
        Task<IUser<TKey>> GetEmployee(string userNameOrEmail);
    }
}
