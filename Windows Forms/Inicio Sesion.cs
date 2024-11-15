using Windows_Forms.Model.Usuarios;
using Windows_Forms.Negocio;

namespace Windows_Forms
{
    public partial class form_InicioSesion : Form
    {
        public form_InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lklb_Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_Registro registro = new form_Registro();
            registro.ShowDialog();
        }

        private async void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData { UserName = txb_Usuario.Text, Contrasenia = txb_Contrasenia.Text };
            
            var usuario = await UsuarioNegocio.Login(login);

            if(usuario != null)
            {
                MessageBox.Show("Sesión Iniciada Correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioNegocio.Usuario = usuario;
                this.DialogResult = DialogResult.OK;

            } else
            {
                MessageBox.Show(string.Join("\n", Errors.Errores), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Errors.Errores.Clear();
            }
        }
    }
}
