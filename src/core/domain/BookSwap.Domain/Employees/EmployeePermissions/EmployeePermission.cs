using BookSwap.Common.Entities;
using BookSwap.Domain.Employees.EmployeePermissionDefinitions;

namespace BookSwap.Domain.Employees.EmployeePermissions
{
    public class EmployeePermission : IEntity<int>
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public EmployeePermissionDefinition EmployeePermissionDefinition { get; set; }
        public int EmployeePermissionDefinitionId { get; set; }
    }
}
