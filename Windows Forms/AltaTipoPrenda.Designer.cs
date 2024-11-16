namespace Windows_Forms
{
    partial class form_altaTipoDePrenda
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
            lbl_descripcion = new Label();
            txb_descripcion = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            lbl_id = new Label();
            SuspendLayout();
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Font = new Font("Segoe UI", 9F);
            lbl_descripcion.Location = new Point(84, 30);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(183, 20);
            lbl_descripcion.TabIndex = 0;
            lbl_descripcion.Text = "Ingrese el tipo de prenda: ";
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(84, 83);
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(257, 27);
            txb_descripcion.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(106, 161);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cancelar.Location = new Point(224, 161);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(336, 9);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(81, 20);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "NoContent";
            lbl_id.Visible = false;
            // 
            // form_altaTipoDePrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 211);
            Controls.Add(lbl_id);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txb_descripcion);
            Controls.Add(lbl_descripcion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_altaTipoDePrenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Tipo de Prenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_descripcion;
        private TextBox txb_descripcion;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_id;
    }
}