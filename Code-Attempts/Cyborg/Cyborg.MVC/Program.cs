using Cyborg.BL.Services;
using Cyborg.DAL.Contexts;
using Cyborg.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("Default") ?? "Additional";

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddScoped<ProductService>();

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

app.MapControllerRoute(
    name: "Default",
    pattern: "{Contoller=Home}/{Action=Index}"
);

app.Run();
