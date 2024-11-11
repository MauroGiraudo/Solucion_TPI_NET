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

namespace Windows_Forms
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PaginaPrincipal_Shown(object sender, EventArgs e)
        {
            form_InicioSesion appLogin = new form_InicioSesion();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            ClienteNegocio.Logout();
        }

        private void editarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Registro registro = new form_Registro(ClienteNegocio.Cliente);
            registro.ShowDialog();
        }

        private void verPrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Prendas formPrendas = new form_Prendas();
            formPrendas.ShowDialog();
        }

        private void verCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_carrito carrito = new form_carrito();
            carrito.ShowDialog();
        }

        private void verMisComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_comprasCliente compras = new form_comprasCliente();
            compras.ShowDialog();
        }
    }
}
