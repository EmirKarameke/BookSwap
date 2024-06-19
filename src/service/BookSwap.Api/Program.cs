using BookSwap.Auth;
using BookSwap.Auth.Permissions;
using BookSwap.Auth.Roles;
using BookSwap.Auth.Roles.RolePermissions;
using BookSwap.Auth.Users;
using BookSwap.EntityFrameworkCore;
using BookSwap.EntityFrameworkCore.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .Build();


builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContext<BookSwapContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IUserRepository<Guid>, UserRepository>();
builder.Services.AddScoped<IUserRoleRepository<Guid>, UserRoleRepository>();
builder.Services.AddScoped<IUserPermissionRepository<Guid>, UserPermissionRepository>();
builder.Services.AddScoped<IPermissionRepository<Guid>, PermissionRepository>();
builder.Services.AddScoped<IRoleRepository<Guid>,RoleRepository>();
builder.Services.AddScoped<IRolePermissionRepository<Guid>,RolePermissionRepository>();


builder.Services.AddScoped<IAuthService<Guid>, AuthService<Guid>>();


builder.Services.AddAuthentication((configure) => 
{
});
builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
