namespace Windows_Forms
{
    partial class form_carrito
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
            dgv_carrito = new DataGridView();
            btn_delete = new Button();
            btn_salir = new Button();
            btn_purchase = new Button();
            label2 = new Label();
            txb_total = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(229, 20);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 0;
            label1.Text = "Carrito de Compras";
            // 
            // dgv_carrito
            // 
            dgv_carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_carrito.Location = new Point(90, 78);
            dgv_carrito.Name = "dgv_carrito";
            dgv_carrito.RowHeadersWidth = 51;
            dgv_carrito.Size = new Size(554, 503);
            dgv_carrito.TabIndex = 1;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(301, 639);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 51);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Quitar Prenda del Carrito";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(541, 661);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(94, 29);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_purchase
            // 
            btn_purchase.Location = new Point(90, 661);
            btn_purchase.Name = "btn_purchase";
            btn_purchase.Size = new Size(94, 29);
            btn_purchase.TabIndex = 3;
            btn_purchase.Text = "Comprar";
            btn_purchase.UseVisualStyleBackColor = true;
            btn_purchase.Click += btn_purchase_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(449, 593);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // txb_total
            // 
            txb_total.Location = new Point(519, 594);
            txb_total.Name = "txb_total";
            txb_total.Size = new Size(125, 27);
            txb_total.TabIndex = 6;
            // 
            // form_carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 721);
            Controls.Add(txb_total);
            Controls.Add(label2);
            Controls.Add(btn_purchase);
            Controls.Add(btn_salir);
            Controls.Add(btn_delete);
            Controls.Add(dgv_carrito);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_carrito";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_carrito;
        private Button btn_delete;
        private Button btn_salir;
        private Button btn_purchase;
        private Label label2;
        private TextBox txb_total;
    }
}