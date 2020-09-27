namespace Forms
{
    partial class Form_altoProducto
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
            this.tb_idProd = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_NombreProd = new System.Windows.Forms.TextBox();
            this.lbl_idProducto = new System.Windows.Forms.Label();
            this.lbl_stockProducto = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_marcaProducto = new System.Windows.Forms.Label();
            this.lbl_nombreProducto = new System.Windows.Forms.Label();
            this.btn_aceptarEmpleado = new System.Windows.Forms.Button();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_idProd
            // 
            this.tb_idProd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idProd.Location = new System.Drawing.Point(247, 256);
            this.tb_idProd.Name = "tb_idProd";
            this.tb_idProd.Size = new System.Drawing.Size(175, 26);
            this.tb_idProd.TabIndex = 43;
            // 
            // tb_stock
            // 
            this.tb_stock.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(247, 223);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(175, 26);
            this.tb_stock.TabIndex = 42;
            // 
            // tb_precio
            // 
            this.tb_precio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precio.Location = new System.Drawing.Point(247, 149);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(175, 26);
            this.tb_precio.TabIndex = 40;
            // 
            // tb_marca
            // 
            this.tb_marca.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_marca.Location = new System.Drawing.Point(247, 115);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(175, 26);
            this.tb_marca.TabIndex = 39;
            // 
            // tb_NombreProd
            // 
            this.tb_NombreProd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NombreProd.Location = new System.Drawing.Point(247, 80);
            this.tb_NombreProd.Name = "tb_NombreProd";
            this.tb_NombreProd.Size = new System.Drawing.Size(175, 26);
            this.tb_NombreProd.TabIndex = 38;
            // 
            // lbl_idProducto
            // 
            this.lbl_idProducto.AutoSize = true;
            this.lbl_idProducto.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idProducto.Location = new System.Drawing.Point(112, 259);
            this.lbl_idProducto.Name = "lbl_idProducto";
            this.lbl_idProducto.Size = new System.Drawing.Size(103, 23);
            this.lbl_idProducto.TabIndex = 37;
            this.lbl_idProducto.Text = "ID Producto";
            // 
            // lbl_stockProducto
            // 
            this.lbl_stockProducto.AutoSize = true;
            this.lbl_stockProducto.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockProducto.Location = new System.Drawing.Point(130, 222);
            this.lbl_stockProducto.Name = "lbl_stockProducto";
            this.lbl_stockProducto.Size = new System.Drawing.Size(53, 23);
            this.lbl_stockProducto.TabIndex = 36;
            this.lbl_stockProducto.Text = "Stock";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(130, 152);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(59, 23);
            this.lbl_precio.TabIndex = 34;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_marcaProducto
            // 
            this.lbl_marcaProducto.AutoSize = true;
            this.lbl_marcaProducto.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marcaProducto.Location = new System.Drawing.Point(129, 118);
            this.lbl_marcaProducto.Name = "lbl_marcaProducto";
            this.lbl_marcaProducto.Size = new System.Drawing.Size(60, 23);
            this.lbl_marcaProducto.TabIndex = 33;
            this.lbl_marcaProducto.Text = "marca";
            // 
            // lbl_nombreProducto
            // 
            this.lbl_nombreProducto.AutoSize = true;
            this.lbl_nombreProducto.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreProducto.Location = new System.Drawing.Point(82, 83);
            this.lbl_nombreProducto.Name = "lbl_nombreProducto";
            this.lbl_nombreProducto.Size = new System.Drawing.Size(149, 23);
            this.lbl_nombreProducto.TabIndex = 32;
            this.lbl_nombreProducto.Text = "Nombre Producto";
            // 
            // btn_aceptarEmpleado
            // 
            this.btn_aceptarEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarEmpleado.Location = new System.Drawing.Point(247, 325);
            this.btn_aceptarEmpleado.Name = "btn_aceptarEmpleado";
            this.btn_aceptarEmpleado.Size = new System.Drawing.Size(118, 31);
            this.btn_aceptarEmpleado.TabIndex = 64;
            this.btn_aceptarEmpleado.Text = "Aceptar";
            this.btn_aceptarEmpleado.UseVisualStyleBackColor = true;
            this.btn_aceptarEmpleado.Click += new System.EventHandler(this.btn_aceptarEmpleado_Click);
            // 
            // tb_peso
            // 
            this.tb_peso.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_peso.Location = new System.Drawing.Point(247, 186);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(175, 26);
            this.tb_peso.TabIndex = 66;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(130, 189);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(46, 23);
            this.lbl_peso.TabIndex = 65;
            this.lbl_peso.Text = "Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_altoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.btn_aceptarEmpleado);
            this.Controls.Add(this.tb_idProd);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_NombreProd);
            this.Controls.Add(this.lbl_idProducto);
            this.Controls.Add(this.lbl_stockProducto);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_marcaProducto);
            this.Controls.Add(this.lbl_nombreProducto);
            this.Name = "Form_altoProducto";
            this.Text = "Form_altoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_idProd;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_NombreProd;
        private System.Windows.Forms.Label lbl_idProducto;
        private System.Windows.Forms.Label lbl_stockProducto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_marcaProducto;
        private System.Windows.Forms.Label lbl_nombreProducto;
        private System.Windows.Forms.Button btn_aceptarEmpleado;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Label lbl_peso;
    }
}