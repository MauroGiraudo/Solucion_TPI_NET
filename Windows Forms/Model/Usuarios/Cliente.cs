using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Shared;
using Windows_Forms.Model.Compras;
using System.ComponentModel.DataAnnotations;

namespace Windows_Forms.Model.Usuarios
{
    public class LoginData
    {
        public string UserName { get; set; }
        public string Contrasenia { get; set; }
    }
    public class Cliente : Usuario
    {
        public string? MedioDePago { get; set; }
        public List<Compra>? Compras { get; set; }
    }
}
