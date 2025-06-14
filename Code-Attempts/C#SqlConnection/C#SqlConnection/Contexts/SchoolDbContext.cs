using C_SqlConnection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SqlConnection.Contexts;

public class SchoolDbContext : DbContext
{
    private readonly string _connectionString = "Server=DESKTOP-STMIQUG;Database=SchoolDb;Trusted_Connection=True;TrustServerCertificate=True;";
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
