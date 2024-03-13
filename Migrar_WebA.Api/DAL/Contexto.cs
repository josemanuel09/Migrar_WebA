using Microsoft.EntityFrameworkCore;
using Migrar_WebA.Shared.Models;

namespace Migrar_WebA.Api.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Prioridades> Prioridades { get; set; }
    }
}
