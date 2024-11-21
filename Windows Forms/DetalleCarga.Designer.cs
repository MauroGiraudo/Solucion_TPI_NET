namespace Windows_Forms
{
    partial class form_detalleCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_detalleCarga));
            txb_idOperacion = new TextBox();
            dtp_fecha = new DateTimePicker();
            txb_estado = new TextBox();
            dgv_lineasDeCarga = new DataGridView();
            btn_salir = new Button();
            lbl_idOperacion = new Label();
            lbl_fecha = new Label();
            lbl_estado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_lineasDeCarga).BeginInit();
            SuspendLayout();
            // 
            // txb_idOperacion
            // 
            txb_idOperacion.Enabled = false;
            txb_idOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_idOperacion.Location = new Point(50, 59);
            txb_idOperacion.Name = "txb_idOperacion";
            txb_idOperacion.Size = new Size(116, 27);
            txb_idOperacion.TabIndex = 0;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Enabled = false;
            dtp_fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_fecha.Location = new Point(250, 59);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(282, 27);
            dtp_fecha.TabIndex = 1;
            // 
            // txb_estado
            // 
            txb_estado.Enabled = false;
            txb_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_estado.Location = new Point(614, 59);
            txb_estado.Name = "txb_estado";
            txb_estado.Size = new Size(136, 27);
            txb_estado.TabIndex = 2;
            // 
            // dgv_lineasDeCarga
            // 
            dgv_lineasDeCarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lineasDeCarga.Location = new Point(118, 128);
            dgv_lineasDeCarga.Name = "dgv_lineasDeCarga";
            dgv_lineasDeCarga.RowHeadersWidth = 51;
            dgv_lineasDeCarga.Size = new Size(553, 258);
            dgv_lineasDeCarga.TabIndex = 3;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(328, 440);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(128, 29);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // lbl_idOperacion
            // 
            lbl_idOperacion.AutoSize = true;
            lbl_idOperacion.BackColor = Color.Transparent;
            lbl_idOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_idOperacion.Location = new Point(50, 24);
            lbl_idOperacion.Name = "lbl_idOperacion";
            lbl_idOperacion.Size = new Size(119, 20);
            lbl_idOperacion.TabIndex = 5;
            lbl_idOperacion.Text = "Id de Operacion";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.BackColor = Color.Transparent;
            lbl_fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_fecha.Location = new Point(360, 24);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(49, 20);
            lbl_fecha.TabIndex = 6;
            lbl_fecha.Text = "Fecha";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.Transparent;
            lbl_estado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_estado.Location = new Point(653, 24);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(56, 20);
            lbl_estado.TabIndex = 7;
            lbl_estado.Text = "Estado";
            // 
            // form_detalleCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 492);
            Controls.Add(lbl_estado);
            Controls.Add(lbl_fecha);
            Controls.Add(lbl_idOperacion);
            Controls.Add(btn_salir);
            Controls.Add(dgv_lineasDeCarga);
            Controls.Add(txb_estado);
            Controls.Add(dtp_fecha);
            Controls.Add(txb_idOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_detalleCarga";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle de la Carga";
            ((System.ComponentModel.ISupportInitialize)dgv_lineasDeCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_idOperacion;
        private DateTimePicker dtp_fecha;
        private TextBox txb_estado;
        private DataGridView dgv_lineasDeCarga;
        private Button btn_salir;
        private Label lbl_idOperacion;
        private Label lbl_fecha;
        private Label lbl_estado;
    }
}