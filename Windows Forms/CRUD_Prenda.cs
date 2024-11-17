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
using Windows_Forms.Shared;

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
                    MessageBox.Show("Prenda agregada al carrito exitosamente.\nIngrese a la opción 'Operaciones/Ver Carga Actual' para registrar la carga", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                }
                Cargar_Grid();
            }
        }

        private async void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_prendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrenda = dgv_prendas.SelectedRows[0].Index;
            PrendaMuestra prendaMuestra = prendas.Result.ToList()[indicePrenda];
            Prenda prenda = await PrendaNegocio.GetOne(prendaMuestra.IdPrenda);
            PrecioPrenda precio = await PrecioPrendaNegocio.GetCurrentPrecio(prenda.IdPrenda);
            form_altaPrenda modificar = new form_altaPrenda(prenda, precio);
            modificar.ShowDialog();
            Cargar_Grid();
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<PrendaMuestra>> task = new Task<IEnumerable<PrendaMuestra>>(Cargar_Prendas);
            task.Start();
            var prendas = await task;
            var filtro =
                from p in prendas
                where p.Descripcion.ToLower().Contains(txb_buscar.Text.ToLower())
                select p;
            dgv_prendas.DataSource = filtro.ToList();
        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_prendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrenda = dgv_prendas.SelectedRows[0].Index;
            PrendaMuestra prendaMuestra = prendas.Result.ToList()[indicePrenda];
            Prenda prenda = await PrendaNegocio.GetOne(prendaMuestra.IdPrenda);
            if (MessageBox.Show($"¿Está seguro que desea eliminar la prenda {prenda.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await PrendaNegocio.Delete(prenda);
                MessageBox.Show("Prenda eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cargar_Grid();
        }

        private async void btn_cargaPrecio_Click(object sender, EventArgs e)
        {
            if (dgv_prendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda para cargar un nuevo precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrenda = dgv_prendas.SelectedRows[0].Index;
            PrendaMuestra prendaMuestra = prendas.Result.ToList()[indicePrenda];
            Prenda prenda = await PrendaNegocio.GetOne(prendaMuestra.IdPrenda);
            form_nuevoPrecio precio = new form_nuevoPrecio(prenda.IdPrenda);
            precio.ShowDialog();
            Cargar_Grid();
        }
    }
}
