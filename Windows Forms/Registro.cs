using Windows_Forms.Model.Shared;
using Windows_Forms.Model.Usuarios;
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
using System.ComponentModel.DataAnnotations;
using static Windows_Forms.form_Registro;

namespace Windows_Forms
{
    public partial class form_Registro : Form
    {
        public class Rol
        {
            public string Nombre { get; set; }
        }
        public class MedioDePago
        {
            public string Nombre { get; set; }
        }
        public form_Registro()
        {
            InitializeComponent();
            Rol rol1 = new Rol { Nombre = "Cliente" };
            Rol rol2 = new Rol { Nombre = "Empleado" };
            MedioDePago medioDePago1 = new MedioDePago { Nombre = "Tarjeta De Crédito" };
            MedioDePago medioDePago2 = new MedioDePago { Nombre = "Tarjeta de Débito" };
            MedioDePago medioDePago3 = new MedioDePago { Nombre = "Transferencia" };
            List<Rol> roles = new List<Rol> { rol1, rol2 };
            List<MedioDePago> mediosDePago = new List<MedioDePago> { medioDePago1, medioDePago2, medioDePago3 };
            cb_rol.DataSource = roles;
            cb_rol.ValueMember = "Nombre";
            cb_medioDePago.DataSource = mediosDePago;
            cb_medioDePago.ValueMember = "Nombre";
        }

        public form_Registro(Usuario usuario)
        {
            InitializeComponent();
            Rol rol1 = new Rol { Nombre = "Cliente" };
            Rol rol2 = new Rol { Nombre = "Empleado" };
            MedioDePago medioDePago1 = new MedioDePago { Nombre = "Tarjeta De Crédito" };
            MedioDePago medioDePago2 = new MedioDePago { Nombre = "Tarjeta de Débito" };
            MedioDePago medioDePago3 = new MedioDePago { Nombre = "Transferencia" };
            List<Rol> roles = new List<Rol> { rol1, rol2 };
            List<MedioDePago> mediosDePago = new List<MedioDePago> { medioDePago1, medioDePago2, medioDePago3 };
            cb_rol.DataSource = roles;
            cb_rol.Enabled = false;
            cb_medioDePago.DataSource = mediosDePago;
            cb_rol.ValueMember = "Nombre";
            cb_rol.SelectedValue = usuario.TipoUsuario;
            if(usuario.TipoUsuario == "Cliente")
            {
                cb_medioDePago.ValueMember = "Nombre";
                cb_medioDePago.SelectedValue = usuario.MedioDePago;

            }
            btn_Aceptar.Text = "Actualizar";
            Text = "Actualizar Usuario";
            txb_nombre.Text = usuario.Nombre;
            txb_apellido.Text = usuario.Apellido;
            txb_userName.Text = usuario.UserName;
            txb_contrasenia.Text = usuario.Contrasenia;
            txb_confirmarContrasenia.Text = usuario.Contrasenia;
            txb_email.Text = usuario.Email;
            txb_telefono.Text = usuario.Telefono;
            dtp_FechaNacimiento.Value = usuario.FecNacimiento;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btn_Aceptar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            var usuario = new Usuario();
            if (txb_nombre.Text.Trim() == "")
            {
                errores.Add("Debe ingresar su nombre");
            }
            else if (txb_nombre.Text.Length > 50)
            {
                errores.Add("El nombre no puede tener más de 50 caracteres");
            }
            else
            {
                usuario.Nombre = txb_nombre.Text;
            }

            if (txb_apellido.Text.Trim() == "")
            {
                errores.Add("Debe ingresar su apellido");
            }
            else if (txb_apellido.Text.Length > 50)
            {
                errores.Add("El apellido no puede tener más de 50 caracteres");
            }
            else
            {
                usuario.Apellido = txb_apellido.Text;
            }

            if (txb_userName.Text.Trim() == "")
            {
                errores.Add("Debe ingresar su nombre de usuario");
            }
            else if (txb_userName.Text.Length > 50)
            {
                errores.Add("El nombre de usuario no puede tener más de 50 caracteres");
            }
            else
            {
                usuario.UserName = txb_userName.Text;
            }


            if (txb_contrasenia.Text.Trim() == "")
            {
                errores.Add("Debe ingresar la contraseña");
            }
            else if (txb_contrasenia.Text.Length > 50)
            {
                errores.Add("La contraseña no puede tener más de 50 caracteres");
            }
            else if (txb_contrasenia.Text != txb_confirmarContrasenia.Text)
            {
                errores.Add("Las contraseñas no coinciden");

            }
            else
            {
                usuario.Contrasenia = txb_contrasenia.Text;
            }


            var emailAddres = new EmailAddressAttribute();
            if (!emailAddres.IsValid(txb_email.Text))
            {
                errores.Add("El email ingresado no es válido");
            }
            else
            {
                usuario.Email = txb_email.Text;
            }

            usuario.FecNacimiento = dtp_FechaNacimiento.Value;

            usuario.Telefono = txb_telefono.Text;

            usuario.TipoUsuario = cb_rol.SelectedValue.ToString();

            if(usuario.TipoUsuario == "Cliente")
            {
                usuario.MedioDePago = cb_medioDePago.SelectedValue.ToString();
            }

            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errores.Clear();
                return;
            }
            if (btn_Aceptar.Text == "Actualizar")
            {
                usuario.IdUsu = UsuarioNegocio.Usuario.IdUsu;

                var cliente = await UsuarioNegocio.Put(usuario);
                if (cliente != null)
                {
                    UsuarioNegocio.Usuario = cliente;
                    MessageBox.Show("Usuario actualizado correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (await UsuarioNegocio.Post(usuario))
                {
                    MessageBox.Show("Usuario creado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Dispose();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txb_confirmarContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_rol.SelectedValue.ToString() == "Empleado")
            {
                cb_medioDePago.Enabled = false;
            }
            else
            {
                cb_medioDePago.Enabled = true;
            }
        }
    }
}
