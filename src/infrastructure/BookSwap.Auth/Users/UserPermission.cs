using BookSwap.Auth.Permissions;

namespace BookSwap.Auth.Users
{
    public class UserPermission
    {
        public int Id { get; set; }
        public Permission Permission { get; set; }
        public int PermissionId { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
