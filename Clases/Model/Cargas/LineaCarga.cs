using Clases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Cargas
{
    public class LineaCarga : Linea
    {
        private Carga _carga;

        public Carga Carga { get; set; }
    }
}
