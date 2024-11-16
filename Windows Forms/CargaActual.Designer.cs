namespace Windows_Forms
{
    partial class form_cargaActual
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
            label1 = new Label();
            dgv_miCarga = new DataGridView();
            btn_cargar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_miCarga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 0;
            label1.Text = "Carga Actual";
            // 
            // dgv_miCarga
            // 
            dgv_miCarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_miCarga.Location = new Point(84, 77);
            dgv_miCarga.Name = "dgv_miCarga";
            dgv_miCarga.RowHeadersWidth = 51;
            dgv_miCarga.Size = new Size(427, 336);
            dgv_miCarga.TabIndex = 1;
            // 
            // btn_cargar
            // 
            btn_cargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cargar.Location = new Point(84, 476);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(94, 29);
            btn_cargar.TabIndex = 2;
            btn_cargar.Text = "Cargar";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_eliminar.Location = new Point(243, 452);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(116, 53);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Quitar Prenda de la Carga";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(417, 476);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_cargaActual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 532);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_cargar);
            Controls.Add(dgv_miCarga);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_cargaActual";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carga Actual";
            ((System.ComponentModel.ISupportInitialize)dgv_miCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_miCarga;
        private Button btn_cargar;
        private Button btn_eliminar;
        private Button btn_salir;
    }
}