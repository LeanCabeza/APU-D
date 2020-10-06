namespace Forms
{
    partial class Form_StockMenorA10
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
            this.lb_StockMenor0 = new System.Windows.Forms.ListBox();
            this.pb_Banner = new System.Windows.Forms.PictureBox();
            this.btn_salir10 = new System.Windows.Forms.Button();
            this.lbl_dato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_StockMenor0
            // 
            this.lb_StockMenor0.FormattingEnabled = true;
            this.lb_StockMenor0.Location = new System.Drawing.Point(42, 160);
            this.lb_StockMenor0.Name = "lb_StockMenor0";
            this.lb_StockMenor0.Size = new System.Drawing.Size(714, 290);
            this.lb_StockMenor0.TabIndex = 2;
            // 
            // pb_Banner
            // 
            this.pb_Banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_Banner.Location = new System.Drawing.Point(-3, 0);
            this.pb_Banner.Name = "pb_Banner";
            this.pb_Banner.Size = new System.Drawing.Size(835, 90);
            this.pb_Banner.TabIndex = 100;
            this.pb_Banner.TabStop = false;
            // 
            // btn_salir10
            // 
            this.btn_salir10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir10.Location = new System.Drawing.Point(567, 472);
            this.btn_salir10.Name = "btn_salir10";
            this.btn_salir10.Size = new System.Drawing.Size(220, 45);
            this.btn_salir10.TabIndex = 101;
            this.btn_salir10.Text = "Volver al menu ";
            this.btn_salir10.UseVisualStyleBackColor = true;
            this.btn_salir10.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // lbl_dato
            // 
            this.lbl_dato.AutoSize = true;
            this.lbl_dato.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_dato.Location = new System.Drawing.Point(36, 108);
            this.lbl_dato.Name = "lbl_dato";
            this.lbl_dato.Size = new System.Drawing.Size(450, 33);
            this.lbl_dato.TabIndex = 102;
            this.lbl_dato.Text = "Productos con stock menor o igual a 10";
            // 
            // Form_StockMenorA10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(816, 529);
            this.Controls.Add(this.lbl_dato);
            this.Controls.Add(this.btn_salir10);
            this.Controls.Add(this.pb_Banner);
            this.Controls.Add(this.lb_StockMenor0);
            this.Name = "Form_StockMenorA10";
            this.Text = "Form_StockMenorA10";
            this.Load += new System.EventHandler(this.Form_StockMenorA10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_StockMenor0;
        private System.Windows.Forms.PictureBox pb_Banner;
        private System.Windows.Forms.Button btn_salir10;
        private System.Windows.Forms.Label lbl_dato;
    }
}