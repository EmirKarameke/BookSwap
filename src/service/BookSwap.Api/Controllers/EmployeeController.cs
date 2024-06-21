using BookSwap.Auth;
using BookSwap.Domain;
using BookSwap.Domain.Employees;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookSwap.Api.Controllers;

[ApiController]
[Route("[controller]/[action]/")]
public class EmployeeController : Controller
{
    IAuthService<Guid> authService;

    public EmployeeController(IAuthService<Guid> authService)
    {
        this.authService = authService;
    }

    //[Authorize(BookSwapPermissions.Employee.Create)]
    [Authorize(Roles = $"{BookSwapPermissions.Employee.Create}")]
    [Authorize(Policy = "EmployeeOrMember")]
    [HttpGet]
    public async Task<string> Register(string userName, string password)
    {
        var employee = new Employee()
        {
            EmailOrUserName = userName,
            FirstName = "First Name",
            LastName = "Last Name",
            Title = "Title"
        };

        var result = await authService.Register(employee, password);

        return result ? "BAŞARILI" : "HATA OLUŞTU";
    }

    [HttpPost]

    public async Task<string> Login(User user)
    {
        var result = await authService.Login(user.UserNameOrEmail, user.Password);

        return result;
    }

    [Authorize]
    [HttpGet]
    public async Task<string> TestAuth()
    {
        return "Başarılı";
    }
    public class User
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
