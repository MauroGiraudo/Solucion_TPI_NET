using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Compras
{
    public class Bonificacion
    {
        private int _idBonificacion;

        public int IdBonificacion { get; set; }

        private int _cantidadParaDescuento;

        public int CantidadParaDescuento { get; set; }

        private float _proporcionDescuento;

        public float ProporcionDescuento { get; set; }

        private DateTime _fecVigenciaBonificacion;

        public DateTime FecVigenciaBonificacion { get; set; }
    }
}
