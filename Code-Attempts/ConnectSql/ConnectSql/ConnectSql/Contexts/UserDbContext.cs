using ConnectSql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectSql.Contexts;

public class UserDbContext : DbContext
{
    private readonly string _contextString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=UsersDb;Trusted_Connection=True;TrustServerCertificate=True;";
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_contextString);
        base.OnConfiguring(optionsBuilder);
    }
}
