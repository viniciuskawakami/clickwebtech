using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;
using System.Data.Entity;

namespace ProEventos.API.Data
{

}
    public class AppDbContext : System.Data.Entity.DbContext
{
    public System.Data.Entity.DbSet<Evento> Eventos { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=ProEventos.db; Cache=Shared");
    }

    public class DbContextOptionsBuilder
    {
    }
}
