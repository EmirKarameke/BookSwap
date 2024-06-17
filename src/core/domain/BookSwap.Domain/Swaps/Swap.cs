using BookSwap.Common.Entities;
using BookSwap.Domain.Books;
using BookSwap.Domain.Users;

namespace BookSwap.Domain.Swaps;

public class Swap : IEntity<Guid>
{
    public Guid Id { get; set; }
    public Guid User1Id { get; set; }
    public Guid User2Id { get; set; }
    public Guid Book1Id { get; set; }
    public Guid Book2Id { get; set; }
    public bool IsConfirmed { get; set; }
    public Member User { get; set; }
    public Book Book { get; set; }
}
