using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectString = "Server=;Database=Simulation2;Trusted_Connection=True;TrustServerCertificate=True;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectString);
        base.OnConfiguring(optionsBuilder);
    }
}
