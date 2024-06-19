using BookSwap.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth.Users
{
    public interface IUserPermissionRepository<TKey> : IRepositoryBase<UserPermission<TKey>, TKey>
        where TKey : struct
    {
    }
}
