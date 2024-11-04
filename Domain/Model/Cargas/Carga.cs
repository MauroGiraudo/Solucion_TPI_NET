using Domain.Model.Shared;
using Domain.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Cargas
{
    public class Carga : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Empleado Empleado { get; set; }
    
        public List<LineaCarga> LineasCarga { get; set; }
    }
}
