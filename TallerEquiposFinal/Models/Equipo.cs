using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TallerEquiposFinal.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string Ciudad { get; set; }
        public string TitulosEquipo { get; set; }
        public bool AdmiteExtranjeros { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
        public virtual Estadio? Estadio { get; set; } = null!;
    }
}
