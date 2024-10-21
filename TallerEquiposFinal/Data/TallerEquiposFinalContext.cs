using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerEquiposFinal.Models;

namespace TallerEquiposFinal.Data
{
    public class TallerEquiposFinalContext : DbContext
    {
        public TallerEquiposFinalContext (DbContextOptions<TallerEquiposFinalContext> options)
            : base(options)
        {
        }

        public DbSet<TallerEquiposFinal.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<TallerEquiposFinal.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<TallerEquiposFinal.Models.Jugador> Jugador { get; set; } = default!;
    }
}
