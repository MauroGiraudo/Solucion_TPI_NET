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

namespace Windows_Forms
{
    public partial class form_CRUD_prenda : Form
    {
        public form_CRUD_prenda()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<PrendaMuestra>> prendas;

        public IEnumerable<PrendaMuestra> Cargar_Prendas()
        {
            prendas = PrendaNegocio.SetPrendasMuestra();
            return prendas.Result;
        }

        private async void Cargar_Grid()
        {
            Task<IEnumerable<PrendaMuestra>> task = new Task<IEnumerable<PrendaMuestra>>(Cargar_Prendas);
            task.Start();
            dgv_prendas.DataSource = await task;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
