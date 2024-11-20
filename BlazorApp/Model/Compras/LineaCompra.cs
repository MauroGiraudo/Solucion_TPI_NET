using BlazorApp.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Compras
{
    public class LineaCompra : Linea
    {
        [Key]
        public int IdUsu { get; set; }

        [Key]
        public int IdOperacion { get; set; }

        public Compra? Compra { get; set; }
    }
}
