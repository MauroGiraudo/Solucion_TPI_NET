namespace Windows_Forms
{
    partial class FormPagPrin
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
            mns_titulo = new MenuStrip();
            lbl_titulo = new Label();
            mns_opciones = new MenuStrip();
            imi_prendas = new FontAwesome.Sharp.IconMenuItem();
            msi_ofertas = new ToolStripMenuItem();
            msi_ropa = new ToolStripMenuItem();
            msi_ropaRemeras = new ToolStripMenuItem();
            msi_ropaPantalones = new ToolStripMenuItem();
            msi_ropaAbrigo = new ToolStripMenuItem();
            msi_calzado = new ToolStripMenuItem();
            msi_calzadoFormal = new ToolStripMenuItem();
            msi_calzadoCasual = new ToolStripMenuItem();
            msi_calzadoDeportivo = new ToolStripMenuItem();
            msi_accesorios = new ToolStripMenuItem();
            msi_accesoriosGorras = new ToolStripMenuItem();
            msi_accesoriosMedias = new ToolStripMenuItem();
            msi_accesoriosRelojes = new ToolStripMenuItem();
            msi_accesoriosColgantes = new ToolStripMenuItem();
            imi_info = new FontAwesome.Sharp.IconMenuItem();
            imi_miCuenta = new FontAwesome.Sharp.IconMenuItem();
            msi_misCompras = new ToolStripMenuItem();
            msi_miCuenta = new ToolStripMenuItem();
            msi_cerrarSesion = new ToolStripMenuItem();
            imi_carrito = new FontAwesome.Sharp.IconMenuItem();
            imi_usuarios = new FontAwesome.Sharp.IconMenuItem();
            msi_listUsuarios = new ToolStripMenuItem();
            imi_productos = new FontAwesome.Sharp.IconMenuItem();
            msi_verProductos = new ToolStripMenuItem();
            msi_agrStock = new ToolStripMenuItem();
            pnl_Body = new Panel();
            mns_opciones.SuspendLayout();
            SuspendLayout();
            // 
            // mns_titulo
            // 
            mns_titulo.AutoSize = false;
            mns_titulo.BackColor = Color.Purple;
            mns_titulo.ImageScalingSize = new Size(20, 20);
            mns_titulo.Location = new Point(0, 0);
            mns_titulo.Name = "mns_titulo";
            mns_titulo.Padding = new Padding(5, 2, 0, 2);
            mns_titulo.RightToLeft = RightToLeft.Yes;
            mns_titulo.Size = new Size(682, 43);
            mns_titulo.TabIndex = 0;
            mns_titulo.Text = "menuStrip1";
            mns_titulo.ItemClicked += menuStrip1_ItemClicked;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Purple;
            lbl_titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.ControlLightLight;
            lbl_titulo.Location = new Point(0, 16);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(195, 28);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "LaTienditaDeCarlos";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mns_opciones
            // 
            mns_opciones.AutoSize = false;
            mns_opciones.BackColor = Color.LavenderBlush;
            mns_opciones.ImageScalingSize = new Size(20, 20);
            mns_opciones.Items.AddRange(new ToolStripItem[] { imi_prendas, imi_info, imi_miCuenta, imi_carrito, imi_usuarios, imi_productos });
            mns_opciones.Location = new Point(0, 43);
            mns_opciones.Name = "mns_opciones";
            mns_opciones.Padding = new Padding(5, 2, 0, 2);
            mns_opciones.Size = new Size(682, 61);
            mns_opciones.TabIndex = 3;
            mns_opciones.Text = "menuStrip2";
            // 
            // imi_prendas
            // 
            imi_prendas.AutoSize = false;
            imi_prendas.DropDownItems.AddRange(new ToolStripItem[] { msi_ofertas, msi_ropa, msi_calzado, msi_accesorios });
            imi_prendas.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            imi_prendas.IconColor = Color.Black;
            imi_prendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_prendas.IconSize = 45;
            imi_prendas.ImageScaling = ToolStripItemImageScaling.None;
            imi_prendas.Name = "imi_prendas";
            imi_prendas.Size = new Size(65, 60);
            imi_prendas.Text = "Prendas";
            imi_prendas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // msi_ofertas
            // 
            msi_ofertas.Name = "msi_ofertas";
            msi_ofertas.Size = new Size(131, 22);
            msi_ofertas.Text = "Ofertas";
            msi_ofertas.Click += imi_ofertas_Click;
            // 
            // msi_ropa
            // 
            msi_ropa.DropDownItems.AddRange(new ToolStripItem[] { msi_ropaRemeras, msi_ropaPantalones, msi_ropaAbrigo });
            msi_ropa.Name = "msi_ropa";
            msi_ropa.Size = new Size(131, 22);
            msi_ropa.Text = "Ropa";
            msi_ropa.Click += msi_ropa_Click;
            // 
            // msi_ropaRemeras
            // 
            msi_ropaRemeras.Name = "msi_ropaRemeras";
            msi_ropaRemeras.Size = new Size(132, 22);
            msi_ropaRemeras.Text = "Remeras";
            // 
            // msi_ropaPantalones
            // 
            msi_ropaPantalones.Name = "msi_ropaPantalones";
            msi_ropaPantalones.Size = new Size(132, 22);
            msi_ropaPantalones.Text = "Pantalones";
            // 
            // msi_ropaAbrigo
            // 
            msi_ropaAbrigo.Name = "msi_ropaAbrigo";
            msi_ropaAbrigo.Size = new Size(132, 22);
            msi_ropaAbrigo.Text = "Abrigo";
            // 
            // msi_calzado
            // 
            msi_calzado.DropDownItems.AddRange(new ToolStripItem[] { msi_calzadoFormal, msi_calzadoCasual, msi_calzadoDeportivo });
            msi_calzado.Name = "msi_calzado";
            msi_calzado.Size = new Size(131, 22);
            msi_calzado.Text = "Calzado";
            msi_calzado.Click += msi_calzado_Click;
            // 
            // msi_calzadoFormal
            // 
            msi_calzadoFormal.Name = "msi_calzadoFormal";
            msi_calzadoFormal.Size = new Size(126, 22);
            msi_calzadoFormal.Text = "Formal";
            // 
            // msi_calzadoCasual
            // 
            msi_calzadoCasual.Name = "msi_calzadoCasual";
            msi_calzadoCasual.Size = new Size(126, 22);
            msi_calzadoCasual.Text = "Casual";
            // 
            // msi_calzadoDeportivo
            // 
            msi_calzadoDeportivo.Name = "msi_calzadoDeportivo";
            msi_calzadoDeportivo.Size = new Size(126, 22);
            msi_calzadoDeportivo.Text = "Deportivo";
            // 
            // msi_accesorios
            // 
            msi_accesorios.DropDownItems.AddRange(new ToolStripItem[] { msi_accesoriosGorras, msi_accesoriosMedias, msi_accesoriosRelojes, msi_accesoriosColgantes });
            msi_accesorios.Name = "msi_accesorios";
            msi_accesorios.Size = new Size(131, 22);
            msi_accesorios.Text = "Accesorios";
            msi_accesorios.Click += msi_accesorios_Click;
            // 
            // msi_accesoriosGorras
            // 
            msi_accesoriosGorras.Name = "msi_accesoriosGorras";
            msi_accesoriosGorras.Size = new Size(127, 22);
            msi_accesoriosGorras.Text = "Gorras";
            // 
            // msi_accesoriosMedias
            // 
            msi_accesoriosMedias.Name = "msi_accesoriosMedias";
            msi_accesoriosMedias.Size = new Size(127, 22);
            msi_accesoriosMedias.Text = "Medias";
            // 
            // msi_accesoriosRelojes
            // 
            msi_accesoriosRelojes.Name = "msi_accesoriosRelojes";
            msi_accesoriosRelojes.Size = new Size(127, 22);
            msi_accesoriosRelojes.Text = "Relojes";
            // 
            // msi_accesoriosColgantes
            // 
            msi_accesoriosColgantes.Name = "msi_accesoriosColgantes";
            msi_accesoriosColgantes.Size = new Size(127, 22);
            msi_accesoriosColgantes.Text = "Colgantes";
            // 
            // imi_info
            // 
            imi_info.AutoSize = false;
            imi_info.IconChar = FontAwesome.Sharp.IconChar.Info;
            imi_info.IconColor = Color.Black;
            imi_info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_info.IconSize = 45;
            imi_info.ImageScaling = ToolStripItemImageScaling.None;
            imi_info.Name = "imi_info";
            imi_info.Size = new Size(65, 60);
            imi_info.Text = "Acerca de";
            imi_info.TextImageRelation = TextImageRelation.ImageAboveText;
            imi_info.Click += imi_info_Click;
            // 
            // imi_miCuenta
            // 
            imi_miCuenta.Alignment = ToolStripItemAlignment.Right;
            imi_miCuenta.AutoSize = false;
            imi_miCuenta.DropDownItems.AddRange(new ToolStripItem[] { msi_misCompras, msi_miCuenta, msi_cerrarSesion });
            imi_miCuenta.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            imi_miCuenta.IconColor = Color.Black;
            imi_miCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_miCuenta.IconSize = 45;
            imi_miCuenta.ImageScaling = ToolStripItemImageScaling.None;
            imi_miCuenta.Name = "imi_miCuenta";
            imi_miCuenta.Padding = new Padding(5, 0, 1, 0);
            imi_miCuenta.RightToLeft = RightToLeft.Yes;
            imi_miCuenta.Size = new Size(65, 60);
            imi_miCuenta.Text = "Cuenta";
            imi_miCuenta.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // msi_misCompras
            // 
            msi_misCompras.Alignment = ToolStripItemAlignment.Right;
            msi_misCompras.AutoSize = false;
            msi_misCompras.Name = "msi_misCompras";
            msi_misCompras.RightToLeft = RightToLeft.Yes;
            msi_misCompras.Size = new Size(224, 26);
            msi_misCompras.Text = "Mis compras";
            msi_misCompras.Click += msi_misCompras_Click;
            // 
            // msi_miCuenta
            // 
            msi_miCuenta.Name = "msi_miCuenta";
            msi_miCuenta.Size = new Size(148, 22);
            msi_miCuenta.Text = "Mi cuenta";
            msi_miCuenta.Click += msi_miCuenta_Click;
            // 
            // msi_cerrarSesion
            // 
            msi_cerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msi_cerrarSesion.ForeColor = Color.Red;
            msi_cerrarSesion.Name = "msi_cerrarSesion";
            msi_cerrarSesion.Size = new Size(148, 22);
            msi_cerrarSesion.Text = "Cerrar Sesion";
            msi_cerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            msi_cerrarSesion.Click += salirToolStripMenuItem_Click;
            // 
            // imi_carrito
            // 
            imi_carrito.Alignment = ToolStripItemAlignment.Right;
            imi_carrito.AutoSize = false;
            imi_carrito.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            imi_carrito.IconColor = Color.Black;
            imi_carrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_carrito.IconSize = 45;
            imi_carrito.ImageScaling = ToolStripItemImageScaling.None;
            imi_carrito.Name = "imi_carrito";
            imi_carrito.RightToLeft = RightToLeft.Yes;
            imi_carrito.Size = new Size(65, 60);
            imi_carrito.Text = "Carrito";
            imi_carrito.TextImageRelation = TextImageRelation.ImageAboveText;
            imi_carrito.Click += imi_carrito_Click;
            // 
            // imi_usuarios
            // 
            imi_usuarios.AutoSize = false;
            imi_usuarios.DropDownItems.AddRange(new ToolStripItem[] { msi_listUsuarios });
            imi_usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            imi_usuarios.IconColor = Color.Black;
            imi_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_usuarios.IconSize = 45;
            imi_usuarios.ImageScaling = ToolStripItemImageScaling.None;
            imi_usuarios.Name = "imi_usuarios";
            imi_usuarios.Size = new Size(65, 60);
            imi_usuarios.Text = "Usuarios";
            imi_usuarios.TextAlign = ContentAlignment.BottomCenter;
            imi_usuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // msi_listUsuarios
            // 
            msi_listUsuarios.Name = "msi_listUsuarios";
            msi_listUsuarios.Size = new Size(160, 22);
            msi_listUsuarios.Text = "Listado Usuarios";
            // 
            // imi_productos
            // 
            imi_productos.AutoSize = false;
            imi_productos.DropDownItems.AddRange(new ToolStripItem[] { msi_verProductos, msi_agrStock });
            imi_productos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            imi_productos.IconColor = Color.Black;
            imi_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imi_productos.IconSize = 45;
            imi_productos.ImageScaling = ToolStripItemImageScaling.None;
            imi_productos.Name = "imi_productos";
            imi_productos.Size = new Size(65, 60);
            imi_productos.Text = "Productos";
            imi_productos.TextAlign = ContentAlignment.BottomCenter;
            imi_productos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // msi_verProductos
            // 
            msi_verProductos.Name = "msi_verProductos";
            msi_verProductos.Size = new Size(180, 22);
            msi_verProductos.Text = "Ver Productos";
            msi_verProductos.Click += msi_verProductos_Click;
            // 
            // msi_agrStock
            // 
            msi_agrStock.Name = "msi_agrStock";
            msi_agrStock.Size = new Size(180, 22);
            msi_agrStock.Text = "Agregar Stock";
            msi_agrStock.Click += msi_agrStock_Click;
            // 
            // pnl_Body
            // 
            pnl_Body.Location = new Point(0, 106);
            pnl_Body.Margin = new Padding(3, 2, 3, 2);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Size = new Size(682, 265);
            pnl_Body.TabIndex = 4;
            // 
            // FormPagPrin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 371);
            Controls.Add(pnl_Body);
            Controls.Add(mns_opciones);
            Controls.Add(lbl_titulo);
            Controls.Add(mns_titulo);
            MainMenuStrip = mns_titulo;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPagPrin";
            Text = "Página Principal";
            Load += FormPagPrin_Load;
            mns_opciones.ResumeLayout(false);
            mns_opciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mns_titulo;
        private Label lbl_titulo;
        private MenuStrip mns_opciones;
        private FontAwesome.Sharp.IconMenuItem imi_carrito;
        private FontAwesome.Sharp.IconMenuItem imi_prendas;
        private FontAwesome.Sharp.IconMenuItem imi_miCuenta;
        private FontAwesome.Sharp.IconMenuItem imi_info;
        private ToolStripMenuItem msi_misCompras;
        private ToolStripMenuItem msi_miCuenta;
        private ToolStripMenuItem msi_cerrarSesion;
        private ToolStripMenuItem msi_ofertas;
        private ToolStripMenuItem msi_ropa;
        private ToolStripMenuItem msi_ropaRemeras;
        private ToolStripMenuItem msi_ropaPantalones;
        private ToolStripMenuItem msi_ropaAbrigo;
        private ToolStripMenuItem msi_calzado;
        private ToolStripMenuItem msi_accesorios;
        private ToolStripMenuItem msi_calzadoFormal;
        private ToolStripMenuItem msi_calzadoCasual;
        private ToolStripMenuItem msi_calzadoDeportivo;
        private ToolStripMenuItem msi_accesoriosGorras;
        private ToolStripMenuItem msi_accesoriosMedias;
        private ToolStripMenuItem msi_accesoriosRelojes;
        private ToolStripMenuItem msi_accesoriosColgantes;
        private Panel pnl_Body;
        private FontAwesome.Sharp.IconMenuItem imi_usuarios;
        private ToolStripMenuItem msi_listUsuarios;
        private FontAwesome.Sharp.IconMenuItem imi_productos;
        private ToolStripMenuItem msi_verProductos;
        private ToolStripMenuItem msi_agrStock;
    }
}