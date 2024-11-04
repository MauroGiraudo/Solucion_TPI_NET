namespace Windows_Forms
{
    partial class FrmAgregarStock
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
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            tipoPrenda = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, marca, tipoPrenda, descripcion, stock });
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 228);
            dataGridView1.TabIndex = 0;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "Id";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Width = 30;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.ReadOnly = true;
            // 
            // tipoPrenda
            // 
            tipoPrenda.HeaderText = "Tipo";
            tipoPrenda.Name = "tipoPrenda";
            tipoPrenda.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Cantidad";
            stock.Name = "stock";
            // 
            // FrmAgregarStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FrmAgregarStock";
            Text = "FrmAgregarStock";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn tipoPrenda;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn stock;
    }
}