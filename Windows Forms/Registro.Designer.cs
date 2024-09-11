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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
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
            pnl_logo = new Panel();
            pnl_fondo.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 122);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 221);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 328);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(517, 181);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(517, 122);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(517, 245);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(517, 304);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 27);
            textBox7.TabIndex = 6;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.BackColor = Color.Transparent;
            lbl_Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Usuario.Location = new Point(104, 84);
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
            lbl_Contrasenia.Location = new Point(104, 185);
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
            lbl_ConfContrasenia.Location = new Point(104, 292);
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
            // 
            // pnl_fondo
            // 
            pnl_fondo.BackgroundImage = (Image)resources.GetObject("pnl_fondo.BackgroundImage");
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
            pnl_fondo.Controls.Add(textBox7);
            pnl_fondo.Controls.Add(textBox6);
            pnl_fondo.Controls.Add(textBox5);
            pnl_fondo.Controls.Add(textBox4);
            pnl_fondo.Controls.Add(textBox3);
            pnl_fondo.Controls.Add(textBox2);
            pnl_fondo.Controls.Add(textBox1);
            pnl_fondo.Location = new Point(0, 0);
            pnl_fondo.Name = "pnl_fondo";
            pnl_fondo.Size = new Size(886, 537);
            pnl_fondo.TabIndex = 19;
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.Transparent;
            pnl_logo.BackgroundImage = (Image)resources.GetObject("pnl_logo.BackgroundImage");
            pnl_logo.Location = new Point(781, 12);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(93, 93);
            pnl_logo.TabIndex = 19;
            // 
            // form_Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 536);
            Controls.Add(pnl_fondo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "form_Registro";
            Text = "Registrarse";
            pnl_fondo.ResumeLayout(false);
            pnl_fondo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
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
    }
}