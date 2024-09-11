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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_InicioSesion));
            lbl_Usuario = new Label();
            txb_Usuario = new TextBox();
            txb_Contrasenia = new TextBox();
            btn_IniciarSesion = new Button();
            lbl_Contrasenia = new Label();
            lbl_Registro = new Label();
            lklb_Registro = new LinkLabel();
            pnl_fondo = new Panel();
            pnl_logo = new Panel();
            pnl_fondo.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.BackColor = Color.Transparent;
            lbl_Usuario.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(132, 52);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(119, 35);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "Usuario:";
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(132, 91);
            txb_Usuario.Margin = new Padding(3, 4, 3, 4);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(203, 27);
            txb_Usuario.TabIndex = 1;
            // 
            // txb_Contrasenia
            // 
            txb_Contrasenia.Location = new Point(132, 195);
            txb_Contrasenia.Margin = new Padding(3, 4, 3, 4);
            txb_Contrasenia.Name = "txb_Contrasenia";
            txb_Contrasenia.Size = new Size(203, 27);
            txb_Contrasenia.TabIndex = 2;
            // 
            // btn_IniciarSesion
            // 
            btn_IniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_IniciarSesion.Location = new Point(144, 271);
            btn_IniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btn_IniciarSesion.Name = "btn_IniciarSesion";
            btn_IniciarSesion.Size = new Size(181, 31);
            btn_IniciarSesion.TabIndex = 3;
            btn_IniciarSesion.Text = "Iniciar Sesion";
            btn_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.BackColor = Color.Transparent;
            lbl_Contrasenia.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Contrasenia.Location = new Point(132, 156);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(162, 35);
            lbl_Contrasenia.TabIndex = 6;
            lbl_Contrasenia.Text = "Contraseña:";
            // 
            // lbl_Registro
            // 
            lbl_Registro.AutoSize = true;
            lbl_Registro.BackColor = Color.Transparent;
            lbl_Registro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Registro.Location = new Point(99, 348);
            lbl_Registro.Name = "lbl_Registro";
            lbl_Registro.Size = new Size(161, 20);
            lbl_Registro.TabIndex = 7;
            lbl_Registro.Text = "¿No tiene un usuario?";
            // 
            // lklb_Registro
            // 
            lklb_Registro.AutoSize = true;
            lklb_Registro.BackColor = Color.Transparent;
            lklb_Registro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklb_Registro.Location = new Point(277, 348);
            lklb_Registro.Name = "lklb_Registro";
            lklb_Registro.Size = new Size(82, 20);
            lklb_Registro.TabIndex = 8;
            lklb_Registro.TabStop = true;
            lklb_Registro.Text = "Registrarse";
            // 
            // pnl_fondo
            // 
            pnl_fondo.BackgroundImage = (Image)resources.GetObject("pnl_fondo.BackgroundImage");
            pnl_fondo.Controls.Add(pnl_logo);
            pnl_fondo.Controls.Add(lklb_Registro);
            pnl_fondo.Controls.Add(lbl_Registro);
            pnl_fondo.Controls.Add(lbl_Contrasenia);
            pnl_fondo.Controls.Add(btn_IniciarSesion);
            pnl_fondo.Controls.Add(txb_Contrasenia);
            pnl_fondo.Controls.Add(txb_Usuario);
            pnl_fondo.Controls.Add(lbl_Usuario);
            pnl_fondo.Location = new Point(-7, -1);
            pnl_fondo.Name = "pnl_fondo";
            pnl_fondo.Size = new Size(495, 489);
            pnl_fondo.TabIndex = 9;
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.Transparent;
            pnl_logo.BackgroundImage = (Image)resources.GetObject("pnl_logo.BackgroundImage");
            pnl_logo.Location = new Point(19, 13);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(93, 93);
            pnl_logo.TabIndex = 9;
            pnl_logo.Paint += panel2_Paint;
            // 
            // form_InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 481);
            Controls.Add(pnl_fondo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "form_InicioSesion";
            Text = "Inicio Sesion";
            pnl_fondo.ResumeLayout(false);
            pnl_fondo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Usuario;
        private TextBox txb_Usuario;
        private TextBox txb_Contrasenia;
        private Button btn_IniciarSesion;
        private Label lbl_Contrasenia;
        private Label lbl_Registro;
        private LinkLabel lklb_Registro;
        private Panel pnl_fondo;
        private Panel pnl_logo;
    }
}
