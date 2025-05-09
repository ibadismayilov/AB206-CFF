using FiorellaMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorellaMvc.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectString = @"Server=DESKTOP-STMIQUG;Database=FiorellaMvcHome;Trusted_Connection=True;TrustServerCertificate=True;";

    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectString);
        base.OnConfiguring(optionsBuilder);
    }
}
