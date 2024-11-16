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
            editarCuentaToolStripMenuItem = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            mnu_comprar = new ToolStripMenuItem();
            verPrendasToolStripMenuItem = new ToolStripMenuItem();
            verCarritoToolStripMenuItem = new ToolStripMenuItem();
            verMisComprasToolStripMenuItem = new ToolStripMenuItem();
            mnu_operaciones = new ToolStripMenuItem();
            mnu_prendas = new ToolStripMenuItem();
            mnu_tiposDePrenda = new ToolStripMenuItem();
            mnu_marcas = new ToolStripMenuItem();
            bonificacionesToolStripMenuItem = new ToolStripMenuItem();
            verCargasToolStripMenuItem = new ToolStripMenuItem();
            verCargasToolStripMenuItem1 = new ToolStripMenuItem();
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
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { editarCuentaToolStripMenuItem, mnuCerrarSesion, mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(73, 24);
            mnuArchivo.Text = "Archivo";
            // 
            // editarCuentaToolStripMenuItem
            // 
            editarCuentaToolStripMenuItem.Name = "editarCuentaToolStripMenuItem";
            editarCuentaToolStripMenuItem.Size = new Size(181, 26);
            editarCuentaToolStripMenuItem.Text = "Editar Cuenta";
            editarCuentaToolStripMenuItem.Click += editarCuentaToolStripMenuItem_Click;
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
            mnu_comprar.DropDownItems.AddRange(new ToolStripItem[] { verPrendasToolStripMenuItem, verCarritoToolStripMenuItem, verMisComprasToolStripMenuItem });
            mnu_comprar.Name = "mnu_comprar";
            mnu_comprar.Size = new Size(81, 24);
            mnu_comprar.Text = "Comprar";
            // 
            // verPrendasToolStripMenuItem
            // 
            verPrendasToolStripMenuItem.Name = "verPrendasToolStripMenuItem";
            verPrendasToolStripMenuItem.Size = new Size(203, 26);
            verPrendasToolStripMenuItem.Text = "Ver Prendas";
            verPrendasToolStripMenuItem.Click += verPrendasToolStripMenuItem_Click;
            // 
            // verCarritoToolStripMenuItem
            // 
            verCarritoToolStripMenuItem.Name = "verCarritoToolStripMenuItem";
            verCarritoToolStripMenuItem.Size = new Size(203, 26);
            verCarritoToolStripMenuItem.Text = "Ver Carrito";
            verCarritoToolStripMenuItem.Click += verCarritoToolStripMenuItem_Click;
            // 
            // verMisComprasToolStripMenuItem
            // 
            verMisComprasToolStripMenuItem.Name = "verMisComprasToolStripMenuItem";
            verMisComprasToolStripMenuItem.Size = new Size(203, 26);
            verMisComprasToolStripMenuItem.Text = "Ver Mis Compras";
            verMisComprasToolStripMenuItem.Click += verMisComprasToolStripMenuItem_Click;
            // 
            // mnu_operaciones
            // 
            mnu_operaciones.DropDownItems.AddRange(new ToolStripItem[] { mnu_prendas, mnu_tiposDePrenda, mnu_marcas, bonificacionesToolStripMenuItem, verCargasToolStripMenuItem, verCargasToolStripMenuItem1 });
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
            // bonificacionesToolStripMenuItem
            // 
            bonificacionesToolStripMenuItem.Name = "bonificacionesToolStripMenuItem";
            bonificacionesToolStripMenuItem.Size = new Size(224, 26);
            bonificacionesToolStripMenuItem.Text = "Bonificaciones";
            // 
            // verCargasToolStripMenuItem
            // 
            verCargasToolStripMenuItem.Name = "verCargasToolStripMenuItem";
            verCargasToolStripMenuItem.Size = new Size(224, 26);
            verCargasToolStripMenuItem.Text = "Ver Carga Actual";
            verCargasToolStripMenuItem.Click += verCargasToolStripMenuItem_Click;
            // 
            // verCargasToolStripMenuItem1
            // 
            verCargasToolStripMenuItem1.Name = "verCargasToolStripMenuItem1";
            verCargasToolStripMenuItem1.Size = new Size(224, 26);
            verCargasToolStripMenuItem1.Text = "Ver Cargas";
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
        private ToolStripMenuItem editarCuentaToolStripMenuItem;
        private ToolStripMenuItem mnu_comprar;
        private ToolStripMenuItem verPrendasToolStripMenuItem;
        private ToolStripMenuItem verCarritoToolStripMenuItem;
        private ToolStripMenuItem verMisComprasToolStripMenuItem;
        private ToolStripMenuItem mnu_operaciones;
        private ToolStripMenuItem mnu_prendas;
        private ToolStripMenuItem mnu_tiposDePrenda;
        private ToolStripMenuItem mnu_marcas;
        private ToolStripMenuItem bonificacionesToolStripMenuItem;
        private ToolStripMenuItem verCargasToolStripMenuItem;
        private ToolStripMenuItem verCargasToolStripMenuItem1;
    }
}