namespace Windows_Forms
{
    partial class form_CRUD_tipoDePrenda
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
            txb_buscar = new TextBox();
            btn_buscar = new Button();
            dgv_tiposDePrenda = new DataGridView();
            btn_alta = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tiposDePrenda).BeginInit();
            SuspendLayout();
            // 
            // txb_buscar
            // 
            txb_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_buscar.Location = new Point(34, 29);
            txb_buscar.Name = "txb_buscar";
            txb_buscar.Size = new Size(189, 27);
            txb_buscar.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_buscar.Location = new Point(243, 28);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dgv_tiposDePrenda
            // 
            dgv_tiposDePrenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tiposDePrenda.Location = new Point(34, 83);
            dgv_tiposDePrenda.Name = "dgv_tiposDePrenda";
            dgv_tiposDePrenda.RowHeadersWidth = 51;
            dgv_tiposDePrenda.Size = new Size(303, 211);
            dgv_tiposDePrenda.TabIndex = 6;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_alta.Location = new Point(374, 121);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(177, 29);
            btn_alta.TabIndex = 2;
            btn_alta.Text = "Nuevo Tipo de Prenda";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_modificar.Location = new Point(374, 174);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(177, 29);
            btn_modificar.TabIndex = 3;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_eliminar.Location = new Point(374, 230);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(177, 29);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(228, 332);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(128, 29);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_CRUD_tipoDePrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 393);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_alta);
            Controls.Add(dgv_tiposDePrenda);
            Controls.Add(btn_buscar);
            Controls.Add(txb_buscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_CRUD_tipoDePrenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Operaciones Tipo de Prenda";
            ((System.ComponentModel.ISupportInitialize)dgv_tiposDePrenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_buscar;
        private Button btn_buscar;
        private DataGridView dgv_tiposDePrenda;
        private Button btn_alta;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_salir;
    }
}