using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Model.Prendas;
using Windows_Forms.Negocio;
using Windows_Forms.Model.Cargas;

namespace Windows_Forms
{
    public partial class form_CRUD_prenda : Form
    {
        public form_CRUD_prenda()
        {
            InitializeComponent();
            Cargar_Grid();
        }
        private static int _cantidadPrenda = 0;
        public static int CantidadPrenda
        {
            get
            {
                return _cantidadPrenda;
            }
            set
            {
                _cantidadPrenda = value;
            }
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

        private void btn_alta_Click(object sender, EventArgs e)
        {
            form_altaPrenda alta = new form_altaPrenda();
            alta.ShowDialog();
            Cargar_Grid();
        }

        private Task<IEnumerable<Carga>>? cargaActualTask;

        public IEnumerable<Carga> Cargar_CargaActual()
        {
            cargaActualTask = CargaNegocio.GetEnProceso();
            return cargaActualTask.Result;
        }

        private async void btn_cargaStock_Click(object sender, EventArgs e)
        {
            if (CargaNegocio.MiCarga == null)
            {
                var car = Cargar_CargaActual().First();
                if (car == null)
                {
                    Carga carga = new Carga();
                    if (await CargaNegocio.Post(carga))
                    {
                        car = Cargar_CargaActual().First();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                CargaNegocio.MiCarga = car;
            }
            if (dgv_prendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda para cargar stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrendaMuestra = dgv_prendas.SelectedRows[0].Index;
            PrendaMuestra prendaMuestra = prendas.Result.ToList()[indicePrendaMuestra];
            form_cargaPrenda stock = new form_cargaPrenda(prendaMuestra);
            if (stock.ShowDialog() == DialogResult.OK)
            {
                LineaCarga lineaCarga = new LineaCarga();
                lineaCarga.IdPrenda = prendaMuestra.IdPrenda;
                lineaCarga.IdOperacion = CargaNegocio.MiCarga.IdOperacion;
                lineaCarga.CantidadPrenda = CantidadPrenda;
                if (await LineaCargaNegocio.Post(lineaCarga))
                {
                    CantidadPrenda = 0;
                    MessageBox.Show("Prenda agregada al carrito exitosamente. Ingrese a la opción 'Operaciones/Ver Carga Actual' para registrar la carga", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al agregar la prenda a la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cargar_Grid();
            }
        }
    }
}
