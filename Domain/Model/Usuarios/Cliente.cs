using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Shared;
using Domain.Model.Compras;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model.Usuarios
{
    public class Cliente : Usuario
    {
        [Key]


        public List<Compra> Compras { get; set; }
    }
}
