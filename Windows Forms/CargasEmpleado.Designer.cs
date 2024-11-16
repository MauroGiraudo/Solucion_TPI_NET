namespace Windows_Forms
{
    partial class form_cargasEmpleado
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
            dgv_cargas = new DataGridView();
            btn_detalleCarga = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_cargas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 0;
            label1.Text = "Mis Cargas";
            // 
            // dgv_cargas
            // 
            dgv_cargas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cargas.Location = new Point(85, 82);
            dgv_cargas.Name = "dgv_cargas";
            dgv_cargas.RowHeadersWidth = 51;
            dgv_cargas.Size = new Size(427, 392);
            dgv_cargas.TabIndex = 1;
            // 
            // btn_detalleCarga
            // 
            btn_detalleCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_detalleCarga.Location = new Point(139, 550);
            btn_detalleCarga.Name = "btn_detalleCarga";
            btn_detalleCarga.Size = new Size(133, 29);
            btn_detalleCarga.TabIndex = 2;
            btn_detalleCarga.Text = "Detalle de Carga";
            btn_detalleCarga.UseVisualStyleBackColor = true;
            btn_detalleCarga.Click += btn_detalleCarga_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(312, 550);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(133, 29);
            btn_salir.TabIndex = 3;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_cargasEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 600);
            Controls.Add(btn_salir);
            Controls.Add(btn_detalleCarga);
            Controls.Add(dgv_cargas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_cargasEmpleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Cargas";
            ((System.ComponentModel.ISupportInitialize)dgv_cargas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_cargas;
        private Button btn_detalleCarga;
        private Button btn_salir;
    }
}