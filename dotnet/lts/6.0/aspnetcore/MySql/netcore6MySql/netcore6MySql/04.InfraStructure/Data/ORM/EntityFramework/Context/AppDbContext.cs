using Microsoft.EntityFrameworkCore;
using netcore6MySql._03.Domain.Entities;

namespace netcore6MySql._04.InfraStructure.Data.ORM.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }    
    }
}
