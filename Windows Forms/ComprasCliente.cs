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
using Windows_Forms.Negocio;

namespace Windows_Forms
{
    public partial class form_comprasCliente : Form
    {
        public form_comprasCliente()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<CompraMuestra>>? misCompras;

        public IEnumerable<CompraMuestra> Cargar_MisCompras()
        {
            misCompras = CompraNegocio.SetComprasMuestra();
            return misCompras.Result;
        }

        private async void Cargar_Grid()
        {
            Task<IEnumerable<CompraMuestra>> task = new Task<IEnumerable<CompraMuestra>>(Cargar_MisCompras);
            task.Start();
            dgv_compras.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if(dgv_compras.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una compra para ver el detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexCompra = dgv_compras.SelectedRows[0].Index;
            CompraMuestra compra = misCompras.Result.ToList()[indexCompra];
            var prendas = LineaCompraNegocio.SetPrendasPedido(compra);
            //prendas.Start();
            var misPrendas = prendas.Result.ToList();
            form_detalleCompra detalle = new form_detalleCompra(compra, misPrendas);
            detalle.ShowDialog();
        }
    }
}
