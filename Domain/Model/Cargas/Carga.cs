using Domain.Model.Shared;
using Domain.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Prendas;
using Domain.Model.Compras;

namespace Domain.Model.Cargas
{
    public class Carga : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Usuario? Usuario { get; set; }
    
        public List<LineaCarga>? LineasCarga { get; set; }
    }
    public class DetalleCarga
    {
        public int IdOperacion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string EstadoOperacion { get; set; }
        public List<PrendaPedido> PrendaPedido { get; set; }
        public Bonificacion? Bonificacion { get; set; }
    }
}
