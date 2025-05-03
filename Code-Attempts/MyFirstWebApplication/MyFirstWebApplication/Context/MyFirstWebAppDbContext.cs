using Microsoft.EntityFrameworkCore;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Context;

public class MyFirstWebAppDbContext : DbContext
{
    private readonly string _databaseName = "Server=DESKTOP-STMIQUG;Database=MyFirstWebApplication_MVC;Trusted_Connection=True;TrustServerCertificate=True;";

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_databaseName);

        base.OnConfiguring(optionsBuilder);
    }
}
