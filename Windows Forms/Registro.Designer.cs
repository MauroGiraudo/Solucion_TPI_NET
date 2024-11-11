namespace Windows_Forms
{
    partial class form_Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Registro));
            txb_userName = new TextBox();
            txb_contrasenia = new TextBox();
            txb_confirmarContrasenia = new TextBox();
            txb_nombre = new TextBox();
            txb_apellido = new TextBox();
            txb_email = new TextBox();
            txb_telefono = new TextBox();
            lbl_Usuario = new Label();
            lbl_Contrasenia = new Label();
            lbl_ConfContrasenia = new Label();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Email = new Label();
            lbl_Telefono = new Label();
            lbl_FechaNacimiento = new Label();
            dtp_FechaNacimiento = new DateTimePicker();
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            pnl_fondo = new Panel();
            cb_rol = new ComboBox();
            lbl_rol = new Label();
            pnl_logo = new Panel();
            pnl_fondo.SuspendLayout();
            SuspendLayout();
            // 
            // txb_userName
            // 
            txb_userName.Location = new Point(104, 92);
            txb_userName.Margin = new Padding(3, 4, 3, 4);
            txb_userName.Name = "txb_userName";
            txb_userName.Size = new Size(250, 27);
            txb_userName.TabIndex = 0;
            // 
            // txb_contrasenia
            // 
            txb_contrasenia.Location = new Point(104, 181);
            txb_contrasenia.Margin = new Padding(3, 4, 3, 4);
            txb_contrasenia.Name = "txb_contrasenia";
            txb_contrasenia.Size = new Size(250, 27);
            txb_contrasenia.TabIndex = 1;
            // 
            // txb_confirmarContrasenia
            // 
            txb_confirmarContrasenia.Location = new Point(104, 280);
            txb_confirmarContrasenia.Margin = new Padding(3, 4, 3, 4);
            txb_confirmarContrasenia.Name = "txb_confirmarContrasenia";
            txb_confirmarContrasenia.Size = new Size(250, 27);
            txb_confirmarContrasenia.TabIndex = 2;
            // 
            // txb_nombre
            // 
            txb_nombre.Location = new Point(517, 181);
            txb_nombre.Margin = new Padding(3, 4, 3, 4);
            txb_nombre.Name = "txb_nombre";
            txb_nombre.Size = new Size(250, 27);
            txb_nombre.TabIndex = 3;
            // 
            // txb_apellido
            // 
            txb_apellido.Location = new Point(517, 122);
            txb_apellido.Margin = new Padding(3, 4, 3, 4);
            txb_apellido.Name = "txb_apellido";
            txb_apellido.Size = new Size(250, 27);
            txb_apellido.TabIndex = 4;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(517, 245);
            txb_email.Margin = new Padding(3, 4, 3, 4);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(250, 27);
            txb_email.TabIndex = 5;
            txb_email.TextChanged += textBox6_TextChanged;
            // 
            // txb_telefono
            // 
            txb_telefono.Location = new Point(517, 304);
            txb_telefono.Margin = new Padding(3, 4, 3, 4);
            txb_telefono.Name = "txb_telefono";
            txb_telefono.Size = new Size(250, 27);
            txb_telefono.TabIndex = 6;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.BackColor = Color.Transparent;
            lbl_Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Usuario.Location = new Point(104, 68);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(150, 20);
            lbl_Usuario.TabIndex = 8;
            lbl_Usuario.Text = "Nombre de Usuario:";
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.BackColor = Color.Transparent;
            lbl_Contrasenia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Contrasenia.Location = new Point(104, 144);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(88, 20);
            lbl_Contrasenia.TabIndex = 9;
            lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_ConfContrasenia
            // 
            lbl_ConfContrasenia.AutoSize = true;
            lbl_ConfContrasenia.BackColor = Color.Transparent;
            lbl_ConfContrasenia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_ConfContrasenia.Location = new Point(104, 245);
            lbl_ConfContrasenia.Name = "lbl_ConfContrasenia";
            lbl_ConfContrasenia.Size = new Size(167, 20);
            lbl_ConfContrasenia.TabIndex = 10;
            lbl_ConfContrasenia.Text = "Confirmar Contraseña:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.Transparent;
            lbl_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Nombre.Location = new Point(517, 157);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(85, 20);
            lbl_Nombre.TabIndex = 11;
            lbl_Nombre.Text = "Nombre/s:";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.BackColor = Color.Transparent;
            lbl_Apellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Apellido.Location = new Point(517, 84);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(85, 20);
            lbl_Apellido.TabIndex = 12;
            lbl_Apellido.Text = "Apellido/s:";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Email.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Email.Location = new Point(517, 221);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(51, 20);
            lbl_Email.TabIndex = 13;
            lbl_Email.Text = "Email:";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.BackColor = Color.Transparent;
            lbl_Telefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Telefono.Location = new Point(517, 280);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(74, 20);
            lbl_Telefono.TabIndex = 14;
            lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_FechaNacimiento
            // 
            lbl_FechaNacimiento.AutoSize = true;
            lbl_FechaNacimiento.BackColor = Color.Transparent;
            lbl_FechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_FechaNacimiento.Location = new Point(517, 338);
            lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            lbl_FechaNacimiento.Size = new Size(138, 20);
            lbl_FechaNacimiento.TabIndex = 15;
            lbl_FechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Location = new Point(517, 362);
            dtp_FechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(250, 27);
            dtp_FechaNacimiento.TabIndex = 16;
            dtp_FechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.MediumSeaGreen;
            btn_Aceptar.Font = new Font("Segoe UI", 11F);
            btn_Aceptar.Location = new Point(251, 477);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(104, 37);
            btn_Aceptar.TabIndex = 17;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.IndianRed;
            btn_Cancelar.Font = new Font("Segoe UI", 11F);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.Location = new Point(496, 477);
            btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(104, 37);
            btn_Cancelar.TabIndex = 18;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // pnl_fondo
            // 
            pnl_fondo.BackgroundImage = (Image)resources.GetObject("pnl_fondo.BackgroundImage");
            pnl_fondo.Controls.Add(cb_rol);
            pnl_fondo.Controls.Add(lbl_rol);
            pnl_fondo.Controls.Add(pnl_logo);
            pnl_fondo.Controls.Add(btn_Cancelar);
            pnl_fondo.Controls.Add(btn_Aceptar);
            pnl_fondo.Controls.Add(dtp_FechaNacimiento);
            pnl_fondo.Controls.Add(lbl_FechaNacimiento);
            pnl_fondo.Controls.Add(lbl_Telefono);
            pnl_fondo.Controls.Add(lbl_Email);
            pnl_fondo.Controls.Add(lbl_Apellido);
            pnl_fondo.Controls.Add(lbl_Nombre);
            pnl_fondo.Controls.Add(lbl_ConfContrasenia);
            pnl_fondo.Controls.Add(lbl_Contrasenia);
            pnl_fondo.Controls.Add(lbl_Usuario);
            pnl_fondo.Controls.Add(txb_telefono);
            pnl_fondo.Controls.Add(txb_email);
            pnl_fondo.Controls.Add(txb_apellido);
            pnl_fondo.Controls.Add(txb_nombre);
            pnl_fondo.Controls.Add(txb_confirmarContrasenia);
            pnl_fondo.Controls.Add(txb_contrasenia);
            pnl_fondo.Controls.Add(txb_userName);
            pnl_fondo.Location = new Point(0, 0);
            pnl_fondo.Name = "pnl_fondo";
            pnl_fondo.Size = new Size(886, 537);
            pnl_fondo.TabIndex = 19;
            // 
            // cb_rol
            // 
            cb_rol.FormattingEnabled = true;
            cb_rol.Location = new Point(104, 364);
            cb_rol.Name = "cb_rol";
            cb_rol.Size = new Size(250, 28);
            cb_rol.TabIndex = 21;
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.BackColor = Color.Transparent;
            lbl_rol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_rol.Location = new Point(104, 338);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(32, 20);
            lbl_rol.TabIndex = 20;
            lbl_rol.Text = "Rol";
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.Transparent;
            pnl_logo.BackgroundImage = (Image)resources.GetObject("pnl_logo.BackgroundImage");
            pnl_logo.Location = new Point(793, 0);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(93, 104);
            pnl_logo.TabIndex = 19;
            // 
            // form_Registro
            // 
            AcceptButton = btn_Aceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancelar;
            ClientSize = new Size(886, 536);
            Controls.Add(pnl_fondo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_Registro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrarse";
            pnl_fondo.ResumeLayout(false);
            pnl_fondo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txb_userName;
        private TextBox txb_contrasenia;
        private TextBox txb_confirmarContrasenia;
        private TextBox txb_nombre;
        private TextBox txb_apellido;
        private TextBox txb_email;
        private TextBox txb_telefono;
        private TextBox textBox8;
        private Label lbl_Usuario;
        private Label lbl_Contrasenia;
        private Label lbl_ConfContrasenia;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Email;
        private Label lbl_Telefono;
        private Label lbl_FechaNacimiento;
        private DateTimePicker dtp_FechaNacimiento;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Panel pnl_fondo;
        private Panel pnl_logo;
        private ComboBox cb_rol;
        private Label lbl_rol;
    }
}