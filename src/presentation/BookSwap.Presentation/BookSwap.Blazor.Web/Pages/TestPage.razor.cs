using Blazored.LocalStorage;
using BookSwap.Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BookSwap.Blazor.Web.Pages
{
    public partial class TestPage
    {

        [Inject] HttpClient client { get; set; }
        [Inject] ILocalStorageService localStorageService { get; set; }
        [Inject] IHttpService httpService { get; set; }
        public string PageName { get; set; } = "Test222";

        public List<string> MyCollection { get; set; }


        protected async override Task OnInitializedAsync()
        {
            var token = await localStorageService.GetItemAsStringAsync("token");
            if (token == null)
            {

                await localStorageService.SetItemAsStringAsync("token", "abc");
            }
            else
            {
                PageName = token;
            }
        }
    }
}
