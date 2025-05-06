using Microsoft.EntityFrameworkCore;
using MvcModel.Models;

namespace MvcModel.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectToSql = @"Server=DESKTOP-STMIQUG;Database=MvcModel;Trusted_Connection=True;TrustServerCertificate=True;";

    public DbSet<TemplateWebsite> TemplateWebsites { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectToSql);
        base.OnConfiguring(optionsBuilder);
    }
}
