using BookSwap.Common.Entities;

namespace BookSwap.Domain.Employees.EmployeePermissionDefinitions
{
    public class EmployeePermissionDefinition : IEntity<int>
    {
        public int Id { get ; set; }
        public string PermissionName { get; set; }
        public string GroupAdi { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
    }
}
