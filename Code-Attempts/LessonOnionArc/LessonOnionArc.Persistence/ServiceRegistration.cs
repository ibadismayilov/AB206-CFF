using LessonOnionArc.Persistence.Contexts;
using LessonOnionArc.Persistence.Contexts.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace LessonOnionArc.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(ConfigManager.ConnectionString));
    }
    
}
