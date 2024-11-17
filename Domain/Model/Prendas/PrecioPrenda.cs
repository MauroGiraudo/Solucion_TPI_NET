using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Prendas
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
