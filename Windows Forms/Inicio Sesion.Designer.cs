namespace Windows_Forms
{
    partial class form_InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Usuario = new Label();
            txb_Usuario = new TextBox();
            txb_Contrasenia = new TextBox();
            btn_IniciarSesion = new Button();
            lbl_Contrasenia = new Label();
            lbl_Registro = new Label();
            lklb_Registro = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe UI", 15F);
            lbl_Usuario.Location = new Point(96, 48);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(83, 28);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "Usuario:";
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(96, 79);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(178, 23);
            txb_Usuario.TabIndex = 1;
            // 
            // txb_Contrasenia
            // 
            txb_Contrasenia.Location = new Point(96, 157);
            txb_Contrasenia.Name = "txb_Contrasenia";
            txb_Contrasenia.Size = new Size(178, 23);
            txb_Contrasenia.TabIndex = 2;
            // 
            // btn_IniciarSesion
            // 
            btn_IniciarSesion.Location = new Point(106, 212);
            btn_IniciarSesion.Name = "btn_IniciarSesion";
            btn_IniciarSesion.Size = new Size(158, 23);
            btn_IniciarSesion.TabIndex = 3;
            btn_IniciarSesion.Text = "Iniciar Sesion";
            btn_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.Font = new Font("Segoe UI", 15F);
            lbl_Contrasenia.Location = new Point(96, 126);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(114, 28);
            lbl_Contrasenia.TabIndex = 6;
            lbl_Contrasenia.Text = "Contraseña:";
            // 
            // lbl_Registro
            // 
            lbl_Registro.AutoSize = true;
            lbl_Registro.Location = new Point(58, 277);
            lbl_Registro.Name = "lbl_Registro";
            lbl_Registro.Size = new Size(121, 15);
            lbl_Registro.TabIndex = 7;
            lbl_Registro.Text = "¿No tiene un usuario?";
            // 
            // lklb_Registro
            // 
            lklb_Registro.AutoSize = true;
            lklb_Registro.Location = new Point(210, 277);
            lklb_Registro.Name = "lklb_Registro";
            lklb_Registro.Size = new Size(64, 15);
            lklb_Registro.TabIndex = 8;
            lklb_Registro.TabStop = true;
            lklb_Registro.Text = "Registrarse";
            // 
            // form_InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 318);
            Controls.Add(lklb_Registro);
            Controls.Add(lbl_Registro);
            Controls.Add(lbl_Contrasenia);
            Controls.Add(btn_IniciarSesion);
            Controls.Add(txb_Contrasenia);
            Controls.Add(txb_Usuario);
            Controls.Add(lbl_Usuario);
            Name = "form_InicioSesion";
            Text = "Inicio Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Usuario;
        private TextBox txb_Usuario;
        private TextBox txb_Contrasenia;
        private Button btn_IniciarSesion;
        private Label lbl_Contrasenia;
        private Label lbl_Registro;
        private LinkLabel lklb_Registro;
    }
}
