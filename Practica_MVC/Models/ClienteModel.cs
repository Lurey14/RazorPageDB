using System.ComponentModel.DataAnnotations;

namespace Practica_MVC.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del email no es valido")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        [StringLength(200, ErrorMessage = "La direccion no puede exceder los 200 caracteres")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        public ICollection<PedidoModel> Pedidos { get; set; }
    }
}
