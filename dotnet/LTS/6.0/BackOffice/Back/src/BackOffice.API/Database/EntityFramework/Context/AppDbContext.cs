using Microsoft.EntityFrameworkCore;
using BackOffice.API.Database.EntityFramework.Context;
using BackOffice.API.Models;
using System;

namespace BackOffice.API.Database.EntityFramework.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<User> Users { get; set; }
    }
}