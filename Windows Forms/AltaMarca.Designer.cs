namespace Windows_Forms
{
    partial class form_altaMarca
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
            lbl_descripcion.Location = new Point(83, 35);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(218, 20);
            lbl_descripcion.TabIndex = 0;
            lbl_descripcion.Text = "Ingrese el nombre de la marca: ";
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(83, 78);
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(271, 27);
            txb_descripcion.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(114, 161);
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
            btn_cancelar.Location = new Point(228, 161);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += this.btn_cancelar_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(330, 20);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(81, 20);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "NoContent";
            lbl_id.Visible = false;
            // 
            // form_altaMarca
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
            Name = "form_altaMarca";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Marca";
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