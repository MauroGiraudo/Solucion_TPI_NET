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
    public partial class form_nuevoPrecio : Form
    {
        public form_nuevoPrecio(int IdPrenda)
        {
            InitializeComponent();
            lbl_IdPrenda.Text = IdPrenda.ToString();
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if (dtp_fechaVigencia.Value < DateTime.Today)
            {
                errores.Add("La fecha de vigencia del precio no puede ser menor a la fecha actual");
            }
            if (!int.TryParse(txb_valor.Text, out int valor))
            {
                errores.Add("El nuevo precio debe ser un número");
            }
            if (valor <= 0)
            {
                errores.Add("El nuevo precio no puede ser menor o igual a 0");
            }
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrecioPrenda precio = new PrecioPrenda();
            precio.IdPrenda = Convert.ToInt32(lbl_IdPrenda.Text);
            precio.FecVigencia = dtp_fechaVigencia.Value;
            precio.Valor = float.Parse(txb_valor.Text);
            if(await PrecioPrendaNegocio.Add(precio))
            {
                MessageBox.Show("Nuevo precio registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Errors.Errores.Clear();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void form_nuevoPrecio_Load(object sender, EventArgs e)
        {

        }
    }
}
