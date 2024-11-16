namespace Windows_Forms
{
    partial class form_CRUD_marca
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
            dgv_marcas = new DataGridView();
            btn_alta = new Button();
            txb_buscar = new TextBox();
            btn_buscar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_marcas).BeginInit();
            SuspendLayout();
            // 
            // dgv_marcas
            // 
            dgv_marcas.ColumnHeadersHeight = 29;
            dgv_marcas.Location = new Point(51, 87);
            dgv_marcas.Name = "dgv_marcas";
            dgv_marcas.RowHeadersWidth = 51;
            dgv_marcas.RowTemplate.ReadOnly = true;
            dgv_marcas.Size = new Size(300, 382);
            dgv_marcas.TabIndex = 2;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_alta.Location = new Point(396, 199);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(121, 29);
            btn_alta.TabIndex = 3;
            btn_alta.Text = "Nueva Marca";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // txb_buscar
            // 
            txb_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txb_buscar.Location = new Point(51, 34);
            txb_buscar.Name = "txb_buscar";
            txb_buscar.Size = new Size(190, 27);
            txb_buscar.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_buscar.Location = new Point(264, 34);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(87, 29);
            btn_buscar.TabIndex = 1;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_modificar.Location = new Point(396, 261);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(121, 29);
            btn_modificar.TabIndex = 4;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_eliminar.Location = new Point(396, 320);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(121, 29);
            btn_eliminar.TabIndex = 5;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(212, 510);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(121, 29);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_CRUD_marca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 566);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_buscar);
            Controls.Add(txb_buscar);
            Controls.Add(btn_alta);
            Controls.Add(dgv_marcas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_CRUD_marca";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Operaciones Marca";
            ((System.ComponentModel.ISupportInitialize)dgv_marcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_marcas;
        private Button btn_alta;
        private TextBox txb_buscar;
        private Button btn_buscar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_salir;
    }
}