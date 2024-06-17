using BookSwap.Auth.Users;
using BookSwap.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSwap.Domain.Employees;

public class Employee : User 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
}
