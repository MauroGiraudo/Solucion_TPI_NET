using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Windows_Forms
{
    public partial class FormPagPrinCli : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public FormPagPrinCli()
        {
            InitializeComponent();
        }

        private void gb_Header_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPagPrinCli_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.LavenderBlush;
            }
            menu.BackColor = Color.Gray;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Purple;
            pnl_Body.Controls.Add(formulario);
            formulario.Show();

        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconPrendas, new FrmOferta());
        }

        private void ropaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconPrendas, new FrmRopa());
        }

        private void calzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconPrendas, new FrmCalzado());
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconPrendas, new FrmAccesorio());
        }

        private void iconInfo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmInfo());
        }

        private void iconCarrito_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCarrito());
        }

        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMiCuenta, new FrmCompras());

        }

        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMiCuenta, new FrmMiCuenta());
        }
    }
}
