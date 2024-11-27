﻿using Windows_Forms.Model.Shared;
using Windows_Forms.Model.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Forms.Model.Prendas;

namespace Windows_Forms.Model.Compras
{
    public class Compra : Operacion
    {
        [Key]
        public int IdUsu { get; set; }
        public Usuario? Usuario { get; set; }
        public List<LineaCompra>? LineasCompra { get; set; }
    }

    public class CompraMuestra
    {
        public int IdOperacion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string EstadoOperacion { get; set; }
    }

    public class DetalleCompra
    {
        public int IdOperacion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string EstadoOperacion { get; set; }
        public List<PrendaPedido> PrendaPedido { get; set; }
        public Bonificacion? Bonificacion { get; set; }
    }
}
