namespace Windows_Forms
{
    partial class PaginaPrincipal
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
            mnsPrincipal = new MenuStrip();
            mnuArchivo = new ToolStripMenuItem();
            mnu_editarCuenta = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            mnu_comprar = new ToolStripMenuItem();
            mnu_verPrendas = new ToolStripMenuItem();
            mnu_verCarrito = new ToolStripMenuItem();
            mnu_verMisCompras = new ToolStripMenuItem();
            mnu_operaciones = new ToolStripMenuItem();
            mnu_prendas = new ToolStripMenuItem();
            mnu_tiposDePrenda = new ToolStripMenuItem();
            mnu_marcas = new ToolStripMenuItem();
            mnu_bonificaciones = new ToolStripMenuItem();
            mnu_verCargaActual = new ToolStripMenuItem();
            mnu_verCargas = new ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.ImageScalingSize = new Size(20, 20);
            mnsPrincipal.Items.AddRange(new ToolStripItem[] { mnuArchivo, mnu_comprar, mnu_operaciones });
            mnsPrincipal.Location = new Point(0, 0);
            mnsPrincipal.MdiWindowListItem = mnuArchivo;
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Size = new Size(892, 28);
            mnsPrincipal.TabIndex = 1;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnu_editarCuenta, mnuCerrarSesion, mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(73, 24);
            mnuArchivo.Text = "Archivo";
            // 
            // mnu_editarCuenta
            // 
            mnu_editarCuenta.Name = "mnu_editarCuenta";
            mnu_editarCuenta.Size = new Size(181, 26);
            mnu_editarCuenta.Text = "Editar Cuenta";
            mnu_editarCuenta.Click += mnu_editarCuenta_Click;
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(181, 26);
            mnuCerrarSesion.Text = "Cerrar Sesion";
            mnuCerrarSesion.Click += mnuCerrarSesion_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(181, 26);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // mnu_comprar
            // 
            mnu_comprar.DropDownItems.AddRange(new ToolStripItem[] { mnu_verPrendas, mnu_verCarrito, mnu_verMisCompras });
            mnu_comprar.Name = "mnu_comprar";
            mnu_comprar.Size = new Size(81, 24);
            mnu_comprar.Text = "Comprar";
            // 
            // mnu_verPrendas
            // 
            mnu_verPrendas.Name = "mnu_verPrendas";
            mnu_verPrendas.Size = new Size(203, 26);
            mnu_verPrendas.Text = "Ver Prendas";
            mnu_verPrendas.Click += mnu_verPrendas_Click;
            // 
            // mnu_verCarrito
            // 
            mnu_verCarrito.Name = "mnu_verCarrito";
            mnu_verCarrito.Size = new Size(203, 26);
            mnu_verCarrito.Text = "Ver Carrito";
            mnu_verCarrito.Click += mnu_verCarrito_Click;
            // 
            // mnu_verMisCompras
            // 
            mnu_verMisCompras.Name = "mnu_verMisCompras";
            mnu_verMisCompras.Size = new Size(203, 26);
            mnu_verMisCompras.Text = "Ver Mis Compras";
            mnu_verMisCompras.Click += mnu_verMisCompras_Click;
            // 
            // mnu_operaciones
            // 
            mnu_operaciones.DropDownItems.AddRange(new ToolStripItem[] { mnu_prendas, mnu_tiposDePrenda, mnu_marcas, mnu_bonificaciones, mnu_verCargaActual, mnu_verCargas });
            mnu_operaciones.Name = "mnu_operaciones";
            mnu_operaciones.Size = new Size(106, 24);
            mnu_operaciones.Text = "Operaciones";
            // 
            // mnu_prendas
            // 
            mnu_prendas.Name = "mnu_prendas";
            mnu_prendas.Size = new Size(224, 26);
            mnu_prendas.Text = "Prendas";
            mnu_prendas.Click += mnu_prendas_Click;
            // 
            // mnu_tiposDePrenda
            // 
            mnu_tiposDePrenda.Name = "mnu_tiposDePrenda";
            mnu_tiposDePrenda.Size = new Size(224, 26);
            mnu_tiposDePrenda.Text = "TiposDePrenda";
            mnu_tiposDePrenda.Click += mnu_tiposDePrenda_Click;
            // 
            // mnu_marcas
            // 
            mnu_marcas.Name = "mnu_marcas";
            mnu_marcas.Size = new Size(224, 26);
            mnu_marcas.Text = "Marcas";
            mnu_marcas.Click += mnu_marcas_Click;
            // 
            // mnu_bonificaciones
            // 
            mnu_bonificaciones.Name = "mnu_bonificaciones";
            mnu_bonificaciones.Size = new Size(224, 26);
            mnu_bonificaciones.Text = "Bonificaciones";
            mnu_bonificaciones.Click += mnu_bonificaciones_Click;
            // 
            // mnu_verCargaActual
            // 
            mnu_verCargaActual.Name = "mnu_verCargaActual";
            mnu_verCargaActual.Size = new Size(224, 26);
            mnu_verCargaActual.Text = "Ver Carga Actual";
            mnu_verCargaActual.Click += mnu_verCargaActual_Click;
            // 
            // mnu_verCargas
            // 
            mnu_verCargas.Name = "mnu_verCargas";
            mnu_verCargas.Size = new Size(224, 26);
            mnu_verCargas.Text = "Ver Cargas";
            mnu_verCargas.Click += mnu_verCargas_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(892, 510);
            Controls.Add(mnsPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnsPrincipal;
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            WindowState = FormWindowState.Maximized;
            Shown += PaginaPrincipal_Shown;
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem mnuArchivo;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuCerrarSesion;
        private ToolStripMenuItem mnu_editarCuenta;
        private ToolStripMenuItem mnu_comprar;
        private ToolStripMenuItem mnu_verPrendas;
        private ToolStripMenuItem mnu_verCarrito;
        private ToolStripMenuItem mnu_verMisCompras;
        private ToolStripMenuItem mnu_operaciones;
        private ToolStripMenuItem mnu_prendas;
        private ToolStripMenuItem mnu_tiposDePrenda;
        private ToolStripMenuItem mnu_marcas;
        private ToolStripMenuItem mnu_bonificaciones;
        private ToolStripMenuItem mnu_verCargaActual;
        private ToolStripMenuItem mnu_verCargas;
    }
}