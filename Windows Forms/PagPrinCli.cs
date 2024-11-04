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
    public partial class FormPagPrin : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public enum TipoUsuario
        {
            Administrador,
            Usuario,
        }
        public TipoUsuario TipoDeUsuarioActual { get; set; }
        public enum TipoPrenda
        {
            Ropa,
            Calzado,
            Accesorio,
        }
        public TipoPrenda TipoPrendaElegido { get; set; }

        public FormPagPrin()
        {
            InitializeComponent();
            TipoDeUsuarioActual = TipoUsuario.Administrador;
        }
        private void FormPagPrin_Load(object sender, EventArgs e)
        {
            VistaSegunUsuario();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void  AbrirFormulario(Form formulario)
        {
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
        

        private void imi_ofertas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_prendas, new FrmOferta());
        }

        private void msi_ropa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_prendas, new FrmRopa());
        }

        private void msi_calzado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_prendas, new FrmCalzado());
        }

        private void msi_accesorios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_prendas, new FrmAccesorio());
        }

        private void imi_info_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmInfo());
        }

        private void imi_carrito_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCarrito());
        }

        private void msi_misCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_miCuenta, new FrmCompras());

        }

        private void msi_miCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_miCuenta, new FrmMiCuenta());
        }

        private void VistaSegunUsuario()
        {
            switch (TipoDeUsuarioActual)
            {
                case TipoUsuario.Usuario:
                    imi_usuarios.Dispose();
                    imi_productos.Dispose();
                    break;
                case TipoUsuario.Administrador:
                    imi_carrito.Dispose();
                    imi_prendas.Dispose();
                    imi_info.Dispose();
                    msi_misCompras.Dispose();
                    break;
            }
        }

        private void msi_verProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_miCuenta, new FrmProductos("ver"));
        }

        private void msi_agrStock_Click(object sender, EventArgs e)
        {
            AbrirFormulario(imi_miCuenta, new FrmProductos(this,"agregar"));
        }

     
    }
}
