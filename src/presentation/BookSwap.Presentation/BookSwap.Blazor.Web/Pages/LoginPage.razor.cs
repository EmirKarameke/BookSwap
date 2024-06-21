using Blazored.LocalStorage;
using BookSwap.Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Text;
using System.Text.Json;

namespace BookSwap.Blazor.Web.Pages;

public partial class LoginPage
{
    [Inject] HttpService httpService { get; set; }
    [Inject] ILocalStorageService localStorageService { get; set; }
    
    public class User
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
    ServiceRequestBase serviceRequestBase = new ServiceRequestBase();
    User user = new User();
    string? result;
    private async Task Login()
    {
        serviceRequestBase.Url = "https://localhost:7238/Employee/Login";
        var json =  JsonSerializer.Serialize(user);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        serviceRequestBase.Object = content;
        var req = serviceRequestBase;
        var response = await httpService.PostAsync(req);
        result = response;
        await localStorageService.SetItemAsStringAsync("token", response);
    }
}
