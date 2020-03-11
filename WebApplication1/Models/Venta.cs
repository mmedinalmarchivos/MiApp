using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("ventas")]
    public class Venta
    {
        public int ID { get; set; }

        [Column("id_cliente")]
        [ForeignKey("Cliente")]
        public int IDCliente { get; set; }

        public Cliente Cliente { get; set; }

        [Column("id_producto")]
        [ForeignKey("Producto")]
        public int IDProducto { get; set; }

        public Producto Producto { get; set; }

    }
}
