using BlazorApp.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model.Cargas
{
    public class LineaCarga : Linea
    {
        [Key]
        public int IdUsu { get; set; }
        
        [Key]
        public int IdOperacion { get; set; }
        public Carga? Carga { get; set; }
    }
}
