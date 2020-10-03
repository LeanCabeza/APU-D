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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Empleaedo = new System.Windows.Forms.Label();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_precioactualizado = new System.Windows.Forms.TextBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cmb_Empleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_Productos
            // 
            this.listbox_Productos.Font = new System.Drawing.Font("Calibri", 10F);
            this.listbox_Productos.FormattingEnabled = true;
            this.listbox_Productos.ItemHeight = 15;
            this.listbox_Productos.Location = new System.Drawing.Point(59, 191);
            this.listbox_Productos.Name = "listbox_Productos";
            this.listbox_Productos.ScrollAlwaysVisible = true;
            this.listbox_Productos.Size = new System.Drawing.Size(539, 319);
            this.listbox_Productos.TabIndex = 2;
            this.listbox_Productos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Productos_MouseDown);
            // 
            // listbox_Compra
            // 
            this.listbox_Compra.AllowDrop = true;
            this.listbox_Compra.Font = new System.Drawing.Font("Calibri", 10F);
            this.listbox_Compra.FormattingEnabled = true;
            this.listbox_Compra.ItemHeight = 15;
            this.listbox_Compra.Location = new System.Drawing.Point(677, 190);
            this.listbox_Compra.Name = "listbox_Compra";
            this.listbox_Compra.ScrollAlwaysVisible = true;
            this.listbox_Compra.Size = new System.Drawing.Size(527, 319);
            this.listbox_Compra.TabIndex = 3;
            this.listbox_Compra.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragDrop);
            this.listbox_Compra.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Compra_DragEnter);
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Productos.Location = new System.Drawing.Point(261, 152);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(153, 23);
            this.lbl_Productos.TabIndex = 34;
            this.lbl_Productos.Text = "Lista de Productos";
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra.Location = new System.Drawing.Point(804, 152);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(244, 23);
            this.lbl_Compra.TabIndex = 35;
            this.lbl_Compra.Text = "Compras (Arrastre productos)";
            // 
            // btn_AgregarCompra
            // 
            this.btn_AgregarCompra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCompra.Location = new System.Drawing.Point(1101, 562);
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
            this.lbl_Total.Location = new System.Drawing.Point(453, 566);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(145, 33);
            this.lbl_Total.TabIndex = 66;
            this.lbl_Total.Text = "Precio Total";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Precio.Location = new System.Drawing.Point(613, 566);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(29, 33);
            this.lbl_Precio.TabIndex = 69;
            this.lbl_Precio.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "( Si no esta registrado el empleado lo podes dar de alta ) ";
            // 
            // lbl_Empleaedo
            // 
            this.lbl_Empleaedo.AutoSize = true;
            this.lbl_Empleaedo.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empleaedo.Location = new System.Drawing.Point(55, 23);
            this.lbl_Empleaedo.Name = "lbl_Empleaedo";
            this.lbl_Empleaedo.Size = new System.Drawing.Size(95, 23);
            this.lbl_Empleaedo.TabIndex = 75;
            this.lbl_Empleaedo.Text = "Empleados";
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(661, 23);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(72, 23);
            this.lbl_Clientes.TabIndex = 33;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 18);
            this.label3.TabIndex = 82;
            this.label3.Text = "( Si no esta registrado el cliente  lo podes dar de alta ) ";
            // 
            // txtbox_precioactualizado
            // 
            this.txtbox_precioactualizado.Location = new System.Drawing.Point(648, 578);
            this.txtbox_precioactualizado.Name = "txtbox_precioactualizado";
            this.txtbox_precioactualizado.Size = new System.Drawing.Size(100, 20);
            this.txtbox_precioactualizado.TabIndex = 87;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(33, 71);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(165, 18);
            this.lbl_empleado.TabIndex = 77;
            this.lbl_empleado.Text = "Seleccione el empleado";
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Empleados.Enabled = false;
            this.cmb_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(204, 68);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.Size = new System.Drawing.Size(403, 26);
            this.cmb_Empleados.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Seleccione el Cliente";
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clientes.Enabled = false;
            this.cmb_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(825, 68);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(403, 26);
            this.cmb_Clientes.TabIndex = 92;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(909, 562);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(172, 50);
            this.btn_calcular.TabIndex = 93;
            this.btn_calcular.Text = "Calcular Total";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 631);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Empleados);
            this.Controls.Add(this.txtbox_precioactualizado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Empleaedo;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_precioactualizado;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.ComboBox cmb_Empleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Button btn_calcular;
    }
}