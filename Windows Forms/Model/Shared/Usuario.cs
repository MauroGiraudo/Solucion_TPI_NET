using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms.Model.Shared
{
    public abstract class Usuario
    {
        [Key]
        public int IdUsu { get; set; }

        public string Nombre { get; set; }
      
        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public DateTime FecNacimiento { get; set; }

        public string UserName { get; set; }
       
        public string Contrasenia { get; set; }

        public string? TipoUsuario { get; set; }
    }
}
