using BookSwap.Common.Repositories;
using BookSwap.Domain.Books;
using BookSwap.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSwap.EntityFrameworkCore.Books;

public class BookRepository : RepositoryBase<Book, Guid>, IBookRepository
{
    public BookRepository(BookSwapContext context) : base(context)
    {
    }
}
