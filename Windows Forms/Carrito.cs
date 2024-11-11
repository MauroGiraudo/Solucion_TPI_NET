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
    public partial class form_carrito : Form
    {
        public form_carrito()
        {
            InitializeComponent();
            if(CompraNegocio.MiCompra == null)
            {
                CompraNegocio.NuevaCompra();
            }
            Cargar_Grid();
            txb_total.Enabled = false;
        }

        private Task<IEnumerable<PrendaPedido>>? lineasDeCompra;

        public IEnumerable<PrendaPedido> Cargar_LineasDeCompra()
        {
            lineasDeCompra = LineaCompraNegocio.SetPrendasPedido();
            return lineasDeCompra.Result;
        }

        private async void Cargar_Grid()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_LineasDeCompra);
            task.Start();
            dgv_carrito.DataSource = await task;
            txb_total.Text = await Cargar_Total() + " $";
        }

        private async Task<float> Cargar_Total()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_LineasDeCompra);
            task.Start();
            var prendas = await task;
            float total = 0;
            foreach (PrendaPedido p in prendas)
            {
                total += p.Precio;
            }
            return total;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_carrito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda completa para eliminar del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indexPrenda = dgv_carrito.SelectedRows[0].Index;
            var linea = lineasDeCompra.Result.ToList()[indexPrenda];
            if (await LineaCompraNegocio.Delete(linea.NumeroLinea))
            {
                MessageBox.Show("Prenda eliminada del carrito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Grid();

            }
            else
            {
                MessageBox.Show("Error al eliminar la prenda del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_purchase_Click(object sender, EventArgs e)
        {
            if(CompraNegocio.MiCompra != null)
            {
                await CompraNegocio.Put(CompraNegocio.MiCompra);
                CompraNegocio.MiCompra = null;
                lineasDeCompra = null;
                dgv_carrito.DataSource = null;
                MessageBox.Show("Compra realizada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            } else
            {
                MessageBox.Show("No ha iniciado ninguna compra aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
            
        }
    }
}
