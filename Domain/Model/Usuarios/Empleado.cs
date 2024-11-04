using Domain.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Cargas;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model.Usuarios
{
    public class Empleado : Usuario
    {
        [Key]
        public List<Carga> Cargas { get; set; }
    }
}
