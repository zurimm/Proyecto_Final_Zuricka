using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eventos.Models;

namespace Eventos.Data
{
    public class EventosContext : DbContext
    {
        public EventosContext (DbContextOptions<EventosContext> options)
            : base(options)
        {
        }

        public DbSet<Eventos.Models.Entrada> Entrada { get; set; } = default!;

        public DbSet<Eventos.Models.Administrador>? Administrador { get; set; }

        public DbSet<Eventos.Models.cat_evento>? cat_evento { get; set; }

        public DbSet<Eventos.Models.Evento>? Evento { get; set; }

        public DbSet<Eventos.Models.Metodo_pago>? Metodo_pago { get; set; }

        public DbSet<Eventos.Models.Soporte>? Soporte { get; set; }

        public DbSet<Eventos.Models.Usuario>? Usuario { get; set; }
    }
}
