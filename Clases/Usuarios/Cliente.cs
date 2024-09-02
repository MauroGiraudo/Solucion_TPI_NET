using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Shared;
using Clases.Compras;

namespace Clases.Usuarios
{
    public class Cliente : Usuario
    {
        private List<Compra> _compras = new List<Compra>();

        public List<Compra> Compras { get; set; }
    }
}
