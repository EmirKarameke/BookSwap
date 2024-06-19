﻿using BookSwap.Auth.Users;
using BookSwap.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth.Roles.RolePermissions;

public interface IRolePermissionRepository<TKey> : IRepositoryBase<RolePermission<TKey>, TKey>
        where TKey : struct
{
}