﻿using Windows_Forms.Model.Shared;
using Windows_Forms.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;
using Windows_Forms.Model.Compras;

namespace Windows_Forms.Model.Cargas
{
    public class Carga : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Usuario? Usuario { get; set; }
    
        public List<LineaCarga>? LineasCarga { get; set; }
    }
    public class CargaMuestra
    {
        public int IdOperacion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string EstadoOperacion { get; set; }
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
