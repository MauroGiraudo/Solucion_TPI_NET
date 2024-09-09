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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(455, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(455, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(455, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(219, 23);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(455, 230);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(219, 23);
            textBox7.TabIndex = 6;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(94, 65);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(113, 15);
            lbl_Usuario.TabIndex = 8;
            lbl_Usuario.Text = "Nombre de Usuario:";
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.Location = new Point(94, 141);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(67, 15);
            lbl_Contrasenia.TabIndex = 9;
            lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_ConfContrasenia
            // 
            lbl_ConfContrasenia.AutoSize = true;
            lbl_ConfContrasenia.Location = new Point(94, 221);
            lbl_ConfContrasenia.Name = "lbl_ConfContrasenia";
            lbl_ConfContrasenia.Size = new Size(127, 15);
            lbl_ConfContrasenia.TabIndex = 10;
            lbl_ConfContrasenia.Text = "Confirmar Contraseña:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(455, 120);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(64, 15);
            lbl_Nombre.TabIndex = 11;
            lbl_Nombre.Text = "Nombre/s:";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(455, 65);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(64, 15);
            lbl_Apellido.TabIndex = 12;
            lbl_Apellido.Text = "Apellido/s:";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(455, 168);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(39, 15);
            lbl_Email.TabIndex = 13;
            lbl_Email.Text = "Email:";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(455, 212);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(55, 15);
            lbl_Telefono.TabIndex = 14;
            lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_FechaNacimiento
            // 
            lbl_FechaNacimiento.AutoSize = true;
            lbl_FechaNacimiento.Location = new Point(455, 256);
            lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            lbl_FechaNacimiento.Size = new Size(106, 15);
            lbl_FechaNacimiento.TabIndex = 15;
            lbl_FechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Location = new Point(455, 274);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(219, 23);
            dtp_FechaNacimiento.TabIndex = 16;
            dtp_FechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.MediumSeaGreen;
            btn_Aceptar.Font = new Font("Segoe UI", 11F);
            btn_Aceptar.Location = new Point(222, 360);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(91, 28);
            btn_Aceptar.TabIndex = 17;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.IndianRed;
            btn_Cancelar.Font = new Font("Segoe UI", 11F);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.Location = new Point(437, 360);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(91, 28);
            btn_Cancelar.TabIndex = 18;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // form_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 402);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(lbl_FechaNacimiento);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_ConfContrasenia);
            Controls.Add(lbl_Contrasenia);
            Controls.Add(lbl_Usuario);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "form_Registro";
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
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
    }
}