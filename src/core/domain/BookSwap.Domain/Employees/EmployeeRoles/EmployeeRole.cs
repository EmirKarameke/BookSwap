using BookSwap.Common.Entities;
using BookSwap.Domain.Employees.EmployeeRoleDefinitions;

namespace BookSwap.Domain.Employees.EmployeeRoles
{
    public class EmployeeRole : IEntity<int>
    {
        public int Id { get ; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public EmployeeRoleDefinition EmployeeRoleDefinition { get; set; }
        public int EmployeeRoleDefinitionId { get; set; }
    }
}
