using Cybor2.BL.Services;
using Cybor2.DAL.Contexts;
using Cybor2.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("Default") ?? "Additional";

builder.Services.AddDbContext<AppDbContext>(opt =>opt.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Product}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}"
);

app.Run();
