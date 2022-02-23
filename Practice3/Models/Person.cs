using System.ComponentModel.DataAnnotations;

namespace Practice3.Models
{
    public class Person
    {
        [Key]
        public int PersonaId { get; set; }

        [Required]
        [Display(Name ="Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name="Edad")]
        public int Edad { get; set; }
    }
}
