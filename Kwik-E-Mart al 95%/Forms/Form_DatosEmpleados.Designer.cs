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
            this.btn_salir = new System.Windows.Forms.Button();
            this.pb_banner = new System.Windows.Forms.PictureBox();
            this.lbl_dato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Empleado
            // 
            this.lb_Empleado.FormattingEnabled = true;
            this.lb_Empleado.Location = new System.Drawing.Point(39, 155);
            this.lb_Empleado.Name = "lb_Empleado";
            this.lb_Empleado.Size = new System.Drawing.Size(719, 290);
            this.lb_Empleado.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(568, 466);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(220, 45);
            this.btn_salir.TabIndex = 96;
            this.btn_salir.Text = "Volver al menu ";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pb_banner
            // 
            this.pb_banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_banner.Location = new System.Drawing.Point(-2, 1);
            this.pb_banner.Name = "pb_banner";
            this.pb_banner.Size = new System.Drawing.Size(835, 90);
            this.pb_banner.TabIndex = 99;
            this.pb_banner.TabStop = false;
            // 
            // lbl_dato
            // 
            this.lbl_dato.AutoSize = true;
            this.lbl_dato.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_dato.Location = new System.Drawing.Point(33, 108);
            this.lbl_dato.Name = "lbl_dato";
            this.lbl_dato.Size = new System.Drawing.Size(228, 33);
            this.lbl_dato.TabIndex = 100;
            this.lbl_dato.Text = "Lista de Empleados";
            // 
            // Form_DatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.lbl_dato);
            this.Controls.Add(this.pb_banner);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lb_Empleado);
            this.Name = "Form_DatosEmpleados";
            this.Text = "Datos Empleados";
            this.Load += new System.EventHandler(this.Form_DatosEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Empleado;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pb_banner;
        private System.Windows.Forms.Label lbl_dato;
    }
}