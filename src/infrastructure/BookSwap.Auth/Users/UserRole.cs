using BookSwap.Auth.Roles;


namespace BookSwap.Auth.Users
{
    public class UserRole
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
