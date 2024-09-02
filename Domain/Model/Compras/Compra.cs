using Domain.Model.Shared;
using Domain.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Compras
{
    public class Compra : Operacion
    {
        private Cliente _cliente;

        public Cliente Cliente { get; set; }
    }
}
