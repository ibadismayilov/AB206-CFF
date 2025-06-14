using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PhishSentinel.Domain.Entities.Auth;
using PhishSentinel.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database connection
string connectionString = builder.Configuration.GetConnectionString("Default") ?? "Additional";
builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//Services
//builder.Services.AddScoped<AuthService>();

//Mapper


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
