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
            mnu_comprar.Visible = false;
            mnu_operaciones.Visible = false;
            form_InicioSesion appLogin = new form_InicioSesion();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                if (UsuarioNegocio.Usuario.TipoUsuario == "Empleado")
                {
                    mnu_comprar.Visible = false;
                    mnu_operaciones.Visible = true;
                }
                else
                {
                    mnu_operaciones.Visible = false;
                    mnu_comprar.Visible = true;
                }
                /*if(UsuarioNegocio.Usuario.TipoUsuario == "Cliente")
                {
                    
                }*/
            }

        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            UsuarioNegocio.Logout();
            PaginaPrincipal_Shown(sender, e);
        }

        private void editarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Registro registro = new form_Registro(UsuarioNegocio.Usuario);
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

        private void mnu_prendas_Click(object sender, EventArgs e)
        {
            form_CRUD_prenda prendas = new form_CRUD_prenda();
            prendas.ShowDialog();
        }

        private void mnu_marcas_Click(object sender, EventArgs e)
        {
            form_CRUD_marca marcas = new form_CRUD_marca();
            marcas.ShowDialog();
        }

        private void mnu_tiposDePrenda_Click(object sender, EventArgs e)
        {
            form_CRUD_tipoDePrenda tiposDePrenda = new form_CRUD_tipoDePrenda();
            tiposDePrenda.ShowDialog();
        }

        private void verCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_cargaActual carga = new form_cargaActual();
            carga.ShowDialog();
        }

        private void verCargasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_cargasEmpleado cargas = new form_cargasEmpleado();
            cargas.ShowDialog();
        }
    }
}
