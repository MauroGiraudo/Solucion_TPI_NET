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
    public partial class form_cargaActual : Form
    {
        public form_cargaActual()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<PrendaPedido>>? lineasDeCarga;

        public IEnumerable<PrendaPedido> Cargar_PrendasPedido()
        {
            lineasDeCarga = LineaCargaNegocio.SetPrendasPedido();
            return lineasDeCarga.Result;
        }

        public async void Cargar_Grid()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_PrendasPedido);
            task.Start();
            dgv_miCarga.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_miCarga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una carga para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrendaCarga = dgv_miCarga.SelectedRows[0].Index;
            PrendaPedido prendaPedido = lineasDeCarga.Result.ToList()[indicePrendaCarga];
            if (await LineaCargaNegocio.Delete(prendaPedido.NumeroLinea))
            {
                MessageBox.Show("Stock de la prenda seleccionada eliminado de la carga exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Grid();
            }
            else
            {
                MessageBox.Show("Error al eliminar de la carga el stock de la prenda seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_cargar_Click(object sender, EventArgs e)
        {
            if (CargaNegocio.MiCarga != null)
            {
                await CargaNegocio.Put(CargaNegocio.MiCarga);
                CargaNegocio.MiCarga = null;
                lineasDeCarga = null;
                dgv_miCarga.DataSource = null;
                MessageBox.Show("Compra realizada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No ha iniciado ninguna compra aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }
    }
}
