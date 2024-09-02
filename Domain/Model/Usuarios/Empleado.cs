using Domain.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Cargas;

namespace Domain.Model.Usuarios
{
    public class Empleado : Usuario
    {
        private List<Carga> _cargas = new List<Carga>();

        public List<Carga> Cargas { get; set; }
    }
}
