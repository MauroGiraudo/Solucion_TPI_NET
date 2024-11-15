using Windows_Forms.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms.Model.Compras
{
    public class LineaCompra : Linea
    {
        [Key]
        public int IdUsu { get; set; }

        [Key]
        public int IdOperacion { get; set; }

        public Compra? Compra { get; set; }
    }

    public class PrendaPedido
    {
        public int NumeroLinea { get; set; }
        public string Prenda { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}
