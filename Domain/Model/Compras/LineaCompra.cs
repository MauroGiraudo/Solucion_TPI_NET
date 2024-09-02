using Domain.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Compras
{
    public class LineaCompra : Linea
    {
        private Compra _compra;

        public Compra Compra { get; set; }
    }
}
