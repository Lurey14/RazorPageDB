using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPractica.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        [Display(Name = "Nombre de la Tarea")]
        public string nombreTarea { get; set; }

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Vencimiento")]
        public DateTime fechaVencimiento { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required(ErrorMessage = "El ID de usuario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser un numero positivo")]
        [Display(Name = "ID de Usuario")]
        public int idUsuario { get; set; }
    }
}