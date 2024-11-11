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

namespace Windows_Forms
{
    public partial class form_Registro : Form
    {
        public form_Registro()
        {
            InitializeComponent();
            List<string> roles = new List<string> { "Cliente", "Empleado" };
            cb_rol.DataSource = roles;
        }

        public form_Registro(Cliente cliente)
        {
            InitializeComponent();
            List<string> roles = new List<string> { "Cliente", "Empleado" };
            cb_rol.DataSource = roles;
            btn_Aceptar.Text = "Actualizar";
            Text = "Actualizar Usuario";
            txb_nombre.Text = cliente.Nombre;
            txb_apellido.Text = cliente.Apellido;
            txb_userName.Text = cliente.UserName;
            txb_contrasenia.Text = cliente.Contrasenia;
            txb_confirmarContrasenia.Text = cliente.Contrasenia;
            txb_email.Text = cliente.Email;
            txb_telefono.Text = cliente.Telefono;
            dtp_FechaNacimiento.Value = cliente.FecNacimiento;
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
            Cliente usuario = new Cliente();
            if (txb_nombre.Text == "")
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

            if (txb_apellido.Text == "")
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

            if (txb_userName.Text == "")
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


            if (txb_contrasenia.Text == "")
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

            //usuario.MedioDePago = txb_medioPago.Text;
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errores.Clear();
            }
            if (btn_Aceptar.Text == "Actualizar")
            {
                usuario.IdUsu = ClienteNegocio.Cliente.IdUsu;
                var cliente = await ClienteNegocio.Put(usuario);
                if(cliente != null)
                {
                    ClienteNegocio.Cliente = cliente;
                    MessageBox.Show("Usuario actualizado correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                await ClienteNegocio.Post(usuario);
                MessageBox.Show("Usuario creado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Dispose();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
