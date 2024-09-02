using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Shared
{
    public class Operacion
    {
        private int _idOperacion;

        public int IdOperacion { get; set; }

        private DateTime _fecOperacion;

        public DateTime FecOperacion { get; set; }

        private string _estadoOperacion;

        public string EstadoOperacion { get; set; }
    }
}
