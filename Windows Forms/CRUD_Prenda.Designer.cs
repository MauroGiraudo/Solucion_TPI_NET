namespace Windows_Forms
{
    partial class form_CRUD_prenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CRUD_prenda));
            txb_buscar = new TextBox();
            btn_buscar = new Button();
            dgv_prendas = new DataGridView();
            btn_alta = new Button();
            btn_cargaStock = new Button();
            btn_cargaPrecio = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_prendas).BeginInit();
            SuspendLayout();
            // 
            // txb_buscar
            // 
            txb_buscar.Location = new Point(276, 27);
            txb_buscar.Name = "txb_buscar";
            txb_buscar.Size = new Size(306, 27);
            txb_buscar.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_buscar.Location = new Point(618, 27);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 27);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dgv_prendas
            // 
            dgv_prendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prendas.Location = new Point(40, 75);
            dgv_prendas.Name = "dgv_prendas";
            dgv_prendas.RowHeadersWidth = 51;
            dgv_prendas.Size = new Size(929, 395);
            dgv_prendas.TabIndex = 2;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_alta.Location = new Point(1022, 117);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(141, 29);
            btn_alta.TabIndex = 3;
            btn_alta.Text = "Nueva Prenda";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // btn_cargaStock
            // 
            btn_cargaStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cargaStock.Location = new Point(1022, 183);
            btn_cargaStock.Name = "btn_cargaStock";
            btn_cargaStock.Size = new Size(141, 29);
            btn_cargaStock.TabIndex = 4;
            btn_cargaStock.Text = "Cargar Stock";
            btn_cargaStock.UseVisualStyleBackColor = true;
            btn_cargaStock.Click += btn_cargaStock_Click;
            // 
            // btn_cargaPrecio
            // 
            btn_cargaPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cargaPrecio.Location = new Point(1022, 254);
            btn_cargaPrecio.Name = "btn_cargaPrecio";
            btn_cargaPrecio.Size = new Size(141, 29);
            btn_cargaPrecio.TabIndex = 5;
            btn_cargaPrecio.Text = "Nuevo Precio";
            btn_cargaPrecio.UseVisualStyleBackColor = true;
            btn_cargaPrecio.Click += btn_cargaPrecio_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_modificar.Location = new Point(1022, 321);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(141, 29);
            btn_modificar.TabIndex = 6;
            btn_modificar.Text = "Modificar Prenda";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_eliminar.Location = new Point(1022, 385);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(141, 29);
            btn_eliminar.TabIndex = 7;
            btn_eliminar.Text = "Eliminar Prenda";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(543, 510);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(141, 29);
            btn_salir.TabIndex = 8;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_CRUD_prenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1198, 578);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_cargaPrecio);
            Controls.Add(btn_cargaStock);
            Controls.Add(btn_alta);
            Controls.Add(dgv_prendas);
            Controls.Add(btn_buscar);
            Controls.Add(txb_buscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_CRUD_prenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Operaciones Prenda";
            ((System.ComponentModel.ISupportInitialize)dgv_prendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_buscar;
        private Button btn_buscar;
        private DataGridView dgv_prendas;
        private Button btn_alta;
        private Button btn_cargaStock;
        private Button btn_cargaPrecio;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_salir;
    }
}