namespace Forms
{
    partial class Form_DatosEmpleados
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
            this.lb_Empleado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_Empleado
            // 
            this.lb_Empleado.FormattingEnabled = true;
            this.lb_Empleado.Location = new System.Drawing.Point(32, 34);
            this.lb_Empleado.Name = "lb_Empleado";
            this.lb_Empleado.Size = new System.Drawing.Size(719, 290);
            this.lb_Empleado.TabIndex = 1;
            // 
            // Form_DatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.lb_Empleado);
            this.Name = "Form_DatosEmpleados";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Empleado;
    }
}