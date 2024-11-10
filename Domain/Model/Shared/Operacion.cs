using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Shared
{
    public abstract class Operacion
    {
        [Key]
        public int IdOperacion { get; set; }

        public DateTime FecOperacion { get; set; }

        public string? EstadoOperacion { get; set; }
    }
}
