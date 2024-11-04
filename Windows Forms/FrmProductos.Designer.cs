namespace Windows_Forms
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgv_productos = new DataGridView();
            idPrenda = new DataGridViewTextBoxColumn();
            tipoPrenda = new DataGridViewComboBoxColumn();
            modelo = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            puntoPedido = new DataGridViewTextBoxColumn();
            borrar = new DataGridViewButtonColumn();
            agregarStock = new DataGridViewCheckBoxColumn();
            btn_agregarStock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { idPrenda, tipoPrenda, modelo, descripcion, marca, stock, puntoPedido, borrar, agregarStock });
            dgv_productos.Location = new Point(0, 0);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.Size = new Size(800, 417);
            dgv_productos.TabIndex = 0;
            dgv_productos.CellContentClick += dgv_productos_CellContentClick;
            // 
            // idPrenda
            // 
            idPrenda.HeaderText = "Id";
            idPrenda.Name = "idPrenda";
            idPrenda.ReadOnly = true;
            idPrenda.Width = 30;
            // 
            // tipoPrenda
            // 
            tipoPrenda.HeaderText = "Tipo";
            tipoPrenda.Name = "tipoPrenda";
            tipoPrenda.Resizable = DataGridViewTriState.True;
            tipoPrenda.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // modelo
            // 
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            // 
            // stock
            // 
            stock.FillWeight = 50F;
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 40;
            // 
            // puntoPedido
            // 
            puntoPedido.HeaderText = "Punto Pedido";
            puntoPedido.Name = "puntoPedido";
            puntoPedido.Width = 50;
            // 
            // borrar
            // 
            borrar.HeaderText = "";
            borrar.Name = "borrar";
            borrar.ReadOnly = true;
            borrar.Text = "Borrar";
            borrar.ToolTipText = "Borrar";
            borrar.UseColumnTextForButtonValue = true;
            borrar.Width = 60;
            // 
            // agregarStock
            // 
            agregarStock.HeaderText = "";
            agregarStock.Name = "agregarStock";
            agregarStock.Resizable = DataGridViewTriState.True;
            agregarStock.Width = 60;
            // 
            // btn_agregarStock
            // 
            btn_agregarStock.BackColor = Color.Lime;
            btn_agregarStock.ForeColor = Color.Black;
            btn_agregarStock.Location = new Point(394, 90);
            btn_agregarStock.Name = "btn_agregarStock";
            btn_agregarStock.Size = new Size(76, 23);
            btn_agregarStock.TabIndex = 1;
            btn_agregarStock.Text = "Agregar Stock";
            btn_agregarStock.UseVisualStyleBackColor = false;
            btn_agregarStock.Click += btn_agregarStock_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregarStock);
            Controls.Add(dgv_productos);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgv_productos;
        private DataGridViewTextBoxColumn idPrenda;
        private DataGridViewComboBoxColumn tipoPrenda;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn puntoPedido;
        private DataGridViewButtonColumn borrar;
        private DataGridViewCheckBoxColumn agregarStock;
        private Button btn_agregarStock;
    }

}