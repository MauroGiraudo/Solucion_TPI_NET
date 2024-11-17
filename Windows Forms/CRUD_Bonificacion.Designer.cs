namespace Windows_Forms
{
    partial class form_CRUD_Bonificacion
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
            dgv_bonificaciones = new DataGridView();
            btn_alta = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_bonificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgv_bonificaciones
            // 
            dgv_bonificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bonificaciones.Location = new Point(50, 47);
            dgv_bonificaciones.Name = "dgv_bonificaciones";
            dgv_bonificaciones.RowHeadersWidth = 51;
            dgv_bonificaciones.Size = new Size(554, 250);
            dgv_bonificaciones.TabIndex = 2;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_alta.Location = new Point(632, 90);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(157, 29);
            btn_alta.TabIndex = 3;
            btn_alta.Text = "Nueva Bonificación";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_modificar.Location = new Point(632, 159);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(157, 29);
            btn_modificar.TabIndex = 4;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_eliminar.Location = new Point(632, 230);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(157, 29);
            btn_eliminar.TabIndex = 5;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.Location = new Point(353, 344);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(157, 29);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // form_CRUD_Bonificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 406);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_alta);
            Controls.Add(dgv_bonificaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_CRUD_Bonificacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CRUD Bonificacion";
            ((System.ComponentModel.ISupportInitialize)dgv_bonificaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_bonificaciones;
        private Button btn_alta;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_salir;
    }
}