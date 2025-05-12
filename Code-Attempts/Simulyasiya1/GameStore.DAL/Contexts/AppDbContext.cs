using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectString = "Server=DESKTOP-STMIQUG;Database=GameStore;Trusted_Connection=True;TrustServerCertificate=True;";

    public DbSet<TrendingGames> TrendingGames { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectString);
        base.OnConfiguring(optionsBuilder);
    }
}
