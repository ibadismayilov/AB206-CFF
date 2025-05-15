using GYM.BL.Services;
using GYM.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<ProductService>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=CRUD}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}"
);

app.Run();
