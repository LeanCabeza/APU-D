﻿namespace Forms
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.pb_Banner = new System.Windows.Forms.PictureBox();
            this.lbl_dato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_clientes
            // 
            this.lb_clientes.FormattingEnabled = true;
            this.lb_clientes.Location = new System.Drawing.Point(38, 140);
            this.lb_clientes.Name = "lb_clientes";
            this.lb_clientes.Size = new System.Drawing.Size(743, 290);
            this.lb_clientes.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(595, 436);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(220, 45);
            this.btn_salir.TabIndex = 95;
            this.btn_salir.Text = "Volver al menu ";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pb_Banner
            // 
            this.pb_Banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_Banner.Location = new System.Drawing.Point(-5, -3);
            this.pb_Banner.Name = "pb_Banner";
            this.pb_Banner.Size = new System.Drawing.Size(835, 90);
            this.pb_Banner.TabIndex = 98;
            this.pb_Banner.TabStop = false;
            // 
            // lbl_dato
            // 
            this.lbl_dato.AutoSize = true;
            this.lbl_dato.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_dato.Location = new System.Drawing.Point(12, 90);
            this.lbl_dato.Name = "lbl_dato";
            this.lbl_dato.Size = new System.Drawing.Size(194, 33);
            this.lbl_dato.TabIndex = 99;
            this.lbl_dato.Text = "Lista de Clientes";
            // 
            // Form_DatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(827, 493);
            this.Controls.Add(this.lbl_dato);
            this.Controls.Add(this.pb_Banner);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lb_clientes);
            this.Name = "Form_DatosClientes";
            this.Text = "Datos Clientes";
            this.Load += new System.EventHandler(this.Form_DatosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_clientes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pb_Banner;
        private System.Windows.Forms.Label lbl_dato;
    }
}