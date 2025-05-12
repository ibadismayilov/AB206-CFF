using CarVilla.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVilla.DAL.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectionString = @"Server=DESKTOP-STMIQUG;Database=CarVilla;Trusted_Connection=True;TrustServerCertificate=True";

    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
