using System.ComponentModel.DataAnnotations;

namespace TallerEquiposFinal.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        public string NombreEstadio { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
