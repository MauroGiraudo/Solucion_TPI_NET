using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Cargas;
using Windows_Forms.Model.Prendas;
using Windows_Forms.Negocio;

namespace Windows_Forms
{
    public partial class form_detalleCarga : Form
    {
        public form_detalleCarga(CargaMuestra carga)
        {
            InitializeComponent();
            Cargar_Grid();
            txb_idOperacion.Text = carga.IdOperacion.ToString();
            dtp_fecha.Value = carga.FechaOperacion;
            txb_estado.Text = carga.EstadoOperacion;
        }

        private Task<IEnumerable<PrendaPedido>>? prendasPedido;

        public IEnumerable<PrendaPedido> Cargar_PrendasPedido()
        {
            prendasPedido = LineaCargaNegocio.SetPrendasPedido_CargaMuestra();
            return prendasPedido.Result;
        }
        private async void Cargar_Grid()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_PrendasPedido);
            task.Start();
            dgv_lineasDeCarga.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
