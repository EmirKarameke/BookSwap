using BookSwap.Common.Entities;

namespace BookSwap.Domain.Employees.EmployeeRoleDefinitions
{
    public class EmployeeRoleDefinition : IEntity<int>
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }
}