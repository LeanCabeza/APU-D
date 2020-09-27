namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCompraPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xSalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_menu,
            this.cOMPRASToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.testCargarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(148, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCompraPorClienteToolStripMenuItem,
            this.consultaDeStockToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.informesToolStripMenuItem.Text = "INFORMES";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // listadoDeCompraPorClienteToolStripMenuItem
            // 
            this.listadoDeCompraPorClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listadoDeCompraPorClienteToolStripMenuItem.Name = "listadoDeCompraPorClienteToolStripMenuItem";
            this.listadoDeCompraPorClienteToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.listadoDeCompraPorClienteToolStripMenuItem.Text = "➔ Listado de compra por Cliente";
            this.listadoDeCompraPorClienteToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCompraPorClienteToolStripMenuItem_Click);
            // 
            // consultaDeStockToolStripMenuItem
            // 
            this.consultaDeStockToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.consultaDeStockToolStripMenuItem.Name = "consultaDeStockToolStripMenuItem";
            this.consultaDeStockToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.consultaDeStockToolStripMenuItem.Text = "➔ Informacion de Stock";
            this.consultaDeStockToolStripMenuItem.Click += new System.EventHandler(this.consultaDeStockToolStripMenuItem_Click);
            // 
            // testCargarDatosToolStripMenuItem
            // 
            this.testCargarDatosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testCargarDatosToolStripMenuItem.Name = "testCargarDatosToolStripMenuItem";
            this.testCargarDatosToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.testCargarDatosToolStripMenuItem.Text = "CARGAR DATOS";
            // 
            // tsm_menu
            // 
            this.tsm_menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.altaEmpleadoToolStripMenuItem,
            this.altaProductoToolStripMenuItem,
            this.xSalirToolStripMenuItem});
            this.tsm_menu.Name = "tsm_menu";
            this.tsm_menu.Size = new System.Drawing.Size(70, 27);
            this.tsm_menu.Text = "ALTAS";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.altaClienteToolStripMenuItem.Text = "➜ Nuevo Cliente";
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaEmpleadoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.altaEmpleadoToolStripMenuItem.Text = "➜ Nuevo Empleado";
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.altaProductoToolStripMenuItem.Text = "➜ Nuevo Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // xSalirToolStripMenuItem
            // 
            this.xSalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xSalirToolStripMenuItem.Name = "xSalirToolStripMenuItem";
            this.xSalirToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.xSalirToolStripMenuItem.Text = "➜ Salir";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cOMPRASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarProductoToolStripMenuItem});
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAS";
            // 
            // comprarProductoToolStripMenuItem
            // 
            this.comprarProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            this.comprarProductoToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.comprarProductoToolStripMenuItem.Text = "➜ Comprar Producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormPrincipal.Properties.Resources.fondoPrincipal;
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCompraPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testCargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_menu;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xSalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarProductoToolStripMenuItem;
    }
}

