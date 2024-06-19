using BookSwap.Auth.Users;
using BookSwap.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSwap.Domain.Employees;

public class Employee : IUser<Guid>, IEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public Guid Id { get; set; }
    public string EmailOrUserName { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public ICollection<UserRole<Guid>> Roles { get; set; }
    public ICollection<UserPermission<Guid>> Permissions { get; set; }
}
