using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Prendas
{
    public class TipoPrenda
    {
        [Key]
        public int IdTipoPrenda { get; set; }

        public string DescripcionTipoPrenda { get; set; }

        public List<Prenda>? Prendas { get; set; }
    }
}
