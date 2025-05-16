using Microsoft.EntityFrameworkCore;
using NFT.BL.Services;
using NFT.DAL.Contexts;
using NFT.DAL.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<ProductService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Crud}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}"
);

app.Run();
