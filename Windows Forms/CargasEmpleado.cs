using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Cargas;
using Windows_Forms.Negocio;

namespace Windows_Forms
{
    public partial class form_cargasEmpleado : Form
    {
        public form_cargasEmpleado()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<CargaMuestra>>? cargasMuestra;

        public IEnumerable<CargaMuestra> Cargar_CargasMuestra()
        {
            cargasMuestra = CargaNegocio.SetCargasMuestra();
            return cargasMuestra.Result;
        }
        private async void Cargar_Grid()
        {
            Task<IEnumerable<CargaMuestra>> task = new Task<IEnumerable<CargaMuestra>>(Cargar_CargasMuestra);
            task.Start();
            dgv_cargas.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_detalleCarga_Click(object sender, EventArgs e)
        {
            if(dgv_cargas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero seleccione una carga para poder visualizar su detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indiceCargaMuestra = dgv_cargas.SelectedRows[0].Index;
            CargaNegocio.CargaMuestra = cargasMuestra?.Result.ToList()[indiceCargaMuestra];
            form_detalleCarga detalleCarga = new form_detalleCarga(CargaNegocio.CargaMuestra);
            detalleCarga.ShowDialog();
        }
    }
}
