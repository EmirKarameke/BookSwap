using BookSwap.Domain.Books;
using BookSwap.Domain.Employees;
using BookSwap.Domain.Orders;
using BookSwap.Domain.Reservations;
using BookSwap.Domain.Swaps;
using BookSwap.Domain.UserInventories;
using BookSwap.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BookSwap.EntityFrameworkCore;

public class BookSwapContext : DbContext
{


    public BookSwapContext(DbContextOptions<BookSwapContext> options):base(options)
    {
        
    }

    //public DbSet<Book> Books { get; set; }
    public DbSet<Employee> Employees { get; set; }
    //public DbSet<Order> Orders { get; set; }
    //public DbSet<Reservation> Reservations { get; set; }
    //public DbSet<Swap> Swaps { get; set; }
    //public DbSet<UserInventory> UserInventories { get; set; }
    //public DbSet<Member> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    // => options.UseSqlServer("Server=localhost;Database=BookSwapDb;User Id=Emir;Password=1963;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(b =>
        {
            b.ToTable("Employees");
            //b.HasKey(i => i.Id);

            b.Property(i => i.Id).IsRequired().HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(i => i.FirstName).IsRequired().HasMaxLength(72).HasColumnType(SqlDbType.NVarChar.ToString());
            b.Property(i => i.LastName).IsRequired().HasMaxLength(72).HasColumnType(SqlDbType.NVarChar.ToString());
            b.Property(i => i.EmailOrUserName).IsRequired().HasMaxLength(72).HasColumnType(SqlDbType.NVarChar.ToString());

            b.HasMany(i => i.Roles).WithOne(i => (Employee)i.User).HasForeignKey(i => i.UserId);
            b.HasMany(i => i.Permissions).WithOne(i => (Employee)i.User).HasForeignKey(i => i.UserId);
        });
    }
}
