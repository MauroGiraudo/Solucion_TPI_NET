using Domain.Model.Shared;
using Domain.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Compras
{
    public class Compra : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Usuario? Usuario { get; set; }
        public List<LineaCompra>? LineasCompra { get; set; }
    }
}
