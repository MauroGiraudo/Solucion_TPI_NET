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
            textBox1 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(401, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(773, 27);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 27);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_prendas
            // 
            dgv_prendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_prendas.Location = new Point(40, 78);
            dgv_prendas.Name = "dgv_prendas";
            dgv_prendas.RowHeadersWidth = 51;
            dgv_prendas.Size = new Size(1190, 395);
            dgv_prendas.TabIndex = 2;
            // 
            // btn_alta
            // 
            btn_alta.Location = new Point(40, 522);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(141, 29);
            btn_alta.TabIndex = 3;
            btn_alta.Text = "Nueva Prenda";
            btn_alta.UseVisualStyleBackColor = true;
            // 
            // btn_cargaStock
            // 
            btn_cargaStock.Location = new Point(251, 522);
            btn_cargaStock.Name = "btn_cargaStock";
            btn_cargaStock.Size = new Size(141, 29);
            btn_cargaStock.TabIndex = 4;
            btn_cargaStock.Text = "Cargar Stock";
            btn_cargaStock.UseVisualStyleBackColor = true;
            // 
            // btn_cargaPrecio
            // 
            btn_cargaPrecio.Location = new Point(464, 522);
            btn_cargaPrecio.Name = "btn_cargaPrecio";
            btn_cargaPrecio.Size = new Size(141, 29);
            btn_cargaPrecio.TabIndex = 5;
            btn_cargaPrecio.Text = "Nuevo Precio";
            btn_cargaPrecio.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(681, 522);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(141, 29);
            btn_modificar.TabIndex = 6;
            btn_modificar.Text = "Modificar Prenda";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(888, 522);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(141, 29);
            btn_eliminar.TabIndex = 7;
            btn_eliminar.Text = "Eliminar Prenda";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(1089, 522);
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
            ClientSize = new Size(1272, 578);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_cargaPrecio);
            Controls.Add(btn_cargaStock);
            Controls.Add(btn_alta);
            Controls.Add(dgv_prendas);
            Controls.Add(btn_buscar);
            Controls.Add(textBox1);
            Name = "form_CRUD_prenda";
            Text = "Operaciones Prenda";
            ((System.ComponentModel.ISupportInitialize)dgv_prendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
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