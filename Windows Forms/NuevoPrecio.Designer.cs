namespace Windows_Forms
{
    partial class form_nuevoPrecio
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
            dtp_fechaVigencia = new DateTimePicker();
            txb_valor = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            lbl_fechaVigencia = new Label();
            lbl_valor = new Label();
            lbl_IdPrenda = new Label();
            SuspendLayout();
            // 
            // dtp_fechaVigencia
            // 
            dtp_fechaVigencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_fechaVigencia.Location = new Point(64, 75);
            dtp_fechaVigencia.Name = "dtp_fechaVigencia";
            dtp_fechaVigencia.Size = new Size(287, 27);
            dtp_fechaVigencia.TabIndex = 0;
            // 
            // txb_valor
            // 
            txb_valor.Location = new Point(81, 170);
            txb_valor.Name = "txb_valor";
            txb_valor.Size = new Size(250, 27);
            txb_valor.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(103, 230);
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
            btn_cancelar.Location = new Point(215, 230);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_fechaVigencia
            // 
            lbl_fechaVigencia.AutoSize = true;
            lbl_fechaVigencia.Location = new Point(54, 42);
            lbl_fechaVigencia.Name = "lbl_fechaVigencia";
            lbl_fechaVigencia.Size = new Size(315, 20);
            lbl_fechaVigencia.TabIndex = 4;
            lbl_fechaVigencia.Text = "Ingrese la fecha de vigencia del nuevo precio: ";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Location = new Point(121, 134);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(170, 20);
            lbl_valor.TabIndex = 5;
            lbl_valor.Text = "Ingrese el nuevo precio: ";
            // 
            // lbl_IdPrenda
            // 
            lbl_IdPrenda.AutoSize = true;
            lbl_IdPrenda.Location = new Point(12, 234);
            lbl_IdPrenda.Name = "lbl_IdPrenda";
            lbl_IdPrenda.Size = new Size(68, 20);
            lbl_IdPrenda.TabIndex = 6;
            lbl_IdPrenda.Text = "IdPrenda";
            lbl_IdPrenda.Visible = false;
            // 
            // form_nuevoPrecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 280);
            Controls.Add(lbl_IdPrenda);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_fechaVigencia);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txb_valor);
            Controls.Add(dtp_fechaVigencia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_nuevoPrecio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Precio";
            Load += form_nuevoPrecio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_fechaVigencia;
        private TextBox txb_valor;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_fechaVigencia;
        private Label lbl_valor;
        private Label lbl_IdPrenda;
    }
}