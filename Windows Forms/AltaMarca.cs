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
    public partial class form_altaMarca : Form
    {
        public form_altaMarca()
        {
            InitializeComponent();
        }

        public form_altaMarca(Marca marca)
        {
            InitializeComponent();
            Text = "Modificar Marca";
            txb_descripcion.Text = marca.DescripcionMarca;
            lbl_id.Text = marca.IdMarca.ToString();
            lbl_descripcion.Text = "Modifique el nombre de la marca: ";
            btn_aceptar.Text = "Modificar";
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if (txb_descripcion.Text.Length > 50)
            {
                errores.Add("La descripción no puede superar los 50 caracteres");
            }
            if (string.IsNullOrEmpty(txb_descripcion.Text))
            {
                errores.Add("La descripción no puede estar vacía");
            }
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Marca marca = new Marca();
            marca.DescripcionMarca = Format.Capitalizar(txb_descripcion.Text);
            if(btn_aceptar.Text == "Modificar")
            {
                marca.IdMarca = int.Parse(lbl_id.Text);
                if(await MarcaNegocio.Update(marca))
                {
                    MessageBox.Show("La marca ha sido modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } 
            else
            {
                if(await MarcaNegocio.Add(marca))
                {
                    MessageBox.Show("La marca ha sido registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
