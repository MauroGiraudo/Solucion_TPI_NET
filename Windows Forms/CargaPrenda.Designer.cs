namespace Windows_Forms
{
    partial class form_cargaPrenda
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
            lbl_stock = new Label();
            txb_stock = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            lbl_idPrenda = new Label();
            SuspendLayout();
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Location = new Point(118, 35);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(198, 20);
            lbl_stock.TabIndex = 0;
            lbl_stock.Text = "Stock a cargar de la prenda: ";
            // 
            // txb_stock
            // 
            txb_stock.Location = new Point(86, 70);
            txb_stock.Name = "txb_stock";
            txb_stock.Size = new Size(258, 27);
            txb_stock.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(109, 157);
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
            btn_cancelar.Location = new Point(222, 157);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_idPrenda
            // 
            lbl_idPrenda.AutoSize = true;
            lbl_idPrenda.Location = new Point(13, 108);
            lbl_idPrenda.Name = "lbl_idPrenda";
            lbl_idPrenda.Size = new Size(68, 20);
            lbl_idPrenda.TabIndex = 4;
            lbl_idPrenda.Text = "IdPrenda";
            lbl_idPrenda.Visible = false;
            // 
            // form_cargaPrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 211);
            Controls.Add(lbl_idPrenda);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txb_stock);
            Controls.Add(lbl_stock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_cargaPrenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carga de Prenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_stock;
        private TextBox txb_stock;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_idPrenda;
    }
}