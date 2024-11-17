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
    public partial class form_altaTipoDePrenda : Form
    {
        public form_altaTipoDePrenda()
        {
            InitializeComponent();
        }

        public form_altaTipoDePrenda(TipoPrenda tipoPrenda)
        {
            InitializeComponent();
            lbl_id.Text = tipoPrenda.IdTipoPrenda.ToString();
            txb_descripcion.Text = tipoPrenda.DescripcionTipoPrenda;
            Text = "Modificar tipo de prenda";
            lbl_descripcion.Text = "Modifique el nombre del tipo de prenda";
            btn_aceptar.Text = "Modificar";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if(txb_descripcion.Text.Length > 50)
            {
                errores.Add("El nombre del tipo de prenda no puede superar los 50 caracteres");
            }
            if(txb_descripcion.Text.Trim() == "")
            {
                errores.Add("El nombre del tipo de prenda no puede estar vacío");
            }
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TipoPrenda tipoPrenda = new TipoPrenda();
            tipoPrenda.DescripcionTipoPrenda = Format.Capitalizar(txb_descripcion.Text);
            if(btn_aceptar.Text == "Modificar")
            {
                tipoPrenda.IdTipoPrenda = int.Parse(lbl_id.Text);
                if(await TipoPrendaNegocio.Update(tipoPrenda))
                {
                    MessageBox.Show("El tipo de prenda ha sido modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                } else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                }

            } else
            {
                if (await TipoPrendaNegocio.Add(tipoPrenda))
                {
                    MessageBox.Show("El tipo de prenda ha sido creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Errors.Errores.Clear();
                }
            }
            
        }
    }
}
