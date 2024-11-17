namespace Windows_Forms
{
    partial class form_altaBonificacion
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
            txb_cantidadParaDescuento = new TextBox();
            txb_porcentajeDescuento = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            lbl_cantidadParaDescuento = new Label();
            lbl_proporcionDescuento = new Label();
            dtp_fechaVigencia = new DateTimePicker();
            lbl_fechaVigenciaDescuento = new Label();
            lbl_idBonificacion = new Label();
            SuspendLayout();
            // 
            // txb_cantidadParaDescuento
            // 
            txb_cantidadParaDescuento.Location = new Point(40, 76);
            txb_cantidadParaDescuento.Name = "txb_cantidadParaDescuento";
            txb_cantidadParaDescuento.Size = new Size(287, 27);
            txb_cantidadParaDescuento.TabIndex = 0;
            // 
            // txb_porcentajeDescuento
            // 
            txb_porcentajeDescuento.Location = new Point(40, 165);
            txb_porcentajeDescuento.Name = "txb_porcentajeDescuento";
            txb_porcentajeDescuento.Size = new Size(287, 27);
            txb_porcentajeDescuento.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_aceptar.Location = new Point(81, 307);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(94, 29);
            btn_aceptar.TabIndex = 3;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cancelar.Location = new Point(181, 307);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(94, 29);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_cantidadParaDescuento
            // 
            lbl_cantidadParaDescuento.AutoSize = true;
            lbl_cantidadParaDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_cantidadParaDescuento.Location = new Point(40, 39);
            lbl_cantidadParaDescuento.Name = "lbl_cantidadParaDescuento";
            lbl_cantidadParaDescuento.Size = new Size(192, 20);
            lbl_cantidadParaDescuento.TabIndex = 5;
            lbl_cantidadParaDescuento.Text = "Cantidad Para Descuento: ";
            // 
            // lbl_proporcionDescuento
            // 
            lbl_proporcionDescuento.AutoSize = true;
            lbl_proporcionDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_proporcionDescuento.Location = new Point(40, 131);
            lbl_proporcionDescuento.Name = "lbl_proporcionDescuento";
            lbl_proporcionDescuento.Size = new Size(190, 20);
            lbl_proporcionDescuento.TabIndex = 6;
            lbl_proporcionDescuento.Text = "Porcentaje de Descuento: ";
            // 
            // dtp_fechaVigencia
            // 
            dtp_fechaVigencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_fechaVigencia.Location = new Point(40, 245);
            dtp_fechaVigencia.Name = "dtp_fechaVigencia";
            dtp_fechaVigencia.Size = new Size(287, 27);
            dtp_fechaVigencia.TabIndex = 2;
            // 
            // lbl_fechaVigenciaDescuento
            // 
            lbl_fechaVigenciaDescuento.AutoSize = true;
            lbl_fechaVigenciaDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_fechaVigenciaDescuento.Location = new Point(40, 212);
            lbl_fechaVigenciaDescuento.Name = "lbl_fechaVigenciaDescuento";
            lbl_fechaVigenciaDescuento.Size = new Size(244, 20);
            lbl_fechaVigenciaDescuento.TabIndex = 7;
            lbl_fechaVigenciaDescuento.Text = "Fecha de Vigencia del Descuento: ";
            // 
            // lbl_idBonificacion
            // 
            lbl_idBonificacion.AutoSize = true;
            lbl_idBonificacion.Location = new Point(243, 9);
            lbl_idBonificacion.Name = "lbl_idBonificacion";
            lbl_idBonificacion.Size = new Size(104, 20);
            lbl_idBonificacion.TabIndex = 8;
            lbl_idBonificacion.Text = "IdBonificacion";
            lbl_idBonificacion.Visible = false;
            // 
            // form_altaBonificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 372);
            Controls.Add(lbl_idBonificacion);
            Controls.Add(lbl_fechaVigenciaDescuento);
            Controls.Add(dtp_fechaVigencia);
            Controls.Add(lbl_proporcionDescuento);
            Controls.Add(lbl_cantidadParaDescuento);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txb_porcentajeDescuento);
            Controls.Add(txb_cantidadParaDescuento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_altaBonificacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alta Bonificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_cantidadParaDescuento;
        private TextBox txb_porcentajeDescuento;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_cantidadParaDescuento;
        private Label lbl_proporcionDescuento;
        private DateTimePicker dtp_fechaVigencia;
        private Label lbl_fechaVigenciaDescuento;
        private Label lbl_idBonificacion;
    }
}