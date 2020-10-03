namespace Forms
{
    partial class Form_DatosCompra
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
            this.listbox_Compras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbox_Compras
            // 
            this.listbox_Compras.FormattingEnabled = true;
            this.listbox_Compras.Location = new System.Drawing.Point(32, 27);
            this.listbox_Compras.Name = "listbox_Compras";
            this.listbox_Compras.Size = new System.Drawing.Size(887, 290);
            this.listbox_Compras.TabIndex = 2;
            this.listbox_Compras.SelectedIndexChanged += new System.EventHandler(this.listbox_Compras_SelectedIndexChanged);
            // 
            // Form_DatosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 394);
            this.Controls.Add(this.listbox_Compras);
            this.Name = "Form_DatosCompra";
            this.Text = "Form_DatosCompra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_Compras;
    }
}