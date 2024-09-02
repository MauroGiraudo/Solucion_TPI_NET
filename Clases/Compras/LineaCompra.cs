using Clases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Compras
{
    public class LineaCompra : Linea
    {
        private Compra _compra;

        public Compra Compra { get; set; }
    }
}
