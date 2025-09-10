using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_MVC.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de pedido es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de pedido")]
        public DateTime FechaPedido { get; set; }

        [Required(ErrorMessage = "El cliente es obligatorio")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "La direccion de entrega es obligatoria")]
        [StringLength(200, ErrorMessage = "La direccion no puede exceder los 200 caracteres")]
        [Display(Name = "Direccion de entrega")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El monto total es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto total debe ser mayor que 0")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Monto total")]
        [DataType(DataType.Currency)]
        public decimal MontoTotal { get; set; }
        public ClienteModel Cliente { get; set; }//Un pedido pertenece a un solo cliente.
        public ICollection<DetallePedidoModel> DetallePedidos { get; set; }// Un pedido puede tener muchos detalles de pedido.





    }
}
