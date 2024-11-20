using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Model.Prendas;

namespace BlazorApp.Model.Shared
{
    public abstract class Linea
    {
        [Key]
        public int NumeroLinea { get; set; }

        [Required]
        public int CantidadPrenda { get; set; }

        public int IdPrenda { get; set; }

        public Prenda? Prenda { get; set; }
    }
}
