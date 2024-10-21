using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TallerEquiposFinal.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public virtual Equipo? Equipo { get; set; } = null!;
    }
}
