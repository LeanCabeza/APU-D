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
            this.pb_banner = new System.Windows.Forms.PictureBox();
            this.picture_apu = new System.Windows.Forms.PictureBox();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.btn_salirr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_apu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_altas,
            this.tsm_Compras,
            this.tsm_Informes});
            this.menuStrip1.Location = new System.Drawing.Point(318, 133);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 32);
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
            this.tsm_altas.Size = new System.Drawing.Size(70, 28);
            this.tsm_altas.Text = "ALTAS";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.altaClienteToolStripMenuItem.Text = "➜ Registrar Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaEmpleadoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.altaEmpleadoToolStripMenuItem.Text = "➜ Registrar Empleado";
            this.altaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaEmpleadoToolStripMenuItem_Click);
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(306, 28);
            this.altaProductoToolStripMenuItem.Text = "➜ Agregar Nuevo Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(306, 28);
            this.tsmSalir.Text = "➜ Salir";
            // 
            // tsm_Compras
            // 
            this.tsm_Compras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsm_Compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarProductoToolStripMenuItem});
            this.tsm_Compras.Name = "tsm_Compras";
            this.tsm_Compras.Size = new System.Drawing.Size(107, 28);
            this.tsm_Compras.Text = "COMPRAS";
            // 
            // comprarProductoToolStripMenuItem
            // 
            this.comprarProductoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            this.comprarProductoToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
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
            this.tsm_Informes.Size = new System.Drawing.Size(110, 28);
            this.tsm_Informes.Text = "INFORMES";
            // 
            // tsmListadoDeClientes
            // 
            this.tsmListadoDeClientes.Name = "tsmListadoDeClientes";
            this.tsmListadoDeClientes.Size = new System.Drawing.Size(381, 28);
            this.tsmListadoDeClientes.Text = "➔ Clientes Registrados";
            this.tsmListadoDeClientes.Click += new System.EventHandler(this.tsmListadoDeClientes_Click);
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(381, 28);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "➔ Empleados Registrados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(381, 28);
            this.listadoDeProductosToolStripMenuItem.Text = "➔ Informacion de Stock";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // listadoDeProductosCompras
            // 
            this.listadoDeProductosCompras.Name = "listadoDeProductosCompras";
            this.listadoDeProductosCompras.Size = new System.Drawing.Size(381, 28);
            this.listadoDeProductosCompras.Text = "➔ Compras de clientes / empleados";
            this.listadoDeProductosCompras.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem1_Click);
            // 
            // stockConMenosDe10UnidadesToolStripMenuItem
            // 
            this.stockConMenosDe10UnidadesToolStripMenuItem.Name = "stockConMenosDe10UnidadesToolStripMenuItem";
            this.stockConMenosDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(381, 28);
            this.stockConMenosDe10UnidadesToolStripMenuItem.Text = "➔ Stock con menos de 10 unidades";
            this.stockConMenosDe10UnidadesToolStripMenuItem.Click += new System.EventHandler(this.stockConMenosDe10UnidadesToolStripMenuItem_Click);
            // 
            // pb_banner
            // 
            this.pb_banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_banner.Location = new System.Drawing.Point(1, 0);
            this.pb_banner.Name = "pb_banner";
            this.pb_banner.Size = new System.Drawing.Size(835, 90);
            this.pb_banner.TabIndex = 100;
            this.pb_banner.TabStop = false;
            // 
            // picture_apu
            // 
            this.picture_apu.BackgroundImage = global::Forms.Properties.Resources.apu;
            this.picture_apu.Location = new System.Drawing.Point(1, 96);
            this.picture_apu.Name = "picture_apu";
            this.picture_apu.Size = new System.Drawing.Size(222, 429);
            this.picture_apu.TabIndex = 101;
            this.picture_apu.TabStop = false;
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenido.Location = new System.Drawing.Point(299, 259);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(364, 36);
            this.lbl_bienvenido.TabIndex = 102;
            this.lbl_bienvenido.Text = "Bienvenido al Kwik-E-Mart !! ";
            // 
            // btn_salirr
            // 
            this.btn_salirr.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salirr.Location = new System.Drawing.Point(370, 406);
            this.btn_salirr.Name = "btn_salirr";
            this.btn_salirr.Size = new System.Drawing.Size(220, 45);
            this.btn_salirr.TabIndex = 103;
            this.btn_salirr.Text = "Salir";
            this.btn_salirr.UseVisualStyleBackColor = true;
            this.btn_salirr.Click += new System.EventHandler(this.btn_salirr_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.btn_salirr);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.picture_apu);
            this.Controls.Add(this.pb_banner);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_principal";
            this.Text = "Kwik-E-Mart - Cabeza Leandro 2ºD";
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_apu)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem tsmListadoDeClientes;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosCompras;
        private System.Windows.Forms.ToolStripMenuItem stockConMenosDe10UnidadesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_banner;
        private System.Windows.Forms.PictureBox picture_apu;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.Button btn_salirr;
    }
}