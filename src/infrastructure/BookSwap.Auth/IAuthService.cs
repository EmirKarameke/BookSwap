using BookSwap.Auth.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.Auth
{
    public interface IAuthService<TKey>
        where TKey : struct
    {
        Task<bool> Register(IUser<TKey> user, string password);
        Task<string> Login(string emailOrUserName, string password);

        Task<string> Logout();

    }
}
