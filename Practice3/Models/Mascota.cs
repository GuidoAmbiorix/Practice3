using Practice3.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Practice3.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }
        [Required]
        public RazaEnum RazaMascota { get; set; }

        [Required]
        public  int EdadMascota { get; set; }
    }
}
