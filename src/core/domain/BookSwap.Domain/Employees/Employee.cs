using BookSwap.Common.Entities;

namespace BookSwap.Domain.Employees;

public class Employee : IEntity<Guid>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public Guid Id { get; set ; }
}
