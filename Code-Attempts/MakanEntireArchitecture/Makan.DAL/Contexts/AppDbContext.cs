using Makan.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makan.DAL.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectString = "Server=DESKTOP-STMIQUG;Database=MakanDb;Trusted_Connection=True;TrustServerCertificate=True";

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RegisterViewModel> RegisterViewModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectString);
        base.OnConfiguring(optionsBuilder);
    }
}
