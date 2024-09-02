using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Prendas
{
    public class PrecioPrenda
    {
        private Prenda _prenda;

        public Prenda Prenda { get; set; }

        private DateTime _fecVigencia;

        public DateTime FecVigencia { get; set; }

        private float _valor;

        public float Valor { get; set; }
    }
}
