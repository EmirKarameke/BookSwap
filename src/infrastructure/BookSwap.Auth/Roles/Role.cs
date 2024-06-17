
namespace BookSwap.Auth.Roles
{
    public  class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public RoleTypes RoleType { get; set; }
    }
}
