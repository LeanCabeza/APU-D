namespace Forms
{
    partial class Form_Compra
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
            this.components = new System.ComponentModel.Container();
            this.listbox_Productos = new System.Windows.Forms.ListBox();
            this.listbox_Compra = new System.Windows.Forms.ListBox();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.btn_AgregarCompra = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.lbl_Empleaedo = new System.Windows.Forms.Label();
            this.txtbox_precioactualizado = new System.Windows.Forms.TextBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cmb_Empleados = new System.Windows.Forms.ComboBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_dona = new System.Windows.Forms.PictureBox();
            this.pb_banner = new System.Windows.Forms.PictureBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_Productos
            // 
            this.listbox_Productos.Font = new System.Drawing.Font("Calibri", 8F);
            this.listbox_Productos.FormattingEnabled = true;
            this.listbox_Productos.Location = new System.Drawing.Point(28, 244);
            this.listbox_Productos.Name = "listbox_Productos";
            this.listbox_Productos.ScrollAlwaysVisible = true;
            this.listbox_Productos.Size = new System.Drawing.Size(465, 316);
            this.listbox_Productos.TabIndex = 2;
            this.listbox_Productos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Productos_MouseDown);
            // 
            // listbox_Compra
            // 
            this.listbox_Compra.AllowDrop = true;
            this.listbox_Compra.Font = new System.Drawing.Font("Calibri", 8F);
            this.listbox_Compra.FormattingEnabled = true;
            this.listbox_Compra.Location = new System.Drawing.Point(523, 244);
            this.listbox_Compra.Name = "listbox_Compra";
            this.listbox_Compra.ScrollAlwaysVisible = true;
            this.listbox_Compra.Size = new System.Drawing.Size(465, 316);
            this.listbox_Compra.TabIndex = 3;
            this.listbox_Compra.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragDrop);
            this.listbox_Compra.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragEnter);
            this.listbox_Compra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Compra_MouseDoubleClick);
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Productos.Location = new System.Drawing.Point(166, 200);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(153, 23);
            this.lbl_Productos.TabIndex = 34;
            this.lbl_Productos.Text = "Lista de Productos";
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra.Location = new System.Drawing.Point(621, 200);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(244, 23);
            this.lbl_Compra.TabIndex = 35;
            this.lbl_Compra.Text = "Compras (Arrastre productos)";
            // 
            // btn_AgregarCompra
            // 
            this.btn_AgregarCompra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCompra.Location = new System.Drawing.Point(823, 606);
            this.btn_AgregarCompra.Name = "btn_AgregarCompra";
            this.btn_AgregarCompra.Size = new System.Drawing.Size(172, 50);
            this.btn_AgregarCompra.TabIndex = 65;
            this.btn_AgregarCompra.Text = "Finalizar Compra";
            this.btn_AgregarCompra.UseVisualStyleBackColor = true;
            this.btn_AgregarCompra.Click += new System.EventHandler(this.btn_AgregarCompra_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Total.Location = new System.Drawing.Point(378, 610);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(145, 33);
            this.lbl_Total.TabIndex = 66;
            this.lbl_Total.Text = "Precio Total";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Precio.Location = new System.Drawing.Point(517, 610);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(29, 33);
            this.lbl_Precio.TabIndex = 69;
            this.lbl_Precio.Text = "$";
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion.Location = new System.Drawing.Point(352, 99);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(372, 18);
            this.lbl_informacion.TabIndex = 81;
            this.lbl_informacion.Text = "( Si no esta registrado lo podes dar de alta en el inicio ) ";
            // 
            // lbl_Empleaedo
            // 
            this.lbl_Empleaedo.AutoSize = true;
            this.lbl_Empleaedo.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empleaedo.Location = new System.Drawing.Point(25, 128);
            this.lbl_Empleaedo.Name = "lbl_Empleaedo";
            this.lbl_Empleaedo.Size = new System.Drawing.Size(95, 23);
            this.lbl_Empleaedo.TabIndex = 75;
            this.lbl_Empleaedo.Text = "Empleados";
            // 
            // txtbox_precioactualizado
            // 
            this.txtbox_precioactualizado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_precioactualizado.Location = new System.Drawing.Point(552, 613);
            this.txtbox_precioactualizado.Name = "txtbox_precioactualizado";
            this.txtbox_precioactualizado.Size = new System.Drawing.Size(100, 33);
            this.txtbox_precioactualizado.TabIndex = 87;
            this.txtbox_precioactualizado.TextChanged += new System.EventHandler(this.txtbox_precioactualizado_TextChanged);
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(25, 162);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(165, 18);
            this.lbl_empleado.TabIndex = 77;
            this.lbl_empleado.Text = "Seleccione el empleado";
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Empleados.Enabled = false;
            this.cmb_Empleados.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(196, 159);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.Size = new System.Drawing.Size(278, 22);
            this.cmb_Empleados.TabIndex = 90;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(622, 223);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(257, 18);
            this.lbl_info.TabIndex = 93;
            this.lbl_info.Text = "( Con doble click lo sacas de la lista ) ";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(898, 92);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 34);
            this.btn_salir.TabIndex = 94;
            this.btn_salir.Text = "Volver al menu ";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clientes.Enabled = false;
            this.cmb_Clientes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(676, 156);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(319, 22);
            this.cmb_Clientes.TabIndex = 92;
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(524, 128);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(72, 23);
            this.lbl_Clientes.TabIndex = 33;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Seleccione el Cliente";
            // 
            // pb_dona
            // 
            this.pb_dona.Image = global::Forms.Properties.Resources.dona;
            this.pb_dona.Location = new System.Drawing.Point(46, 566);
            this.pb_dona.Name = "pb_dona";
            this.pb_dona.Size = new System.Drawing.Size(273, 159);
            this.pb_dona.TabIndex = 100;
            this.pb_dona.TabStop = false;
            // 
            // pb_banner
            // 
            this.pb_banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_banner.Location = new System.Drawing.Point(-7, -4);
            this.pb_banner.Name = "pb_banner";
            this.pb_banner.Size = new System.Drawing.Size(1036, 90);
            this.pb_banner.TabIndex = 99;
            this.pb_banner.TabStop = false;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(493, 586);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(0, 15);
            this.lbl_Descuento.TabIndex = 101;
            // 
            // Form_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1029, 697);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.pb_dona);
            this.Controls.Add(this.pb_banner);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Empleados);
            this.Controls.Add(this.txtbox_precioactualizado);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.lbl_Empleaedo);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_AgregarCompra);
            this.Controls.Add(this.lbl_Compra);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.listbox_Compra);
            this.Controls.Add(this.listbox_Productos);
            this.Name = "Form_Compra";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Form_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listbox_Productos;
        private System.Windows.Forms.ListBox listbox_Compra;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Button btn_AgregarCompra;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Precio;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.Label lbl_Empleaedo;
        private System.Windows.Forms.TextBox txtbox_precioactualizado;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.ComboBox cmb_Empleados;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pb_banner;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_dona;
        private System.Windows.Forms.Label lbl_Descuento;
    }
}