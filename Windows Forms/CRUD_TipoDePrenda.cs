using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Prendas;
using Windows_Forms.Negocio;
using Windows_Forms.Shared;

namespace Windows_Forms
{
    public partial class form_CRUD_tipoDePrenda : Form
    {
        public form_CRUD_tipoDePrenda()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<TipoPrenda>>? tiposDePrenda;

        public IEnumerable<TipoPrenda> Cargar_TiposDePrenda()
        {
            tiposDePrenda = TipoPrendaNegocio.GetAll();
            return tiposDePrenda.Result;
        }

        private async void Cargar_Grid()
        {
            Task<IEnumerable<TipoPrenda>> task = new Task<IEnumerable<TipoPrenda>>(Cargar_TiposDePrenda);
            task.Start();
            dgv_tiposDePrenda.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            form_altaTipoDePrenda alta = new form_altaTipoDePrenda();
            alta.ShowDialog();
            Cargar_Grid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_tiposDePrenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceTipoPrendaSeleccionada = dgv_tiposDePrenda.SelectedRows[0].Index;
            TipoPrenda tipoPrenda = tiposDePrenda.Result.ToList()[indiceTipoPrendaSeleccionada];
            form_altaTipoDePrenda alta = new form_altaTipoDePrenda(tipoPrenda);
            alta.ShowDialog();
            Cargar_Grid();
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_tiposDePrenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceTipoPrendaSeleccionada = dgv_tiposDePrenda.SelectedRows[0].Index;
            var tipoPrenda = tiposDePrenda.Result.ToList()[indiceTipoPrendaSeleccionada];
            if(MessageBox.Show($"¿Está seguro que desea eliminar el tipo de prenda {tipoPrenda.DescripcionTipoPrenda}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await TipoPrendaNegocio.Delete(tipoPrenda))
                {
                    MessageBox.Show("Tipo de prenda eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Grid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el tipo de prenda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<TipoPrenda>> task = new Task<IEnumerable<TipoPrenda>>(Cargar_TiposDePrenda);
            task.Start();
            var tiposDePrenda = await task;
            var tiposDePrendaFiltrados =
                from tp in tiposDePrenda
                where tp.DescripcionTipoPrenda.ToLower().Contains(txb_buscar.Text.ToLower())
                select tp;
            dgv_tiposDePrenda.DataSource = tiposDePrendaFiltrados.ToList();
        }
    }
}
