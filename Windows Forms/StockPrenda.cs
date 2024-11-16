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
using Windows_Forms.Model.Cargas;

namespace Windows_Forms
{
    public partial class form_cargaPrenda : Form
    {
        public form_cargaPrenda()
        {
            InitializeComponent();
        }
        public form_cargaPrenda(PrendaMuestra prenda)
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txb_stock.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cantidad <= 0)
                {
                    MessageBox.Show("Ingrese un número mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            form_CRUD_prenda.CantidadPrenda = cantidad;
            this.DialogResult = DialogResult.OK;
        }
    }
}
