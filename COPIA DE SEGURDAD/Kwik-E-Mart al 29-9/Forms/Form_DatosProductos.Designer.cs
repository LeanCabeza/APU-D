namespace Forms
{
    partial class Form_DatosProductos
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
            this.lb_Productos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Productos
            // 
            this.lb_Productos.FormattingEnabled = true;
            this.lb_Productos.Location = new System.Drawing.Point(38, 24);
            this.lb_Productos.Name = "lb_Productos";
            this.lb_Productos.Size = new System.Drawing.Size(714, 290);
            this.lb_Productos.TabIndex = 1;
            // 
            // Form_DatosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.lb_Productos);
            this.Name = "Form_DatosProductos";
            this.Text = "Form_DatosProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Productos;
    }
}