using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Prendas;

namespace Domain.Model.Shared
{
    public class Linea
    {
        private int _numeroLinea;

        public int NumeroLinea { get; set; }

        private int _cantidadPrenda;

        public int CantidadPrenda { get; set; }

        private Prenda _prenda;

        public Prenda Prenda { get; set; }
    }
}
