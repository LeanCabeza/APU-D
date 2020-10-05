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
            this.tsm_altas = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Informes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListadoDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.stockConMenosDe10UnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CargarDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_altas,
            this.tsm_Compras,
            this.tsm_Informes,
            this.tsm_CargarDatos,
            this.tsm_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "BarraMenu";
            // 
            // tsm_altas
            // 
            this.tsm_altas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_altas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.altaEmpleadoToolStripMenuItem,
            this.altaProductoToolStripMenuItem,
            this.tsmSalir});
            this.tsm_altas.Name = "tsm_altas";
            this.tsm_altas.Size = new System.Drawing.Size(70, 27);
            this.tsm_altas.Text = "ALTAS";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.altaClienteToolStripMenuItem.Text = "➜ Registrar Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaEmpleadoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.altaEmpleadoToolStripMenuItem.Text = "➜ Registrar Empleado";
            this.altaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaEmpleadoToolStripMenuItem_Click);
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.altaProductoToolStripMenuItem.Text = "➜ Agregar Nuevo Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(295, 28);
            this.tsmSalir.Text = "➜ Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsm_Compras
            // 
            this.tsm_Compras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_Compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarProductoToolStripMenuItem});
            this.tsm_Compras.Name = "tsm_Compras";
            this.tsm_Compras.Size = new System.Drawing.Size(104, 27);
            this.tsm_Compras.Text = "COMPRAS";
            this.tsm_Compras.Click += new System.EventHandler(this.cOMPRASToolStripMenuItem_Click);
            // 
            // comprarProductoToolStripMenuItem
            // 
            this.comprarProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            this.comprarProductoToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.comprarProductoToolStripMenuItem.Text = "➜ Realizar una Compra";
            this.comprarProductoToolStripMenuItem.Click += new System.EventHandler(this.comprarProductoToolStripMenuItem_Click);
            // 
            // tsm_Informes
            // 
            this.tsm_Informes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_Informes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListadoDeClientes,
            this.listadoDeEmpleadosToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem,
            this.listadoDeProductosCompras,
            this.stockConMenosDe10UnidadesToolStripMenuItem});
            this.tsm_Informes.Name = "tsm_Informes";
            this.tsm_Informes.Size = new System.Drawing.Size(108, 27);
            this.tsm_Informes.Text = "INFORMES";
            // 
            // tsmListadoDeClientes
            // 
            this.tsmListadoDeClientes.Name = "tsmListadoDeClientes";
            this.tsmListadoDeClientes.Size = new System.Drawing.Size(363, 28);
            this.tsmListadoDeClientes.Text = "➔ Clientes Registrados";
            this.tsmListadoDeClientes.Click += new System.EventHandler(this.tsmListadoDeClientes_Click);
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(363, 28);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "➔ Empleados Registrados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(363, 28);
            this.listadoDeProductosToolStripMenuItem.Text = "➔ Informacion de Stock";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // listadoDeProductosCompras
            // 
            this.listadoDeProductosCompras.Name = "listadoDeProductosCompras";
            this.listadoDeProductosCompras.Size = new System.Drawing.Size(363, 28);
            this.listadoDeProductosCompras.Text = "➔ Compras de clientes / empleados";
            this.listadoDeProductosCompras.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem1_Click);
            // 
            // stockConMenosDe10UnidadesToolStripMenuItem
            // 
            this.stockConMenosDe10UnidadesToolStripMenuItem.Name = "stockConMenosDe10UnidadesToolStripMenuItem";
            this.stockConMenosDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(363, 28);
            this.stockConMenosDe10UnidadesToolStripMenuItem.Text = "➔ Stock con menos de 10 unidades";
            this.stockConMenosDe10UnidadesToolStripMenuItem.Click += new System.EventHandler(this.stockConMenosDe10UnidadesToolStripMenuItem_Click);
            // 
            // tsm_CargarDatos
            // 
            this.tsm_CargarDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_CargarDatos.Name = "tsm_CargarDatos";
            this.tsm_CargarDatos.Size = new System.Drawing.Size(147, 27);
            this.tsm_CargarDatos.Text = "CARGAR DATOS";
            this.tsm_CargarDatos.Click += new System.EventHandler(this.tsm_CargarDatos_Click);
            // 
            // tsm_Salir
            // 
            this.tsm_Salir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_Salir.Name = "tsm_Salir";
            this.tsm_Salir.Size = new System.Drawing.Size(67, 27);
            this.tsm_Salir.Text = "SALIR";
            this.tsm_Salir.Click += new System.EventHandler(this.tsm_Salir_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.formPrincipal;
            this.ClientSize = new System.Drawing.Size(635, 402);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_principal";
            this.Text = "Kwik-E-Mart - Cabeza Leandro 2ºD";
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_altas;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsm_Compras;
        private System.Windows.Forms.ToolStripMenuItem comprarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Informes;
        private System.Windows.Forms.ToolStripMenuItem tsm_CargarDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeClientes;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosCompras;
        private System.Windows.Forms.ToolStripMenuItem tsm_Salir;
        private System.Windows.Forms.ToolStripMenuItem stockConMenosDe10UnidadesToolStripMenuItem;
    }
}