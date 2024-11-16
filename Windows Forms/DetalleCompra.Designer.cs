namespace Windows_Forms
{
    partial class form_detalleCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_detalleCompra));
            lbl_idOperacion = new Label();
            lbl_fecha = new Label();
            lbl_estado = new Label();
            txb_idOperacion = new TextBox();
            txb_estado = new TextBox();
            dtp_fecha = new DateTimePicker();
            dgv_compra = new DataGridView();
            btn_salir = new Button();
            lbl_total = new Label();
            txb_total = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_compra).BeginInit();
            SuspendLayout();
            // 
            // lbl_idOperacion
            // 
            lbl_idOperacion.AutoSize = true;
            lbl_idOperacion.BackColor = Color.Transparent;
            lbl_idOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_idOperacion.ForeColor = SystemColors.ButtonHighlight;
            lbl_idOperacion.Location = new Point(68, 21);
            lbl_idOperacion.Name = "lbl_idOperacion";
            lbl_idOperacion.Size = new Size(94, 20);
            lbl_idOperacion.TabIndex = 0;
            lbl_idOperacion.Text = "IdOperacion";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.BackColor = Color.Transparent;
            lbl_fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_fecha.ForeColor = SystemColors.ButtonHighlight;
            lbl_fecha.Location = new Point(358, 21);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(49, 20);
            lbl_fecha.TabIndex = 1;
            lbl_fecha.Text = "Fecha";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.Transparent;
            lbl_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_estado.ForeColor = SystemColors.ButtonHighlight;
            lbl_estado.Location = new Point(635, 21);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(56, 20);
            lbl_estado.TabIndex = 2;
            lbl_estado.Text = "Estado";
            // 
            // txb_idOperacion
            // 
            txb_idOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_idOperacion.Location = new Point(45, 57);
            txb_idOperacion.Name = "txb_idOperacion";
            txb_idOperacion.Size = new Size(135, 27);
            txb_idOperacion.TabIndex = 3;
            // 
            // txb_estado
            // 
            txb_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_estado.Location = new Point(594, 57);
            txb_estado.Name = "txb_estado";
            txb_estado.Size = new Size(143, 27);
            txb_estado.TabIndex = 5;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_fecha.Location = new Point(242, 55);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(284, 27);
            dtp_fecha.TabIndex = 4;
            // 
            // dgv_compra
            // 
            dgv_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compra.Location = new Point(126, 121);
            dgv_compra.Name = "dgv_compra";
            dgv_compra.RowHeadersWidth = 51;
            dgv_compra.Size = new Size(553, 258);
            dgv_compra.TabIndex = 6;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(358, 451);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.BackColor = Color.Transparent;
            lbl_total.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_total.ForeColor = SystemColors.ButtonHighlight;
            lbl_total.Location = new Point(505, 397);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(60, 25);
            lbl_total.TabIndex = 8;
            lbl_total.Text = "Total:";
            // 
            // txb_total
            // 
            txb_total.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_total.Location = new Point(567, 398);
            txb_total.Name = "txb_total";
            txb_total.Size = new Size(112, 27);
            txb_total.TabIndex = 9;
            // 
            // form_detalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 492);
            Controls.Add(txb_total);
            Controls.Add(lbl_total);
            Controls.Add(btn_salir);
            Controls.Add(dgv_compra);
            Controls.Add(dtp_fecha);
            Controls.Add(txb_estado);
            Controls.Add(txb_idOperacion);
            Controls.Add(lbl_estado);
            Controls.Add(lbl_fecha);
            Controls.Add(lbl_idOperacion);
            Name = "form_detalleCompra";
            Text = "Detalle de Compra";
            ((System.ComponentModel.ISupportInitialize)dgv_compra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_idOperacion;
        private Label lbl_fecha;
        private Label lbl_estado;
        private TextBox txb_idOperacion;
        private TextBox txb_estado;
        private DateTimePicker dtp_fecha;
        private DataGridView dgv_compra;
        private Button btn_salir;
        private Label lbl_total;
        private TextBox txb_total;
    }
}