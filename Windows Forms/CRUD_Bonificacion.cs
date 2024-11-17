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
    public partial class form_CRUD_Bonificacion : Form
    {
        public form_CRUD_Bonificacion()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<Bonificacion>>? bonificaciones;

        public IEnumerable<Bonificacion> Cargar_Bonificacion()
        {
            bonificaciones = BonificacionNegocio.GetAll();
            return bonificaciones.Result;
        }
        private async void Cargar_Grid()
        {
            Task<IEnumerable<Bonificacion>> task = new Task<IEnumerable<Bonificacion>>(Cargar_Bonificacion);
            task.Start();
            dgv_bonificaciones.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            form_altaBonificacion alta = new form_altaBonificacion();
            alta.ShowDialog();
            Cargar_Grid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_bonificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una bonificación completa para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceBonif = dgv_bonificaciones.SelectedRows[0].Index;
            Bonificacion bonificacion = bonificaciones.Result.ToList()[indiceBonif];
            form_altaBonificacion modificar = new form_altaBonificacion(bonificacion);
            modificar.ShowDialog();
            Cargar_Grid();
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_bonificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una bonificación completa para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceBonif = dgv_bonificaciones.SelectedRows[0].Index;
            Bonificacion bonificacion = bonificaciones.Result.ToList()[indiceBonif];
            if(MessageBox.Show($"¿Está seguro que desea eliminar la bonificacion {bonificacion.IdBonificacion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await BonificacionNegocio.Delete(bonificacion);
                MessageBox.Show("La bonificación ha sido eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Grid();
            }
        }
    }
}
