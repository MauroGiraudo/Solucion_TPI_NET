using Clases.Shared;
using Clases.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Cargas
{
    public class Carga : Operacion
    {
        private Empleado _empleado;

        public Empleado Empleado { get; set; }
    }
}
