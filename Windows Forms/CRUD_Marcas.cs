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
    public partial class form_CRUD_marca : Form
    {
        public form_CRUD_marca()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<Marca>>? marcas;

        public IEnumerable<Marca> Cargar_Marcas()
        {
            marcas = MarcaNegocio.GetAll();
            return marcas.Result;
        }

        private async void Cargar_Grid()
        {
            Task<IEnumerable<Marca>> task = new Task<IEnumerable<Marca>>(Cargar_Marcas);
            task.Start();
            dgv_marcas.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            form_altaMarca alta = new form_altaMarca();
            alta.ShowDialog();
            Cargar_Grid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_marcas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una marca para poder modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceMarca = dgv_marcas.SelectedRows[0].Index;
            Marca marca = marcas.Result.ToList()[indiceMarca];
            form_altaMarca modificar = new form_altaMarca(marca);
            modificar.ShowDialog();
            Cargar_Grid();
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_marcas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una marca para poder eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceMarca = dgv_marcas.SelectedRows[0].Index;
            Marca marca = marcas.Result.ToList()[indiceMarca];
            if (MessageBox.Show($"¿Está seguro que desea eliminar la marca {marca.DescripcionMarca}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await MarcaNegocio.Delete(marca))
                {
                    MessageBox.Show("La marca ha sido eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Grid();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Marca>> task = new Task<IEnumerable<Marca>>(Cargar_Marcas);
            task.Start();
            var marcas = await task;
            var marcasFiltradas =
                from m in marcas
                where m.DescripcionMarca.ToLower().Contains(txb_buscar.Text.ToLower())
                select m;
            dgv_marcas.DataSource = marcasFiltradas.ToList();
        }
    }
}
