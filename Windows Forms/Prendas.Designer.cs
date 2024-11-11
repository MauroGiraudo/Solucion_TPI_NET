namespace Windows_Forms
{
    partial class form_Prendas
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
            dgv_prendas = new DataGridView();
            txb_buscar = new TextBox();
            btn_buscar = new Button();
            btn_agregar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_prendas).BeginInit();
            SuspendLayout();
            // 
            // dgv_prendas
            // 
            dgv_prendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prendas.Location = new Point(178, 77);
            dgv_prendas.Name = "dgv_prendas";
            dgv_prendas.RowHeadersWidth = 51;
            dgv_prendas.Size = new Size(919, 403);
            dgv_prendas.TabIndex = 0;
            // 
            // txb_buscar
            // 
            txb_buscar.Location = new Point(409, 24);
            txb_buscar.Name = "txb_buscar";
            txb_buscar.Size = new Size(333, 27);
            txb_buscar.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(769, 24);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 27);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(252, 512);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(138, 29);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "Agregar al Carrito";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(914, 512);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_Prendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 578);
            Controls.Add(btn_salir);
            Controls.Add(btn_agregar);
            Controls.Add(btn_buscar);
            Controls.Add(txb_buscar);
            Controls.Add(dgv_prendas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_Prendas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Prendas";
            ((System.ComponentModel.ISupportInitialize)dgv_prendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_prendas;
        private TextBox txb_buscar;
        private Button btn_buscar;
        private Button btn_agregar;
        private Button btn_salir;
    }
}