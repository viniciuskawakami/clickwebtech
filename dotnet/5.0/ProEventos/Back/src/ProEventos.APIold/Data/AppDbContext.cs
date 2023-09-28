using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;
namespace ProEventos.API.Data

public class AppDbContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
     ==> optionsBuilder.UseSqlite("DataSource=ProEventos.db; Cache=Shared");
    }
}
