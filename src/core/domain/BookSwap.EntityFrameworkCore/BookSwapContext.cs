using BookSwap.Domain.Books;
using BookSwap.Domain.Employees;
using BookSwap.Domain.Employees.EmployeePermissionDefinitions;
using BookSwap.Domain.Employees.EmployeePermissions;
using BookSwap.Domain.Employees.EmployeeRoleDefinitions;
using BookSwap.Domain.Employees.EmployeeRoles;
using BookSwap.Domain.Orders;
using BookSwap.Domain.Reservations;
using BookSwap.Domain.Swaps;
using BookSwap.Domain.UserInventories;
using BookSwap.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace BookSwap.EntityFrameworkCore;

public class BookSwapContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeRole> EmployeeRoles { get; set; }
    public DbSet<EmployeeRoleDefinition> EmployeeRoleDefinitions { get; set; }
    public DbSet<EmployeePermission> EmployeePermissions { get; set; }
    public DbSet<EmployeePermissionDefinition> EmployeePermissionsDefinition { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Swap> Swaps { get; set; }
    public DbSet<UserInventory> UserInventories { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlServer("Server=localhost;Database=BookSwapDb;User Id=Emir;Password=1963;TrustServerCertificate=True;");
}
