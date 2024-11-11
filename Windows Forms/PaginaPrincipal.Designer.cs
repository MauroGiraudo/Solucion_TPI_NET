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
            comprarToolStripMenuItem = new ToolStripMenuItem();
            verPrendasToolStripMenuItem = new ToolStripMenuItem();
            verCarritoToolStripMenuItem = new ToolStripMenuItem();
            verMisComprasToolStripMenuItem = new ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.ImageScalingSize = new Size(20, 20);
            mnsPrincipal.Items.AddRange(new ToolStripItem[] { mnuArchivo, comprarToolStripMenuItem });
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
            // comprarToolStripMenuItem
            // 
            comprarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verPrendasToolStripMenuItem, verCarritoToolStripMenuItem, verMisComprasToolStripMenuItem });
            comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            comprarToolStripMenuItem.Size = new Size(81, 24);
            comprarToolStripMenuItem.Text = "Comprar";
            // 
            // verPrendasToolStripMenuItem
            // 
            verPrendasToolStripMenuItem.Name = "verPrendasToolStripMenuItem";
            verPrendasToolStripMenuItem.Size = new Size(224, 26);
            verPrendasToolStripMenuItem.Text = "Ver Prendas";
            verPrendasToolStripMenuItem.Click += verPrendasToolStripMenuItem_Click;
            // 
            // verCarritoToolStripMenuItem
            // 
            verCarritoToolStripMenuItem.Name = "verCarritoToolStripMenuItem";
            verCarritoToolStripMenuItem.Size = new Size(224, 26);
            verCarritoToolStripMenuItem.Text = "Ver Carrito";
            verCarritoToolStripMenuItem.Click += verCarritoToolStripMenuItem_Click;
            // 
            // verMisComprasToolStripMenuItem
            // 
            verMisComprasToolStripMenuItem.Name = "verMisComprasToolStripMenuItem";
            verMisComprasToolStripMenuItem.Size = new Size(224, 26);
            verMisComprasToolStripMenuItem.Text = "Ver Mis Compras";
            verMisComprasToolStripMenuItem.Click += verMisComprasToolStripMenuItem_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private ToolStripMenuItem comprarToolStripMenuItem;
        private ToolStripMenuItem verPrendasToolStripMenuItem;
        private ToolStripMenuItem verCarritoToolStripMenuItem;
        private ToolStripMenuItem verMisComprasToolStripMenuItem;
    }
}