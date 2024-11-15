using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Compras;

namespace Windows_Forms
{
    public partial class form_detalleCompra : Form
    {
        public form_detalleCompra()
        {
            InitializeComponent();
        }

        public form_detalleCompra(CompraMuestra compra, IEnumerable<PrendaPedido> prendas, float total)
        {
            InitializeComponent();
            txb_idOperacion.Text = compra.IdOperacion.ToString();
            txb_estado.Text = compra.EstadoOperacion;
            dtp_fecha.Value = compra.FechaOperacion;
            dgv_compra.DataSource = prendas;
            txb_total.Text = total.ToString();
            txb_idOperacion.Enabled = false;
            txb_estado.Enabled = false;
            dtp_fecha.Enabled = false;
            dgv_compra.Enabled = false;
            txb_total.Enabled = false;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
