using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;

namespace Windows_Forms.Model.Shared
{
    public abstract class Linea
    {
        [Key]
        public int NumeroLinea { get; set; }

        public int CantidadPrenda { get; set; }

        public int IdPrenda { get; set; }

        public Prenda? Prenda { get; set; }
    }
}
