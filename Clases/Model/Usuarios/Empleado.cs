using Clases.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Cargas;

namespace Clases.Usuarios
{
    public class Empleado : Usuario
    {
        private List<Carga> _cargas = new List<Carga>();

        public List<Carga> Cargas { get; set; }
    }
}
