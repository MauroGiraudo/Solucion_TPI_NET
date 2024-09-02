using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Prendas
{
    public class TipoPrenda
    {
        private int _idTipoPrenda;

        public int IdTipoPrenda { get; set; }

        private string _descripcionTipoPrenda;

        public string DescripcionTipoPrenda { get; set; }

        private List<Prenda> _prendas = new List<Prenda>();

        public List<Prenda> Prendas { get; set; }
    }
}
