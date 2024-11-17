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
using Windows_Forms.Shared;

namespace Windows_Forms
{
    public partial class form_altaBonificacion : Form
    {
        public form_altaBonificacion()
        {
            InitializeComponent();
        }

        public form_altaBonificacion(Bonificacion bonificacion)
        {
            InitializeComponent();
            Text = "Modificar Bonificación";
            btn_aceptar.Text = "Modificar";
            txb_cantidadParaDescuento.Text = bonificacion.CantidadParaDescuento.ToString();
            txb_porcentajeDescuento.Text = bonificacion.ProporcionDescuento.ToString();
            dtp_fechaVigencia.Value = bonificacion.FecVigenciaBonificacion;
            lbl_idBonificacion.Text = bonificacion.IdBonificacion.ToString();
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(txb_cantidadParaDescuento.Text))
            {
                errores.Add("La cantidad no puede estar vacía");
            }
            if (!int.TryParse(txb_cantidadParaDescuento.Text, out int cantidad))
            {
                errores.Add("La cantidad debe ser un número");
            }
            if (cantidad <= 0)
            {
                errores.Add("La cantidad debe ser mayor a 0");
            }
            if (string.IsNullOrEmpty(txb_porcentajeDescuento.Text))
            {
                errores.Add("El porcentaje de descuento no puede estar vacío");
            }
            if (!float.TryParse(txb_porcentajeDescuento.Text, out float porcentaje))
            {
                errores.Add("El porcentaje de descuento debe ser un número");
            }
            if (porcentaje <= 0 || porcentaje > 100)
            {
                errores.Add("El porcentaje de descuento debe ser mayor a 0 y menor o igual a 100");
            }
            if (dtp_fechaVigencia.Value < DateTime.Today)
            {
                errores.Add("La fecha de vigencia debe ser mayor o igual a la fecha actual");
            }
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bonificacion bonificacion = new Bonificacion();
            bonificacion.CantidadParaDescuento = int.Parse(txb_cantidadParaDescuento.Text);
            bonificacion.ProporcionDescuento = float.Parse(txb_porcentajeDescuento.Text);
            bonificacion.FecVigenciaBonificacion = dtp_fechaVigencia.Value;
            if (btn_aceptar.Text == "Modificar")
            {
                bonificacion.IdBonificacion = int.Parse(lbl_idBonificacion.Text);
                if (await BonificacionNegocio.Put(bonificacion))
                {
                    MessageBox.Show("Nueva bonificacion registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                }
            }
            else
            {
                if (await BonificacionNegocio.Post(bonificacion))
                {
                    MessageBox.Show("Nueva bonificacion registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
