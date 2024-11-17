using Windows_Forms.Model.Prendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Negocio;
using Windows_Forms.Model.Compras;
using Windows_Forms.Shared;

namespace Windows_Forms
{
    public partial class form_Prendas : Form
    {
        public form_Prendas()
        {
            InitializeComponent();
            Cargar_Grid();
        }

        private Task<IEnumerable<PrendaMuestra>>? prendas;

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

        public IEnumerable<PrendaMuestra> Cargar_Prendas()
        {
            prendas = PrendaNegocio.SetPrendasMuestra();
            return prendas.Result;
        }

        public async void Cargar_Grid()
        {
            Task<IEnumerable<PrendaMuestra>> task = new Task<IEnumerable<PrendaMuestra>>(Cargar_Prendas);
            task.Start();
            dgv_prendas.DataSource = await task;
        }

        private Task<IEnumerable<Compra>>? compraActualTask;

        public IEnumerable<Compra> Cargar_CompraActual()
        {
            compraActualTask = CompraNegocio.GetEnProceso();
            return compraActualTask.Result;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_agregar_Click(object sender, EventArgs e)
        {
            if (CompraNegocio.MiCompra == null)
            {
               /*var comp = Cargar_CompraActual().First();
               if ( comp == null)
               {
                  Compra compra = new Compra();
                  if (await CompraNegocio.Post(compra))
                  {
                        comp = Cargar_CompraActual().First();

                    }
                  else
                  {
                      MessageBox.Show("Error al crear la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return;
                  }
               }
                CompraNegocio.MiCompra = comp;*/
               await CompraNegocio.NuevaCompra();
            }
            if (dgv_prendas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una prenda completa para agregar al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int indicePrenda = dgv_prendas.SelectedRows[0].Index;
            var prenda = prendas.Result.ToList()[indicePrenda];
            form_cantidadPrenda formCantidad = new form_cantidadPrenda();
            if (formCantidad.ShowDialog() == DialogResult.OK)
            {
                if(CantidadPrenda > prenda.Stock)
                {
                    MessageBox.Show("No hay suficiente stock de la prenda seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LineaCompra lineaCompra = new LineaCompra();
                lineaCompra.IdPrenda = prenda.IdPrenda;
                lineaCompra.IdOperacion = CompraNegocio.MiCompra.IdOperacion;
                lineaCompra.CantidadPrenda = CantidadPrenda;
                await LineaCompraNegocio.Post(lineaCompra);
                CantidadPrenda = 0;
                MessageBox.Show("Prenda agregada al carrito exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<PrendaMuestra>> task = new Task<IEnumerable<PrendaMuestra>>(Cargar_Prendas);
            task.Start();
            var misPrendas = await task;
            var filteredPrendas = from p in misPrendas
                                  where p.Descripcion.ToLower().Contains(txb_buscar.Text.ToLower())
                                  select p;
            dgv_prendas.DataSource = filteredPrendas.ToList();
        }
    }
}
