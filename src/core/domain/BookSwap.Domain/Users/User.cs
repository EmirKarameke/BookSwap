using BookSwap.Common.Entities;

namespace BookSwap.Domain.Users;

public class User : Entity
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string NationalId { get; set; }
    public string Adress { get; set; }
    public int RightToSwap { get; set; }
}
