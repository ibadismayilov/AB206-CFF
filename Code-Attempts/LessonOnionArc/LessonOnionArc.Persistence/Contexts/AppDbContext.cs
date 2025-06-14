using LessonOnionArc.Domain.Entities;
using LessonOnionArc.Persistence.Contexts.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace LessonOnionArc.Persistence.Contexts;
public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
{
    public DbSet<ProductEntity> Products { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
