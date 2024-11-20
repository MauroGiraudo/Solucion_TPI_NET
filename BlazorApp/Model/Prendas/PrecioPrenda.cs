using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Prendas
{
    public class PrecioPrenda
    {
        [Key]
        public int IdPrenda { get; set; }
        public Prenda? Prenda { get; set; }

        public DateTime? FecVigencia { get; set; }

        public float Valor { get; set; }
    }
}
