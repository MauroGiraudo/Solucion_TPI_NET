﻿using System;
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
using Windows_Forms.Model.Prendas;

namespace Windows_Forms
{
    public partial class form_carrito : Form
    {
        public form_carrito()
        {
            InitializeComponent();
            if (CompraNegocio.MiCompra == null)
            {
                Cargar_Grid_ConNuevaCompra();
            }
            else
            {
                Cargar_Grid_Void();
            }
            txb_total.Enabled = false;
        }

        private Task<IEnumerable<PrendaPedido>>? lineasDeCompra;

        public IEnumerable<PrendaPedido> Cargar_LineasDeCompra()
        {
            lineasDeCompra = LineaCompraNegocio.SetPrendasPedido();
            return lineasDeCompra.Result;
        }

        private async void Cargar_Grid_Void()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_LineasDeCompra);
            task.Start();
            dgv_carrito.DataSource = await task;
            txb_total.Text = await Cargar_Total() + " $";
        }

        private async Task Cargar_Grid()
        {
            Task<IEnumerable<PrendaPedido>> task = new Task<IEnumerable<PrendaPedido>>(Cargar_LineasDeCompra);
            task.Start();
            dgv_carrito.DataSource = await task;
            txb_total.Text = await Cargar_Total() + " $";
        }

        private async void Cargar_Grid_ConNuevaCompra()
        {
            await CompraNegocio.NuevaCompra();
            await Cargar_Grid();
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
            var bonif = await BonificacionNegocio.GetCurrent(Convert.ToInt32(total));
            if(bonif != null)
            {
                total = total * (1 - bonif.ProporcionDescuento / 100);
                lbl_descuento.Text = "¡Obtuvo un descuento del " + bonif.ProporcionDescuento + "%!";
                lbl_descuento.Visible = true;
            }
            else
            {
                lbl_descuento.Visible = false;
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
                MessageBox.Show("Compra realizada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            } else
            {
                MessageBox.Show("No ha iniciado ninguna compra aún", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
            
        }
    }
}
