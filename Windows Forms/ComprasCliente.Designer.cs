namespace Windows_Forms
{
    partial class form_comprasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_comprasCliente));
            label1 = new Label();
            dgv_compras = new DataGridView();
            btn_compra = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_compras).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(219, -2);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 0;
            label1.Text = "Mis Compras";
            // 
            // dgv_compras
            // 
            dgv_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compras.Location = new Point(84, 66);
            dgv_compras.Name = "dgv_compras";
            dgv_compras.RowHeadersWidth = 51;
            dgv_compras.Size = new Size(427, 392);
            dgv_compras.TabIndex = 1;
            // 
            // btn_compra
            // 
            btn_compra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_compra.Location = new Point(84, 521);
            btn_compra.Name = "btn_compra";
            btn_compra.Size = new Size(103, 29);
            btn_compra.TabIndex = 2;
            btn_compra.Text = "Ver Compra";
            btn_compra.UseVisualStyleBackColor = true;
            btn_compra.Click += btn_compra_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(417, 521);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 3;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_comprasCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(603, 600);
            Controls.Add(btn_salir);
            Controls.Add(btn_compra);
            Controls.Add(dgv_compras);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_comprasCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Compras";
            ((System.ComponentModel.ISupportInitialize)dgv_compras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_compras;
        private Button btn_compra;
        private Button btn_salir;
    }
}