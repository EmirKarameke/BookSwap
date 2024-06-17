using BookSwap.Common.Entities;
using BookSwap.Domain.Books;
using BookSwap.Domain.Users;

namespace BookSwap.Domain.Reservations;

public class Reservation : IEntity<Guid>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    public DateTime ReservDate { get; set; }
    public DateTime ReservEndDate { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }
}
