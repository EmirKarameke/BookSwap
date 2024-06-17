using BookSwap.Common.Repositories;

namespace BookSwap.Domain.Employees;

public interface IEmployeeRepository : IRepositoryBase<Employee,Guid>
{
}
