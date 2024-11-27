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
using Windows_Forms.Model.Prendas;
using Windows_Forms.Negocio;
using Windows_Forms.Shared;

namespace Windows_Forms
{
    public partial class form_detalleCompra : Form
    {
        public form_detalleCompra()
        {
            InitializeComponent();
        }

        public form_detalleCompra(CompraMuestra compra, IEnumerable<PrendaPedido> prendas, float total, Bonificacion? bonificacion)
        {
            InitializeComponent();
            txb_idOperacion.Text = compra.IdOperacion.ToString();
            txb_estado.Text = compra.EstadoOperacion;
            dtp_fecha.Value = compra.FechaOperacion;
            dgv_compra.DataSource = prendas;

            if (bonificacion != null)
            {
                lbl_descuento.Text = $"¡Obtuvo un descuento del {bonificacion.ProporcionDescuento}% !";
                lbl_descuento.Visible = true;
            }
            else
            {
                lbl_descuento.Visible = false;
            }

            txb_total.Text = total.ToString();
            txb_idOperacion.Enabled = false;
            txb_estado.Enabled = false;
            dtp_fecha.Enabled = false;
            dgv_compra.Enabled = false;
            txb_total.Enabled = false;
        }

        private Bonificacion? Descuento(float total)
        {
            var bonif = BonificacionNegocio.GetCurrent(Convert.ToInt32(total)).Result;
            if (bonif == null)
            {
                return null;
            }
            return bonif;

        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_descargar_Click(object sender, EventArgs e)
        {
            if(await CompraNegocio.GenerarPDF(txb_idOperacion.Text))
            {
                MessageBox.Show("Detalle de compra descargado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(Errors.Errores.Count != 0)
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                    return;
                }
                MessageBox.Show("Error al descargar el detalle de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
