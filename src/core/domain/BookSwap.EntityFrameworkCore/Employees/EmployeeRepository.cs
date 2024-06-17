using BookSwap.Domain.Employees;

namespace BookSwap.EntityFrameworkCore.Employees
{
    public class EmployeeRepository : RepositoryBase<Employee, Guid>, IEmployeeRepository
    {
        public EmployeeRepository(BookSwapContext context) : base(context)
        {

        }
    }
}
