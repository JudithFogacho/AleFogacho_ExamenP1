using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AleFogacho_ExamenP1.Models
{
    public class AF_Cita
    {
        [Key]
        public int AF_CitaId { get; set; }
        [Required]
        public DateTime AF_FechaIngreso { get; set; }
        [Required]
        public string? AF_NombreCita { get; set;}
        [Required]
        [StringLength(100)]
        public string? AF_Detalle { get; set;}
        [Required]
        [Range (0.01, 100.00)]
        public decimal AF_ValorCita { get; set;}
        [Required]
        public bool AF_Seguro { get; set;}

    }
}
