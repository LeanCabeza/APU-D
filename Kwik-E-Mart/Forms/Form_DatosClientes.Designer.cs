namespace Forms
{
    partial class Form_DatosClientes
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
            this.lb_clientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_clientes
            // 
            this.lb_clientes.FormattingEnabled = true;
            this.lb_clientes.Location = new System.Drawing.Point(44, 32);
            this.lb_clientes.Name = "lb_clientes";
            this.lb_clientes.Size = new System.Drawing.Size(743, 290);
            this.lb_clientes.TabIndex = 0;
            // 
            // Form_DatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 356);
            this.Controls.Add(this.lb_clientes);
            this.Name = "Form_DatosClientes";
            this.Text = "Form_DatosClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_clientes;
    }
}