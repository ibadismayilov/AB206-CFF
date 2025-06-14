using LessonOnionArc.Application.DTOs.Profiles;
using LessonOnionArc.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using LessonOnionArc.Persistence;
using LessonOnionArc.Application;
using LessonOnionArc.Persistence.Contexts.Identity;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database Access
builder.Services.AddPersistenceServices();

//AutoMapper
builder.Services.AddApplicationeServices();

//Identity
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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
