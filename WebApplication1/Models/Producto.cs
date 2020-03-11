using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [Column("fecha_vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        public List<Venta> Ventas { get; set; }

    }
}
