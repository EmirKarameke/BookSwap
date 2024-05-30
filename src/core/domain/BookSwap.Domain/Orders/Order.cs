using BookSwap.Common.Entities;
using BookSwap.Domain.Books;
using BookSwap.Domain.Users;

namespace BookSwap.Domain.Orders;

public class Order : Entity
{
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }
}
