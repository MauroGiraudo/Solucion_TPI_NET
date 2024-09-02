using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Prendas
{
    public class Prenda
    {
        private int _idPrenda;

        public int IdPrenda { get; set; }

        private int _stock;

        public int Stock { get; set; }

        private int _puntoPedido;

        public int PuntoPedido { get; set; }

        private string _descripcion;

        public string Descripcion { get; set; }

        private string _talla;

        public string Talla { get; set; }

        private string _modelo;

        public string Modelo { get; set; }

        private TipoPrenda _tipoDePrenda;

        public TipoPrenda TipoDePrenda { get; set; }

        private Marca _marcaPrenda;

        public Marca MarcaPrenda { get; set; }

        private List<PrecioPrenda> _preciosPrenda = new List<PrecioPrenda>();

        public List<PrecioPrenda> PreciosPrenda { get; set; }
    }
}
