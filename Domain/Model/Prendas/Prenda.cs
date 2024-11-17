using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Compras;
using Domain.Model.Cargas;

namespace Domain.Model.Prendas
{
    public class Prenda
    {
        [Key]
        public int IdPrenda { get; set; }

        public int Stock { get; set; }

        public int PuntoPedido { get; set; }

        public string Descripcion { get; set; }

        public string Talla { get; set; }
        
        public int IdTipoPrenda { get; set; }

        public TipoPrenda? TipoDePrenda { get; set; }

        public int IdMarca { get; set; }
        public Marca? MarcaPrenda { get; set; }

        public List<PrecioPrenda>? PreciosPrenda { get; set; }

        public List<LineaCompra>? LineasCompra { get; set; }

        public List<LineaCarga>? LineasCarga { get; set; }
    }
}
