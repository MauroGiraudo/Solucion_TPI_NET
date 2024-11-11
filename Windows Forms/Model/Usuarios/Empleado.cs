using Windows_Forms.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Cargas;
using System.ComponentModel.DataAnnotations;

namespace Windows_Forms.Model.Usuarios
{
    public class Empleado : Usuario
    {
        public List<Carga>? Cargas { get; set; }
    }
}
