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
            lbl_idOperacion = new Label();
            lbl_fecha = new Label();
            lbl_estado = new Label();
            txb_idOperacion = new TextBox();
            txb_estado = new TextBox();
            dtp_fecha = new DateTimePicker();
            dgv_compra = new DataGridView();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_compra).BeginInit();
            SuspendLayout();
            // 
            // lbl_idOperacion
            // 
            lbl_idOperacion.AutoSize = true;
            lbl_idOperacion.Location = new Point(84, 21);
            lbl_idOperacion.Name = "lbl_idOperacion";
            lbl_idOperacion.Size = new Size(91, 20);
            lbl_idOperacion.TabIndex = 0;
            lbl_idOperacion.Text = "IdOperacion";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(367, 21);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(47, 20);
            lbl_fecha.TabIndex = 1;
            lbl_fecha.Text = "Fecha";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Location = new Point(626, 21);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(54, 20);
            lbl_estado.TabIndex = 2;
            lbl_estado.Text = "Estado";
            // 
            // txb_idOperacion
            // 
            txb_idOperacion.Location = new Point(45, 57);
            txb_idOperacion.Name = "txb_idOperacion";
            txb_idOperacion.Size = new Size(168, 27);
            txb_idOperacion.TabIndex = 3;
            // 
            // txb_estado
            // 
            txb_estado.Location = new Point(569, 57);
            txb_estado.Name = "txb_estado";
            txb_estado.Size = new Size(168, 27);
            txb_estado.TabIndex = 5;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Location = new Point(308, 57);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(168, 27);
            dtp_fecha.TabIndex = 4;
            // 
            // dgv_compra
            // 
            dgv_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compra.Location = new Point(45, 123);
            dgv_compra.Name = "dgv_compra";
            dgv_compra.RowHeadersWidth = 51;
            dgv_compra.Size = new Size(692, 258);
            dgv_compra.TabIndex = 6;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(340, 410);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_detalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
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
    }
}