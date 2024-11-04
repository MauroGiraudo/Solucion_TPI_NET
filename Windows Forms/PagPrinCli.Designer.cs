namespace Windows_Forms
{
    partial class FormPagPrinCli
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
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            menuStrip2 = new MenuStrip();
            iconPrendas = new FontAwesome.Sharp.IconMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            ropaToolStripMenuItem = new ToolStripMenuItem();
            remerasToolStripMenuItem = new ToolStripMenuItem();
            pantalonesToolStripMenuItem = new ToolStripMenuItem();
            buzosToolStripMenuItem = new ToolStripMenuItem();
            calzadoToolStripMenuItem = new ToolStripMenuItem();
            formalToolStripMenuItem = new ToolStripMenuItem();
            casualToolStripMenuItem = new ToolStripMenuItem();
            deportivoToolStripMenuItem = new ToolStripMenuItem();
            accesoriosToolStripMenuItem = new ToolStripMenuItem();
            gorrasToolStripMenuItem = new ToolStripMenuItem();
            mediasToolStripMenuItem = new ToolStripMenuItem();
            relojesToolStripMenuItem = new ToolStripMenuItem();
            colgantesToolStripMenuItem = new ToolStripMenuItem();
            iconInfo = new FontAwesome.Sharp.IconMenuItem();
            iconMiCuenta = new FontAwesome.Sharp.IconMenuItem();
            misComprasToolStripMenuItem = new ToolStripMenuItem();
            miCuentaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            iconCarrito = new FontAwesome.Sharp.IconMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            pnl_Body = new Panel();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Purple;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(780, 57);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 22);
            label1.Name = "label1";
            label1.Size = new Size(241, 35);
            label1.TabIndex = 1;
            label1.Text = "LaTienditaDeCarlos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 205);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.LavenderBlush;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { iconPrendas, iconInfo, iconMiCuenta, iconCarrito, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip2.Location = new Point(0, 57);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(780, 74);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // iconPrendas
            // 
            iconPrendas.AutoSize = false;
            iconPrendas.DropDownItems.AddRange(new ToolStripItem[] { ofertasToolStripMenuItem, ropaToolStripMenuItem, calzadoToolStripMenuItem, accesoriosToolStripMenuItem });
            iconPrendas.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            iconPrendas.IconColor = Color.Black;
            iconPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPrendas.IconSize = 55;
            iconPrendas.ImageScaling = ToolStripItemImageScaling.None;
            iconPrendas.Name = "iconPrendas";
            iconPrendas.Size = new Size(80, 70);
            iconPrendas.Text = "Prendas";
            iconPrendas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ofertasToolStripMenuItem
            // 
            ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            ofertasToolStripMenuItem.Size = new Size(224, 26);
            ofertasToolStripMenuItem.Text = "Ofertas";
            ofertasToolStripMenuItem.Click += ofertasToolStripMenuItem_Click;
            // 
            // ropaToolStripMenuItem
            // 
            ropaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { remerasToolStripMenuItem, pantalonesToolStripMenuItem, buzosToolStripMenuItem });
            ropaToolStripMenuItem.Name = "ropaToolStripMenuItem";
            ropaToolStripMenuItem.Size = new Size(224, 26);
            ropaToolStripMenuItem.Text = "Ropa";
            ropaToolStripMenuItem.Click += ropaToolStripMenuItem_Click;
            // 
            // remerasToolStripMenuItem
            // 
            remerasToolStripMenuItem.Name = "remerasToolStripMenuItem";
            remerasToolStripMenuItem.Size = new Size(224, 26);
            remerasToolStripMenuItem.Text = "Remeras";
            // 
            // pantalonesToolStripMenuItem
            // 
            pantalonesToolStripMenuItem.Name = "pantalonesToolStripMenuItem";
            pantalonesToolStripMenuItem.Size = new Size(224, 26);
            pantalonesToolStripMenuItem.Text = "Pantalones";
            // 
            // buzosToolStripMenuItem
            // 
            buzosToolStripMenuItem.Name = "buzosToolStripMenuItem";
            buzosToolStripMenuItem.Size = new Size(224, 26);
            buzosToolStripMenuItem.Text = "Abrigo";
            // 
            // calzadoToolStripMenuItem
            // 
            calzadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formalToolStripMenuItem, casualToolStripMenuItem, deportivoToolStripMenuItem });
            calzadoToolStripMenuItem.Name = "calzadoToolStripMenuItem";
            calzadoToolStripMenuItem.Size = new Size(224, 26);
            calzadoToolStripMenuItem.Text = "Calzado";
            calzadoToolStripMenuItem.Click += calzadoToolStripMenuItem_Click;
            // 
            // formalToolStripMenuItem
            // 
            formalToolStripMenuItem.Name = "formalToolStripMenuItem";
            formalToolStripMenuItem.Size = new Size(159, 26);
            formalToolStripMenuItem.Text = "Formal";
            // 
            // casualToolStripMenuItem
            // 
            casualToolStripMenuItem.Name = "casualToolStripMenuItem";
            casualToolStripMenuItem.Size = new Size(159, 26);
            casualToolStripMenuItem.Text = "Casual";
            // 
            // deportivoToolStripMenuItem
            // 
            deportivoToolStripMenuItem.Name = "deportivoToolStripMenuItem";
            deportivoToolStripMenuItem.Size = new Size(159, 26);
            deportivoToolStripMenuItem.Text = "Deportivo";
            // 
            // accesoriosToolStripMenuItem
            // 
            accesoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gorrasToolStripMenuItem, mediasToolStripMenuItem, relojesToolStripMenuItem, colgantesToolStripMenuItem });
            accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            accesoriosToolStripMenuItem.Size = new Size(224, 26);
            accesoriosToolStripMenuItem.Text = "Accesorios";
            accesoriosToolStripMenuItem.Click += accesoriosToolStripMenuItem_Click;
            // 
            // gorrasToolStripMenuItem
            // 
            gorrasToolStripMenuItem.Name = "gorrasToolStripMenuItem";
            gorrasToolStripMenuItem.Size = new Size(158, 26);
            gorrasToolStripMenuItem.Text = "Gorras";
            // 
            // mediasToolStripMenuItem
            // 
            mediasToolStripMenuItem.Name = "mediasToolStripMenuItem";
            mediasToolStripMenuItem.Size = new Size(158, 26);
            mediasToolStripMenuItem.Text = "Medias";
            // 
            // relojesToolStripMenuItem
            // 
            relojesToolStripMenuItem.Name = "relojesToolStripMenuItem";
            relojesToolStripMenuItem.Size = new Size(158, 26);
            relojesToolStripMenuItem.Text = "Relojes";
            // 
            // colgantesToolStripMenuItem
            // 
            colgantesToolStripMenuItem.Name = "colgantesToolStripMenuItem";
            colgantesToolStripMenuItem.Size = new Size(158, 26);
            colgantesToolStripMenuItem.Text = "Colgantes";
            // 
            // iconInfo
            // 
            iconInfo.AutoSize = false;
            iconInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconInfo.IconColor = Color.Black;
            iconInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInfo.IconSize = 55;
            iconInfo.ImageScaling = ToolStripItemImageScaling.None;
            iconInfo.Name = "iconInfo";
            iconInfo.Size = new Size(80, 70);
            iconInfo.Text = "Acerca de";
            iconInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            iconInfo.Click += iconInfo_Click;
            // 
            // iconMiCuenta
            // 
            iconMiCuenta.Alignment = ToolStripItemAlignment.Right;
            iconMiCuenta.AutoSize = false;
            iconMiCuenta.DropDownItems.AddRange(new ToolStripItem[] { misComprasToolStripMenuItem, miCuentaToolStripMenuItem, salirToolStripMenuItem });
            iconMiCuenta.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconMiCuenta.IconColor = Color.Black;
            iconMiCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMiCuenta.IconSize = 55;
            iconMiCuenta.ImageScaling = ToolStripItemImageScaling.None;
            iconMiCuenta.Name = "iconMiCuenta";
            iconMiCuenta.Padding = new Padding(5, 0, 1, 0);
            iconMiCuenta.RightToLeft = RightToLeft.Yes;
            iconMiCuenta.Size = new Size(152, 70);
            iconMiCuenta.Text = "Cuenta";
            iconMiCuenta.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // misComprasToolStripMenuItem
            // 
            misComprasToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            misComprasToolStripMenuItem.AutoSize = false;
            misComprasToolStripMenuItem.Name = "misComprasToolStripMenuItem";
            misComprasToolStripMenuItem.RightToLeft = RightToLeft.Yes;
            misComprasToolStripMenuItem.Size = new Size(224, 26);
            misComprasToolStripMenuItem.Text = "Mis compras";
            misComprasToolStripMenuItem.Click += misComprasToolStripMenuItem_Click;
            // 
            // miCuentaToolStripMenuItem
            // 
            miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            miCuentaToolStripMenuItem.Size = new Size(224, 26);
            miCuentaToolStripMenuItem.Text = "Mi cuenta";
            miCuentaToolStripMenuItem.Click += miCuentaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salirToolStripMenuItem.ForeColor = Color.Red;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Cerrar Sesion";
            salirToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // iconCarrito
            // 
            iconCarrito.Alignment = ToolStripItemAlignment.Right;
            iconCarrito.AutoSize = false;
            iconCarrito.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconCarrito.IconColor = Color.Black;
            iconCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCarrito.IconSize = 55;
            iconCarrito.ImageScaling = ToolStripItemImageScaling.None;
            iconCarrito.Name = "iconCarrito";
            iconCarrito.RightToLeft = RightToLeft.Yes;
            iconCarrito.Size = new Size(80, 70);
            iconCarrito.Text = "Carrito";
            iconCarrito.TextImageRelation = TextImageRelation.ImageAboveText;
            iconCarrito.Click += iconCarrito_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 70);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 70);
            // 
            // pnl_Body
            // 
            pnl_Body.Location = new Point(0, 134);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Size = new Size(780, 360);
            pnl_Body.TabIndex = 4;
            // 
            // FormPagPrinCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 495);
            Controls.Add(pnl_Body);
            Controls.Add(menuStrip2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPagPrinCli";
            Text = "Página Principal";
            Load += FormPagPrinCli_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem iconCarrito;
        private FontAwesome.Sharp.IconMenuItem iconPrendas;
        private FontAwesome.Sharp.IconMenuItem iconMiCuenta;
        private FontAwesome.Sharp.IconMenuItem iconInfo;
        private ToolStripMenuItem misComprasToolStripMenuItem;
        private ToolStripMenuItem miCuentaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ofertasToolStripMenuItem;
        private ToolStripMenuItem ropaToolStripMenuItem;
        private ToolStripMenuItem remerasToolStripMenuItem;
        private ToolStripMenuItem pantalonesToolStripMenuItem;
        private ToolStripMenuItem buzosToolStripMenuItem;
        private ToolStripMenuItem calzadoToolStripMenuItem;
        private ToolStripMenuItem accesoriosToolStripMenuItem;
        private ToolStripMenuItem formalToolStripMenuItem;
        private ToolStripMenuItem casualToolStripMenuItem;
        private ToolStripMenuItem deportivoToolStripMenuItem;
        private ToolStripMenuItem gorrasToolStripMenuItem;
        private ToolStripMenuItem mediasToolStripMenuItem;
        private ToolStripMenuItem relojesToolStripMenuItem;
        private ToolStripMenuItem colgantesToolStripMenuItem;
        private Panel pnl_Body;
    }
}