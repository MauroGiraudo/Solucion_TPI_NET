using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Prendas;

namespace Domain.Model.Shared
{
    public abstract class Linea
    {
        [Key]
        public int NumeroLinea { get; set; }

        public int CantidadPrenda { get; set; }

        public int IdPrenda { get; set; }

        public Prenda Prenda { get; set; }
    }
}
