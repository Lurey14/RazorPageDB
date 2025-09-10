using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_MVC.Models
{
    public class DetallePedidoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El ID de pedido es obligatorio")]
        [Display(Name = "Pedido")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "El ID de producto es obligatorio")]
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que 0")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio unitario debe ser mayor que 0")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio unitario")]
        [DataType(DataType.Currency)]
        public decimal PrecioUnitario { get; set; }

        public PedidoModel Pedido { get; set; }
        public ProductoModel Producto { get; set; }
    }
}
