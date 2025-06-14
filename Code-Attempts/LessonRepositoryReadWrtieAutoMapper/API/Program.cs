using BL.Services.Contracts;
using BL.Services.Interfaces;
using BL.Services.Mapping;
using DAL.Contexts;
using DAL.Entities;
using DAL.Repositories.Contracts;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(connection));

builder.Services.AddScoped<IProductService<Product>, ProductService<Product>>();

builder.Services.AddScoped<IReadRepository<Product>, ReadRepository<Product>>();
builder.Services.AddScoped<IWriteRepository<Product>, WriteRepository<Product>>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

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
