using Microsoft.EntityFrameworkCore;
using System;
using netcore6MySql._04.InfraStructure.Data.ORM.EntityFramework.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Add Mysql connection options.
string mySqlConnection =
              builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextPool<AppDbContext>(options =>
                options.UseMySql(mySqlConnection,
                      ServerVersion.AutoDetect(mySqlConnection)));

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
