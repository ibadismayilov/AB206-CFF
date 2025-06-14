using HotelMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelMvc.Contexts
{
    public class HumanDbContext : DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-STMIQUG;Database=MVCEFCORE;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Human> Humans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
