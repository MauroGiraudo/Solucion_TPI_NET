using Windows_Forms.Model.Shared;
using Windows_Forms.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms.Model.Cargas
{
    public class Carga : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Usuario? Usuario { get; set; }
    
        public List<LineaCarga>? LineasCarga { get; set; }
    }
}
