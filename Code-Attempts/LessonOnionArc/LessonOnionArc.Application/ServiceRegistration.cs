using LessonOnionArc.Application.DTOs.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application;   
public static class ServiceRegistration
{
    public static void AddApplicationeServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ProductProfile).Assembly);
    }
}
