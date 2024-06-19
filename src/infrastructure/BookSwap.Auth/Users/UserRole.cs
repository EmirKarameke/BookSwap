using BookSwap.Auth.Roles;
using BookSwap.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookSwap.Auth.Users
{
    [Table("UserRoles")]
    public class UserRole<TKey>: IEntity<TKey>
        where TKey : struct
    {
        public TKey Id { get; set; }
        public Role<TKey> Role { get; set; }
        public int RoleId { get; set; }

        public IUser<TKey> User { get; set; }
        public TKey UserId { get; set; }
    }
}
