using BookSwap.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth.Users
{
    public interface IUser<TKey> : IEntity<TKey>
        where TKey : struct
    {
        public TKey Id { get; set; }
        public string EmailOrUserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        public ICollection<UserRole<TKey>> Roles { get; set; }
        public ICollection<UserPermission<TKey>> Permissions { get; set; }
    }
}
