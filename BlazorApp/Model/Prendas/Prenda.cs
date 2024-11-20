using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Model.Compras;
using BlazorApp.Model.Cargas;

namespace BlazorApp.Model.Prendas
{
    public class Prenda
    {
        [Key]
        public int IdPrenda { get; set; }
        
        [Required]
        public int Stock { get; set; }

        [Required]
        public int PuntoPedido { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }
        
        [Required]
        [MaxLength(2)]
        public string Talla { get; set; }

        [Required]
        public int IdTipoPrenda { get; set; }

        public TipoPrenda? TipoDePrenda { get; set; }

        [Required]
        public int IdMarca { get; set; }
        public Marca? MarcaPrenda { get; set; }

        public List<PrecioPrenda>? PreciosPrenda { get; set; }

        public List<LineaCompra>? LineasCompra { get; set; }

        public List<LineaCarga>? LineasCarga { get; set; }
    }

    public class PrendaMuestra
    {
        public int IdPrenda { get; set; }
        public string Descripcion { get; set; }
        public string Talla { get; set; }
        public string TipoDePrenda { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }

    }
    public class PrendaPedido
    {
        public int NumeroLinea { get; set; }
        public string Prenda { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}
