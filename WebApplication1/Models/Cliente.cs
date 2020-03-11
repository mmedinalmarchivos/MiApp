using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("clientes")]
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public List<Venta> Ventas { get; set; }
    }
}
