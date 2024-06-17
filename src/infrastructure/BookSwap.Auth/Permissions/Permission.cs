
namespace BookSwap.Auth.Permissions
{
    public class Permission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string GroupAdi { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public PermissionTypes PermissionType { get; set; }
    }
}
