using Domain.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Cargas
{
    public class LineaCarga : Linea
    {
        private Carga _carga;

        public Carga Carga { get; set; }
    }
}
