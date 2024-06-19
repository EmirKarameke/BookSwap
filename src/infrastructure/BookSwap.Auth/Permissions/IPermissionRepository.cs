using BookSwap.Auth.Users;
using BookSwap.Common.Repositories;

namespace BookSwap.Auth.Permissions;

public interface IPermissionRepository<TKey> : IRepositoryBase<Permission<TKey>, TKey>
    where TKey : struct
{
}
