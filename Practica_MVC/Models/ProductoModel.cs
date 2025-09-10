using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica_MVC.Models
{
    public class ProductoModel
    {
        //No se olviden es la llave primaria de la tabla
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        [Display(Name = "Nombre del producto")]
        public string Nombre { get; set; }

        [StringLength(500, ErrorMessage = "La descripcion no puede exceder los 500 caracteres")]
        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        [Display(Name = "Stock disponible")]
        public int Stock { get; set; }

        // Propiedad de navegación para la relación con DetallePedido.
        // Un producto puede estar en muchos detalles de pedido.
        public ICollection<DetallePedidoModel> DetallePedidos { get; set; }
    }
}
