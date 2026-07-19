using CleanArchitecture.Application.Services;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistance.Services;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetSection("ConnectionStrings:Postgres").Value));
builder.Services.AddControllers().AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssemblies(typeof(CleanArchitecture.Application.AssemblyReference).Assembly,typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly));

builder.Services.AddScoped<ICarService,CarService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();