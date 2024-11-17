using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms.Model.Prendas
{
    public class Marca
    {
        [Key]

        public int IdMarca { get; set; }

        public string DescripcionMarca { get; set; }

        public List<Prenda>? Prendas { get; set; }
    }
}
