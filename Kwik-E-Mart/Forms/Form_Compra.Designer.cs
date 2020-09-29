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
            this.lb_Productos = new System.Windows.Forms.ListBox();
            this.lb_Compra = new System.Windows.Forms.ListBox();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.btn_aceptarEmpleado = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_AltaProducto = new System.Windows.Forms.Button();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Empleados = new System.Windows.Forms.ListBox();
            this.btn_BuscarEmpleado = new System.Windows.Forms.Button();
            this.tb_dniEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AltaEmpleado = new System.Windows.Forms.Button();
            this.lbl_Empleaedo = new System.Windows.Forms.Label();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.btn_altaCliente = new System.Windows.Forms.Button();
            this.lblIngreseApellido = new System.Windows.Forms.Label();
            this.lstbox_Cliente = new System.Windows.Forms.ListBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.tb_dniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_VerEmpleado = new System.Windows.Forms.Button();
            this.btn_VerClientes = new System.Windows.Forms.Button();
            this.label_gestor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_precioactualizado = new System.Windows.Forms.TextBox();
            this.txtbox_Empleado = new System.Windows.Forms.TextBox();
            this.txtbox_Cliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Productos
            // 
            this.lb_Productos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Productos.FormattingEnabled = true;
            this.lb_Productos.ItemHeight = 15;
            this.lb_Productos.Location = new System.Drawing.Point(715, 96);
            this.lb_Productos.Name = "lb_Productos";
            this.lb_Productos.ScrollAlwaysVisible = true;
            this.lb_Productos.Size = new System.Drawing.Size(373, 424);
            this.lb_Productos.TabIndex = 2;
            this.lb_Productos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Productos_MouseDown);
            // 
            // lb_Compra
            // 
            this.lb_Compra.AllowDrop = true;
            this.lb_Compra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Compra.FormattingEnabled = true;
            this.lb_Compra.ItemHeight = 19;
            this.lb_Compra.Location = new System.Drawing.Point(1124, 96);
            this.lb_Compra.Name = "lb_Compra";
            this.lb_Compra.ScrollAlwaysVisible = true;
            this.lb_Compra.Size = new System.Drawing.Size(274, 422);
            this.lb_Compra.TabIndex = 3;
            this.lb_Compra.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragDrop);
            this.lb_Compra.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragEnter);
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Productos.Location = new System.Drawing.Point(792, 19);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(153, 23);
            this.lbl_Productos.TabIndex = 34;
            this.lbl_Productos.Text = "Lista de Productos";
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra.Location = new System.Drawing.Point(1097, 9);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(244, 23);
            this.lbl_Compra.TabIndex = 35;
            this.lbl_Compra.Text = "Compras (Arrastre productos)";
            // 
            // btn_aceptarEmpleado
            // 
            this.btn_aceptarEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarEmpleado.Location = new System.Drawing.Point(1247, 588);
            this.btn_aceptarEmpleado.Name = "btn_aceptarEmpleado";
            this.btn_aceptarEmpleado.Size = new System.Drawing.Size(172, 50);
            this.btn_aceptarEmpleado.TabIndex = 65;
            this.btn_aceptarEmpleado.Text = "Finalizar Compra";
            this.btn_aceptarEmpleado.UseVisualStyleBackColor = true;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Total.Location = new System.Drawing.Point(733, 588);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(145, 33);
            this.lbl_Total.TabIndex = 66;
            this.lbl_Total.Text = "Precio Total";
            // 
            // btn_AltaProducto
            // 
            this.btn_AltaProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AltaProducto.Location = new System.Drawing.Point(813, 53);
            this.btn_AltaProducto.Name = "btn_AltaProducto";
            this.btn_AltaProducto.Size = new System.Drawing.Size(118, 31);
            this.btn_AltaProducto.TabIndex = 68;
            this.btn_AltaProducto.Text = "Alta Producto";
            this.btn_AltaProducto.UseVisualStyleBackColor = true;
            this.btn_AltaProducto.Click += new System.EventHandler(this.btn_AltaProducto_Click);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Precio.Location = new System.Drawing.Point(902, 588);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(29, 33);
            this.lbl_Precio.TabIndex = 69;
            this.lbl_Precio.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "( Si no esta registrado el empleado lo podes dar de alta ) ";
            // 
            // listBox_Empleados
            // 
            this.listBox_Empleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Empleados.FormattingEnabled = true;
            this.listBox_Empleados.ItemHeight = 18;
            this.listBox_Empleados.Location = new System.Drawing.Point(262, 122);
            this.listBox_Empleados.Name = "listBox_Empleados";
            this.listBox_Empleados.Size = new System.Drawing.Size(412, 40);
            this.listBox_Empleados.TabIndex = 80;
            this.listBox_Empleados.DoubleClick += new System.EventHandler(this.listBox_Empleados_DoubleClick);
            // 
            // btn_BuscarEmpleado
            // 
            this.btn_BuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarEmpleado.Location = new System.Drawing.Point(519, 83);
            this.btn_BuscarEmpleado.Name = "btn_BuscarEmpleado";
            this.btn_BuscarEmpleado.Size = new System.Drawing.Size(155, 33);
            this.btn_BuscarEmpleado.TabIndex = 79;
            this.btn_BuscarEmpleado.Text = "Buscar";
            this.btn_BuscarEmpleado.UseVisualStyleBackColor = true;
            this.btn_BuscarEmpleado.Click += new System.EventHandler(this.btn_BuscarEmpleado_Click);
            // 
            // tb_dniEmpleado
            // 
            this.tb_dniEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dniEmpleado.Location = new System.Drawing.Point(258, 87);
            this.tb_dniEmpleado.Name = "tb_dniEmpleado";
            this.tb_dniEmpleado.Size = new System.Drawing.Size(231, 24);
            this.tb_dniEmpleado.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Ingrese el Dni Del Empleado";
            // 
            // btn_AltaEmpleado
            // 
            this.btn_AltaEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AltaEmpleado.Location = new System.Drawing.Point(324, 201);
            this.btn_AltaEmpleado.Name = "btn_AltaEmpleado";
            this.btn_AltaEmpleado.Size = new System.Drawing.Size(118, 31);
            this.btn_AltaEmpleado.TabIndex = 76;
            this.btn_AltaEmpleado.Text = "Alta Empleado";
            this.btn_AltaEmpleado.UseVisualStyleBackColor = true;
            this.btn_AltaEmpleado.Click += new System.EventHandler(this.btn_AltaEmpleado_Click);
            // 
            // lbl_Empleaedo
            // 
            this.lbl_Empleaedo.AutoSize = true;
            this.lbl_Empleaedo.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empleaedo.Location = new System.Drawing.Point(55, 47);
            this.lbl_Empleaedo.Name = "lbl_Empleaedo";
            this.lbl_Empleaedo.Size = new System.Drawing.Size(95, 23);
            this.lbl_Empleaedo.TabIndex = 75;
            this.lbl_Empleaedo.Text = "Empleados";
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(55, 279);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(72, 23);
            this.lbl_Clientes.TabIndex = 33;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // btn_altaCliente
            // 
            this.btn_altaCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaCliente.Location = new System.Drawing.Point(324, 448);
            this.btn_altaCliente.Name = "btn_altaCliente";
            this.btn_altaCliente.Size = new System.Drawing.Size(118, 31);
            this.btn_altaCliente.TabIndex = 67;
            this.btn_altaCliente.Text = "Alta Cliente";
            this.btn_altaCliente.UseVisualStyleBackColor = true;
            this.btn_altaCliente.Click += new System.EventHandler(this.btn_altaCliente_Click);
            // 
            // lblIngreseApellido
            // 
            this.lblIngreseApellido.AutoSize = true;
            this.lblIngreseApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseApellido.Location = new System.Drawing.Point(56, 317);
            this.lblIngreseApellido.Name = "lblIngreseApellido";
            this.lblIngreseApellido.Size = new System.Drawing.Size(172, 18);
            this.lblIngreseApellido.TabIndex = 70;
            this.lblIngreseApellido.Text = "Ingrese el Dni Del Cliente";
            // 
            // lstbox_Cliente
            // 
            this.lstbox_Cliente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_Cliente.FormattingEnabled = true;
            this.lstbox_Cliente.ItemHeight = 18;
            this.lstbox_Cliente.Location = new System.Drawing.Point(249, 357);
            this.lstbox_Cliente.Name = "lstbox_Cliente";
            this.lstbox_Cliente.Size = new System.Drawing.Size(412, 58);
            this.lstbox_Cliente.TabIndex = 73;
            this.lstbox_Cliente.DoubleClick += new System.EventHandler(this.lstbox_Cliente_DoubleClick);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCliente.Location = new System.Drawing.Point(506, 308);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(155, 33);
            this.btn_BuscarCliente.TabIndex = 72;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // tb_dniCliente
            // 
            this.tb_dniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dniCliente.Location = new System.Drawing.Point(249, 311);
            this.tb_dniCliente.Name = "tb_dniCliente";
            this.tb_dniCliente.Size = new System.Drawing.Size(231, 24);
            this.tb_dniCliente.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 18);
            this.label3.TabIndex = 82;
            this.label3.Text = "( Si no esta registrado el cliente  lo podes dar de alta ) ";
            // 
            // btn_VerEmpleado
            // 
            this.btn_VerEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerEmpleado.Location = new System.Drawing.Point(462, 201);
            this.btn_VerEmpleado.Name = "btn_VerEmpleado";
            this.btn_VerEmpleado.Size = new System.Drawing.Size(118, 31);
            this.btn_VerEmpleado.TabIndex = 83;
            this.btn_VerEmpleado.Text = "Ver Empleados";
            this.btn_VerEmpleado.UseVisualStyleBackColor = true;
            this.btn_VerEmpleado.Click += new System.EventHandler(this.btn_VerEmpleado_Click);
            // 
            // btn_VerClientes
            // 
            this.btn_VerClientes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerClientes.Location = new System.Drawing.Point(462, 448);
            this.btn_VerClientes.Name = "btn_VerClientes";
            this.btn_VerClientes.Size = new System.Drawing.Size(118, 31);
            this.btn_VerClientes.TabIndex = 84;
            this.btn_VerClientes.Text = "Ver Clientes";
            this.btn_VerClientes.UseVisualStyleBackColor = true;
            this.btn_VerClientes.Click += new System.EventHandler(this.btn_VerClientes_Click);
            // 
            // label_gestor
            // 
            this.label_gestor.AutoSize = true;
            this.label_gestor.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gestor.Location = new System.Drawing.Point(1097, 48);
            this.label_gestor.Name = "label_gestor";
            this.label_gestor.Size = new System.Drawing.Size(107, 23);
            this.label_gestor.TabIndex = 85;
            this.label_gestor.Text = "Empleado ->\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1120, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 86;
            this.label4.Text = "Cliente ->";
            // 
            // txtbox_precioactualizado
            // 
            this.txtbox_precioactualizado.Location = new System.Drawing.Point(937, 588);
            this.txtbox_precioactualizado.Name = "txtbox_precioactualizado";
            this.txtbox_precioactualizado.Size = new System.Drawing.Size(100, 20);
            this.txtbox_precioactualizado.TabIndex = 87;
            // 
            // txtbox_Empleado
            // 
            this.txtbox_Empleado.Location = new System.Drawing.Point(1210, 51);
            this.txtbox_Empleado.Name = "txtbox_Empleado";
            this.txtbox_Empleado.Size = new System.Drawing.Size(188, 20);
            this.txtbox_Empleado.TabIndex = 88;
            // 
            // txtbox_Cliente
            // 
            this.txtbox_Cliente.Location = new System.Drawing.Point(1210, 73);
            this.txtbox_Cliente.Name = "txtbox_Cliente";
            this.txtbox_Cliente.Size = new System.Drawing.Size(188, 20);
            this.txtbox_Cliente.TabIndex = 89;
            // 
            // Form_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 715);
            this.Controls.Add(this.txtbox_Cliente);
            this.Controls.Add(this.txtbox_Empleado);
            this.Controls.Add(this.txtbox_precioactualizado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_gestor);
            this.Controls.Add(this.btn_VerClientes);
            this.Controls.Add(this.btn_VerEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Empleados);
            this.Controls.Add(this.btn_BuscarEmpleado);
            this.Controls.Add(this.tb_dniEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AltaEmpleado);
            this.Controls.Add(this.lbl_Empleaedo);
            this.Controls.Add(this.lstbox_Cliente);
            this.Controls.Add(this.btn_BuscarCliente);
            this.Controls.Add(this.tb_dniCliente);
            this.Controls.Add(this.lblIngreseApellido);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.btn_AltaProducto);
            this.Controls.Add(this.btn_altaCliente);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_aceptarEmpleado);
            this.Controls.Add(this.lbl_Compra);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.lb_Compra);
            this.Controls.Add(this.lb_Productos);
            this.Name = "Form_Compra";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Form_Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_Productos;
        private System.Windows.Forms.ListBox lb_Compra;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Button btn_aceptarEmpleado;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_AltaProducto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Empleados;
        private System.Windows.Forms.Button btn_BuscarEmpleado;
        private System.Windows.Forms.TextBox tb_dniEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AltaEmpleado;
        private System.Windows.Forms.Label lbl_Empleaedo;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Button btn_altaCliente;
        private System.Windows.Forms.Label lblIngreseApellido;
        private System.Windows.Forms.ListBox lstbox_Cliente;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.TextBox tb_dniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_VerEmpleado;
        private System.Windows.Forms.Button btn_VerClientes;
        private System.Windows.Forms.Label label_gestor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_precioactualizado;
        private System.Windows.Forms.TextBox txtbox_Empleado;
        private System.Windows.Forms.TextBox txtbox_Cliente;
    }
}