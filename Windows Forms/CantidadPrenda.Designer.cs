namespace Windows_Forms
{
    partial class form_cantidadPrenda
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
            txb_cantidad = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 32);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la cantidad a comprar: ";
            // 
            // txb_cantidad
            // 
            txb_cantidad.Location = new Point(81, 84);
            txb_cantidad.Name = "txb_cantidad";
            txb_cantidad.Size = new Size(278, 27);
            txb_cantidad.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(108, 155);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cancelar.Location = new Point(228, 155);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // form_cantidadPrenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 211);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txb_cantidad);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_cantidadPrenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cantidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_cantidad;
        private Button btn_aceptar;
        private Button btn_cancelar;
    }
}