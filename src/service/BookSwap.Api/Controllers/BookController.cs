using BookSwap.Application.Contract.Books;
using BookSwap.Application.Contract.Books.Dtos;
using BookSwap.Application.Contract.ServiceTypes;
using BookSwap.Domain.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookSwap.Api.Controllers;
[ApiController]
[Route("[controller]/[action]/")]
public class BookController : Controller
{
    IBookAppService bookAppService;
    public BookController(IBookAppService bookAppService)
    {
        this.bookAppService = bookAppService; 
    }
    [HttpPost]
    public async Task<ServiceResponse<bool>> AddBook(AddBookDto addBookDto)
    {
        var result = await bookAppService.AddBookAsync(addBookDto);
        return result;
    }
    [HttpGet]
    public async Task<ServiceResponse<List<Book>>> GetBookList()
    {
        var result = await bookAppService.GetBookListAsync();
        return result;
    }
}
