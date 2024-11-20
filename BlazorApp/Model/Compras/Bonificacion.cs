using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Compras
{
    public class Bonificacion
    {
        [Key]
        public int IdBonificacion { get; set; }

        public int CantidadParaDescuento { get; set; }

        public float ProporcionDescuento { get; set; }

        public DateTime FecVigenciaBonificacion { get; set; }
    }
}
