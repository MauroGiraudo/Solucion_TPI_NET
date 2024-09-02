using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Shared
{
    public class Usuario
    {
        private int _idUsu;

        public int IdUsu { get; set; }

        private string _nombre;

        public string Nombre { get; set; }

        private string _apellido;

        public string Apellido { get; set; }

        private string _email;

        public string Email { get; set; }

        private string _telefono;

        public string Telefono { get; set; }

        private DateTime _fecNacimiento;

        public DateTime FecNacimiento { get; set; }

        private string _userName;

        public string UserName { get; set; }

        private string _contraseña;
       
        public string Contraseña { get; set; }

        private string _tipoUsuario;

        public string TipoUsuario { get; set; }
    }
}
