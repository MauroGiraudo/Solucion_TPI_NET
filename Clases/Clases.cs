using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        private int _id;

        public int Id { get; set; }

        private string _nombre;

        public string Nombre { get; set; }

        private string _apellido;

        public string Apellido { get; set; }

        private string _email;

        public string Email { get; set; }

        private string _telefono;

        public string Telefono { get; set; }

        private DateTime _fecNacimiento;

        public DateTime FecNacimiento { get; set; }

        private string _user;

        public string User { get; set; }

        private string _contraseña;

        public string Contraseña { get; set; }
    }

    public class Cliente : Usuario
    {
        private List<Compra> _compras = new List<Compra>();

        public List<Compra> Compras { get; set; }
    }

    public class Empleado : Usuario
    {
        private List<Carga> _cargas = new List<Carga>();

        public List<Carga> Cargas { get; set; }
    }

    public class Operacion
    {
        private int _idOperacion;

        public int IdOperacion { get; set; }

        private DateTime _fecOperacion;

        public DateTime FecOperacion { get; set; }

        private string _estadoOperacion;

        public string EstadoOperacion { get; set; }
    }

    public class Linea
    {
        private int _cantidadPrenda;

        public int CantidadPrenda { get; set; }

        private Prenda _prenda;

        public Prenda Prenda { get; set; }
    }

    public class Compra : Operacion
    {
        private Cliente _cliente;

        public Cliente Cliente { get; set; }
    }

    public class LineaCompra : Linea
    {
        private Compra _compra;

        public Compra Compra { get; set; }
    }

    public class Carga : Operacion
    {
        private Empleado _empleado;

        public Empleado Empleado { get; set; }
    }

    public class LineaCarga : Linea
    {
        private Carga _carga;

        public Carga Carga { get; set; }
    }


    public class Prenda
    {
        private int _idPrenda;

        public int IdPrenda { get; set; }

        private int _stock;

        public int Stock { get; set; }

        private int _puntoPedido;

        public int PuntoPedido { get; set; }

        private string _descripcion;

        public string Descripcion { get; set; }

        private string _talla;

        public string Talla { get; set; }

        private string _modelo;

        public string Modelo { get; set; }

        private TipoPrenda _tipoDePrenda;

        public TipoPrenda TipoDePrenda { get; set; }

        private Marca _marcaPrenda;

        public Marca MarcaPrenda { get; set; }

        private List<PrecioPrenda> _preciosPrenda = new List<PrecioPrenda>();

        public List<PrecioPrenda> PreciosPrenda { get; set; }
    }

    public class PrecioPrenda
    {
        private DateTime _fecVigencia;

        public DateTime FecVigencia { get; set; }

        private float _valor;

        public float Valor { get; set; }
    }

    public class TipoPrenda
    {
        private int _idTipoPrenda;

        public int IdTipoPrenda { get; set; }

        private string _descripcionTipoPrenda;

        public string DescripcionTipoPrenda { get; set; }

        private List<Prenda> _prendas = new List<Prenda>();

        public List<Prenda> Prendas { get; set; }
    }

    public class Marca
    {
        private int _idMarca;

        public int IdMarca { get; set; }

        private string _descripcionMarca;

        public string DescripcioMarca { get; set; }

        private List<Prenda> _prendas = new List<Prenda>();

        public List<Prenda> Prendas { get; set; }
    }

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
