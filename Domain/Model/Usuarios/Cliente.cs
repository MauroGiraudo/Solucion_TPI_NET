using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Shared;
using Domain.Model.Compras;

namespace Domain.Model.Usuarios
{
    public class Cliente : Usuario
    {
        private List<Compra> _compras = new List<Compra>();

        public List<Compra> Compras { get; set; }
    }
}
