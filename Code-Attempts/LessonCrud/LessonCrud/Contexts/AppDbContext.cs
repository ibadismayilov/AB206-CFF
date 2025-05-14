using LessonCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace LessonCrud.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectionString = "Server=DESKTOP-STMIQUG;Database=LessonCrud;Trusted_Connection=True;TrustServerCertificate=True";

    public DbSet<EmployeeModel> EmployeeModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
