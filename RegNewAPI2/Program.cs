using Microsoft.EntityFrameworkCore;

using RegNewAPI2.Models;
using RegNewAPI2.Repository;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Apicontext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));
builder.Services.AddScoped<IFisrtRepository, IFisrtRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
