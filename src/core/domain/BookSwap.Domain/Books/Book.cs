using BookSwap.Common.Entities;

namespace BookSwap.Domain.Books;

public class Book : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string ISBNNo { get; set; }
    public string BookName { get; set; }
    public string Summary { get; set; }
    public string Writer { get; set; }
    public string imageUrl { get; set; }
    public int NumberOfCopies { get; set; }
    public int NumberOfPages { get; set; }
    public decimal UnitPrice { get; set; }
    public string Category { get; set; }
}
