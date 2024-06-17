using BookSwap.Common.Repositories;

namespace BookSwap.Domain.Books;

public interface IBookRepository : IRepositoryBase<Book,Guid>
{
}
