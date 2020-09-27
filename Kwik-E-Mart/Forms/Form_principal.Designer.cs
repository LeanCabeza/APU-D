namespace Forms
{
    partial class Form_principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCompraPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CargarDatos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsm_CargarDatos});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "BarraMenu";
            // 
            // tsm_menu
            // 
            this.tsm_menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.altaEmpleadoToolStripMenuItem,
            this.altaProductoToolStripMenuItem,
            this.tsmSalir});
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
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaEmpleadoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.altaEmpleadoToolStripMenuItem.Text = "➜ Nuevo Empleado";
            this.altaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaEmpleadoToolStripMenuItem_Click);
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.altaProductoToolStripMenuItem.Text = "➜ Nuevo Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(234, 28);
            this.tsmSalir.Text = "➜ Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
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
            this.comprarProductoToolStripMenuItem.Click += new System.EventHandler(this.comprarProductoToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCompraPorClienteToolStripMenuItem,
            this.consultaDeStockToolStripMenuItem,
            this.tsmListadoDeClientes,
            this.listadoDeEmpleadosToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.informesToolStripMenuItem.Text = "INFORMES";
            // 
            // listadoDeCompraPorClienteToolStripMenuItem
            // 
            this.listadoDeCompraPorClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listadoDeCompraPorClienteToolStripMenuItem.Name = "listadoDeCompraPorClienteToolStripMenuItem";
            this.listadoDeCompraPorClienteToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.listadoDeCompraPorClienteToolStripMenuItem.Text = "➔ Listado de compra por Cliente";
            // 
            // consultaDeStockToolStripMenuItem
            // 
            this.consultaDeStockToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.consultaDeStockToolStripMenuItem.Name = "consultaDeStockToolStripMenuItem";
            this.consultaDeStockToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.consultaDeStockToolStripMenuItem.Text = "➔ Informacion de Stock";
            this.consultaDeStockToolStripMenuItem.Click += new System.EventHandler(this.consultaDeStockToolStripMenuItem_Click);
            // 
            // tsmListadoDeClientes
            // 
            this.tsmListadoDeClientes.Name = "tsmListadoDeClientes";
            this.tsmListadoDeClientes.Size = new System.Drawing.Size(336, 28);
            this.tsmListadoDeClientes.Text = "➔ Listado de Clientes";
            this.tsmListadoDeClientes.Click += new System.EventHandler(this.tsmListadoDeClientes_Click);
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "➔ Listado de Empleados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(336, 28);
            this.listadoDeProductosToolStripMenuItem.Text = "➔ Listado de Productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // tsm_CargarDatos
            // 
            this.tsm_CargarDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_CargarDatos.Name = "tsm_CargarDatos";
            this.tsm_CargarDatos.Size = new System.Drawing.Size(147, 27);
            this.tsm_CargarDatos.Text = "CARGAR DATOS";
            this.tsm_CargarDatos.Click += new System.EventHandler(this.tsm_CargarDatos_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.formPrincipal;
            this.ClientSize = new System.Drawing.Size(627, 402);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_principal";
            this.Text = "Kwik-E-Mart - Gestiones";
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_menu;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCompraPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_CargarDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeClientes;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
    }
}