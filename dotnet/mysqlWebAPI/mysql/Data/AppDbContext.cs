using Microsoft.EntityFrameworkCore;
using mysql.Models;

namespace mysql.Data
{
    public class AppDbContext: DbContext
    
    {
        public DbSet<Users> Users { get; set }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your connection string.
            var connectionString = "server=localhost:3308;user=root;password=mspmysql1601;database=dotnet";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
