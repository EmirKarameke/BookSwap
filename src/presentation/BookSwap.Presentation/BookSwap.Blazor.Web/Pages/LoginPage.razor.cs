using Blazored.LocalStorage;
using BookSwap.Blazor.Web.Providers;
using BookSwap.Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text;
using System.Text.Json;

namespace BookSwap.Blazor.Web.Pages;

public partial class LoginPage
{
    [Inject] HttpService httpService { get; set; }
    [Inject] ILocalStorageService localStorageService { get; set; }
    [Inject] NavigationManager navigationManager { get; set; }
    [Inject] AuthenticationStateProvider authStateProvider { get; set; }
    public class User
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
    User user = new User();
    private async Task Login()
    {
        ServiceRequestBase serviceRequestBase = new ServiceRequestBase();
        serviceRequestBase.Url = serviceRequestBase.Url + "Employee/Login";
        var json = JsonSerializer.Serialize(user);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        serviceRequestBase.Object = content;
        var req = serviceRequestBase;
        var response = await httpService.PostAsync(req);
        await localStorageService.SetItemAsStringAsync("token", response);
        ((AuthStateProvider)authStateProvider).NotifyUserLogin(response);
        navigationManager.NavigateTo("/");

    }
}
