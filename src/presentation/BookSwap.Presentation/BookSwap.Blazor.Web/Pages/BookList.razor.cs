using AutoMapper;
using BookSwap.Application.Contract.Books.Dtos;
using BookSwap.Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace BookSwap.Blazor.Web.Pages
{
    public partial class BookList
    {
        [Inject] HttpService httpService { get; set; }
        public AddBookDto BookDto { get; set; }
        public List<GetBookDto> ListBook { get; set; }
        bool toastVisible = false;
        protected override async void OnInitialized()
        {
            BookDto = new AddBookDto();
            ListBook = new List<GetBookDto>();
            await GetBookList();
        }
        public async Task AddBook()
        {
            ServiceRequestBase serviceRequestBase = new ServiceRequestBase();
            serviceRequestBase.Url = serviceRequestBase.Url + "Book/AddBook";
            var json = JsonSerializer.Serialize(BookDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            serviceRequestBase.Object = content;
            var result = await httpService.PostAsync<bool>(serviceRequestBase);
            if (result.Success)
            {
                await GetBookList();
                toastVisible = true;
            }
        }
        public async Task GetBookList()
        {
            ServiceRequestBase serviceRequestBase = new ServiceRequestBase();
            serviceRequestBase.Url = serviceRequestBase.Url + "Book/GetBookList";
            var result = await httpService.GetListAsync<List<GetBookDto>>(serviceRequestBase);
            if (result.Success)
            {
                //var books = mapper.Map<List<AddBookDto>>(result.Data);
                ListBook = result.Data;
            }

        }
    }
}
