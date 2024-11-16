namespace Windows_Forms
{
    partial class form_altaPrenda
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
            txb_descripcion = new TextBox();
            nud_stock = new NumericUpDown();
            nud_puntoPedido = new NumericUpDown();
            cb_talla = new ComboBox();
            cb_tipoPrenda = new ComboBox();
            cb_marca = new ComboBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            lbl_descripcion = new Label();
            lbl_stock = new Label();
            lbl_puntoPedido = new Label();
            lbl_talla = new Label();
            lbl_tipoPrenda = new Label();
            lbl_marca = new Label();
            txb_precio = new TextBox();
            lbl_precio = new Label();
            lbl_idPrenda = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_puntoPedido).BeginInit();
            SuspendLayout();
            // 
            // txb_descripcion
            // 
            txb_descripcion.Location = new Point(53, 64);
            txb_descripcion.Name = "txb_descripcion";
            txb_descripcion.Size = new Size(196, 27);
            txb_descripcion.TabIndex = 0;
            // 
            // nud_stock
            // 
            nud_stock.Location = new Point(53, 175);
            nud_stock.Name = "nud_stock";
            nud_stock.Size = new Size(196, 27);
            nud_stock.TabIndex = 1;
            // 
            // nud_puntoPedido
            // 
            nud_puntoPedido.Location = new Point(53, 238);
            nud_puntoPedido.Name = "nud_puntoPedido";
            nud_puntoPedido.Size = new Size(196, 27);
            nud_puntoPedido.TabIndex = 2;
            // 
            // cb_talla
            // 
            cb_talla.FormattingEnabled = true;
            cb_talla.Location = new Point(385, 64);
            cb_talla.Name = "cb_talla";
            cb_talla.Size = new Size(196, 28);
            cb_talla.TabIndex = 3;
            // 
            // cb_tipoPrenda
            // 
            cb_tipoPrenda.FormattingEnabled = true;
            cb_tipoPrenda.Location = new Point(385, 149);
            cb_tipoPrenda.Name = "cb_tipoPrenda";
            cb_tipoPrenda.Size = new Size(196, 28);
            cb_tipoPrenda.TabIndex = 4;
            // 
            // cb_marca
            // 
            cb_marca.FormattingEnabled = true;
            cb_marca.Location = new Point(385, 237);
            cb_marca.Name = "cb_marca";
            cb_marca.Size = new Size(196, 28);
            cb_marca.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(206, 312);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 6;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cancelar.Location = new Point(336, 312);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Location = new Point(53, 35);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(152, 20);
            lbl_descripcion.TabIndex = 8;
            lbl_descripcion.Text = "Nombre de la prenda";
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Location = new Point(53, 149);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(45, 20);
            lbl_stock.TabIndex = 9;
            lbl_stock.Text = "Stock";
            // 
            // lbl_puntoPedido
            // 
            lbl_puntoPedido.AutoSize = true;
            lbl_puntoPedido.Location = new Point(53, 214);
            lbl_puntoPedido.Name = "lbl_puntoPedido";
            lbl_puntoPedido.Size = new Size(118, 20);
            lbl_puntoPedido.TabIndex = 10;
            lbl_puntoPedido.Text = "Punto de Pedido";
            // 
            // lbl_talla
            // 
            lbl_talla.AutoSize = true;
            lbl_talla.Location = new Point(385, 35);
            lbl_talla.Name = "lbl_talla";
            lbl_talla.Size = new Size(39, 20);
            lbl_talla.TabIndex = 11;
            lbl_talla.Text = "Talla";
            // 
            // lbl_tipoPrenda
            // 
            lbl_tipoPrenda.AutoSize = true;
            lbl_tipoPrenda.Location = new Point(385, 120);
            lbl_tipoPrenda.Name = "lbl_tipoPrenda";
            lbl_tipoPrenda.Size = new Size(110, 20);
            lbl_tipoPrenda.TabIndex = 12;
            lbl_tipoPrenda.Text = "Tipo de Prenda";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(385, 205);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(50, 20);
            lbl_marca.TabIndex = 13;
            lbl_marca.Text = "Marca";
            // 
            // txb_precio
            // 
            txb_precio.Location = new Point(53, 117);
            txb_precio.Name = "txb_precio";
            txb_precio.Size = new Size(196, 27);
            txb_precio.TabIndex = 14;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(53, 94);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(50, 20);
            lbl_precio.TabIndex = 15;
            lbl_precio.Text = "Precio";
            // 
            // lbl_idPrenda
            // 
            lbl_idPrenda.AutoSize = true;
            lbl_idPrenda.Location = new Point(25, 310);
            lbl_idPrenda.Name = "lbl_idPrenda";
            lbl_idPrenda.Size = new Size(68, 20);
            lbl_idPrenda.TabIndex = 16;
            lbl_idPrenda.Text = "IdPrenda";
            lbl_idPrenda.Visible = false;
            // 
            // form_altaPrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 363);
            Controls.Add(lbl_idPrenda);
            Controls.Add(lbl_precio);
            Controls.Add(txb_precio);
            Controls.Add(lbl_marca);
            Controls.Add(lbl_tipoPrenda);
            Controls.Add(lbl_talla);
            Controls.Add(lbl_puntoPedido);
            Controls.Add(lbl_stock);
            Controls.Add(lbl_descripcion);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(cb_marca);
            Controls.Add(cb_tipoPrenda);
            Controls.Add(cb_talla);
            Controls.Add(nud_puntoPedido);
            Controls.Add(nud_stock);
            Controls.Add(txb_descripcion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_altaPrenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alta Prenda";
            ((System.ComponentModel.ISupportInitialize)nud_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_puntoPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_descripcion;
        private NumericUpDown nud_stock;
        private NumericUpDown nud_puntoPedido;
        private ComboBox cb_talla;
        private ComboBox cb_tipoPrenda;
        private ComboBox cb_marca;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_descripcion;
        private Label lbl_stock;
        private Label lbl_puntoPedido;
        private Label lbl_talla;
        private Label lbl_tipoPrenda;
        private Label lbl_marca;
        private TextBox txb_precio;
        private Label lbl_precio;
        private Label lbl_idPrenda;
    }
}