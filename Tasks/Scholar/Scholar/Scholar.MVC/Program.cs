using Microsoft.EntityFrameworkCore;
using System;
using Scholar.BL.Services;
using Scholar.DAL.Contexts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("Default") ?? "Additionail";

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<ProductService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}"
);

app.Run();