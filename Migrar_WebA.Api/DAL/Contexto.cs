﻿using Microsoft.EntityFrameworkCore;
using Migrar_WebA.Shared.Models;

namespace Migrar_WebA.Api.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Sistemas> Sistemas { get; set; }
    }
}
