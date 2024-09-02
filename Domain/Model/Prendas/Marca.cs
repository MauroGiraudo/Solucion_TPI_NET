using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Prendas
{
    public class Marca
    {
        private int _idMarca;

        public int IdMarca { get; set; }

        private string _descripcionMarca;

        public string DescripcionMarca { get; set; }

        private List<Prenda> _prendas = new List<Prenda>();

        public List<Prenda> Prendas { get; set; }
    }
}
