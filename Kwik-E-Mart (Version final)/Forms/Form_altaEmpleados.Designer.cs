namespace Forms
{
    partial class Form_altaEmpleados
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
            this.lbl_datosEmpleado = new System.Windows.Forms.Label();
            this.cb_TurnoEmpleado = new System.Windows.Forms.ComboBox();
            this.tb_DniEmpleado = new System.Windows.Forms.TextBox();
            this.tb_ApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.tb_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_DniEmpleado = new System.Windows.Forms.Label();
            this.lbl_ApellidoEmpleado = new System.Windows.Forms.Label();
            this.lbl_nombreEmpleado = new System.Windows.Forms.Label();
            this.cb_CargoEmpleado = new System.Windows.Forms.ComboBox();
            this.btn_aceptarEmpleado = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_datosEmpleado
            // 
            this.lbl_datosEmpleado.AutoSize = true;
            this.lbl_datosEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_datosEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_datosEmpleado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datosEmpleado.Location = new System.Drawing.Point(12, 111);
            this.lbl_datosEmpleado.Name = "lbl_datosEmpleado";
            this.lbl_datosEmpleado.Size = new System.Drawing.Size(174, 28);
            this.lbl_datosEmpleado.TabIndex = 33;
            this.lbl_datosEmpleado.Text = "DATOS EMPLEADO";
            // 
            // cb_TurnoEmpleado
            // 
            this.cb_TurnoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TurnoEmpleado.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cb_TurnoEmpleado.FormattingEnabled = true;
            this.cb_TurnoEmpleado.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cb_TurnoEmpleado.Location = new System.Drawing.Point(141, 295);
            this.cb_TurnoEmpleado.Name = "cb_TurnoEmpleado";
            this.cb_TurnoEmpleado.Size = new System.Drawing.Size(175, 26);
            this.cb_TurnoEmpleado.TabIndex = 60;
            // 
            // tb_DniEmpleado
            // 
            this.tb_DniEmpleado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DniEmpleado.Location = new System.Drawing.Point(141, 227);
            this.tb_DniEmpleado.Name = "tb_DniEmpleado";
            this.tb_DniEmpleado.Size = new System.Drawing.Size(175, 26);
            this.tb_DniEmpleado.TabIndex = 58;
            // 
            // tb_ApellidoEmpleado
            // 
            this.tb_ApellidoEmpleado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ApellidoEmpleado.Location = new System.Drawing.Point(141, 193);
            this.tb_ApellidoEmpleado.Name = "tb_ApellidoEmpleado";
            this.tb_ApellidoEmpleado.Size = new System.Drawing.Size(175, 26);
            this.tb_ApellidoEmpleado.TabIndex = 57;
            // 
            // tb_NombreEmpleado
            // 
            this.tb_NombreEmpleado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NombreEmpleado.Location = new System.Drawing.Point(141, 158);
            this.tb_NombreEmpleado.Name = "tb_NombreEmpleado";
            this.tb_NombreEmpleado.Size = new System.Drawing.Size(175, 26);
            this.tb_NombreEmpleado.TabIndex = 56;
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turno.Location = new System.Drawing.Point(43, 294);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(55, 23);
            this.lbl_Turno.TabIndex = 55;
            this.lbl_Turno.Text = "Turno";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.Location = new System.Drawing.Point(43, 261);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(57, 23);
            this.lbl_Cargo.TabIndex = 54;
            this.lbl_Cargo.Text = "Cargo";
            // 
            // lbl_DniEmpleado
            // 
            this.lbl_DniEmpleado.AutoSize = true;
            this.lbl_DniEmpleado.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DniEmpleado.Location = new System.Drawing.Point(43, 226);
            this.lbl_DniEmpleado.Name = "lbl_DniEmpleado";
            this.lbl_DniEmpleado.Size = new System.Drawing.Size(37, 23);
            this.lbl_DniEmpleado.TabIndex = 52;
            this.lbl_DniEmpleado.Text = "Dni";
            // 
            // lbl_ApellidoEmpleado
            // 
            this.lbl_ApellidoEmpleado.AutoSize = true;
            this.lbl_ApellidoEmpleado.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoEmpleado.Location = new System.Drawing.Point(43, 192);
            this.lbl_ApellidoEmpleado.Name = "lbl_ApellidoEmpleado";
            this.lbl_ApellidoEmpleado.Size = new System.Drawing.Size(76, 23);
            this.lbl_ApellidoEmpleado.TabIndex = 51;
            this.lbl_ApellidoEmpleado.Text = "Apellido";
            // 
            // lbl_nombreEmpleado
            // 
            this.lbl_nombreEmpleado.AutoSize = true;
            this.lbl_nombreEmpleado.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpleado.Location = new System.Drawing.Point(43, 158);
            this.lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            this.lbl_nombreEmpleado.Size = new System.Drawing.Size(77, 23);
            this.lbl_nombreEmpleado.TabIndex = 50;
            this.lbl_nombreEmpleado.Text = "Nombre ";
            // 
            // cb_CargoEmpleado
            // 
            this.cb_CargoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CargoEmpleado.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cb_CargoEmpleado.FormattingEnabled = true;
            this.cb_CargoEmpleado.Items.AddRange(new object[] {
            "Limpieza ",
            "Repositor",
            "Vendedor"});
            this.cb_CargoEmpleado.Location = new System.Drawing.Point(141, 263);
            this.cb_CargoEmpleado.Name = "cb_CargoEmpleado";
            this.cb_CargoEmpleado.Size = new System.Drawing.Size(175, 26);
            this.cb_CargoEmpleado.TabIndex = 59;
            // 
            // btn_aceptarEmpleado
            // 
            this.btn_aceptarEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptarEmpleado.Location = new System.Drawing.Point(141, 346);
            this.btn_aceptarEmpleado.Name = "btn_aceptarEmpleado";
            this.btn_aceptarEmpleado.Size = new System.Drawing.Size(118, 31);
            this.btn_aceptarEmpleado.TabIndex = 61;
            this.btn_aceptarEmpleado.Text = "Aceptar";
            this.btn_aceptarEmpleado.UseVisualStyleBackColor = true;
            this.btn_aceptarEmpleado.Click += new System.EventHandler(this.btn_aceptarEmpleado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Forms.Properties.Resources.homeroEmpleado;
            this.pictureBox2.Location = new System.Drawing.Point(262, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 196);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pb_banner
            // 
            this.pb_banner.Image = global::Forms.Properties.Resources.top1;
            this.pb_banner.Location = new System.Drawing.Point(-1, -1);
            this.pb_banner.Name = "pb_banner";
            this.pb_banner.Size = new System.Drawing.Size(448, 90);
            this.pb_banner.TabIndex = 0;
            this.pb_banner.TabStop = false;
            // 
            // Form_altaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(447, 485);
            this.Controls.Add(this.btn_aceptarEmpleado);
            this.Controls.Add(this.cb_CargoEmpleado);
            this.Controls.Add(this.cb_TurnoEmpleado);
            this.Controls.Add(this.tb_DniEmpleado);
            this.Controls.Add(this.tb_ApellidoEmpleado);
            this.Controls.Add(this.tb_NombreEmpleado);
            this.Controls.Add(this.lbl_Turno);
            this.Controls.Add(this.lbl_Cargo);
            this.Controls.Add(this.lbl_DniEmpleado);
            this.Controls.Add(this.lbl_ApellidoEmpleado);
            this.Controls.Add(this.lbl_nombreEmpleado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_datosEmpleado);
            this.Controls.Add(this.pb_banner);
            this.Name = "Form_altaEmpleados";
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.Form_altaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_banner;
        private System.Windows.Forms.Label lbl_datosEmpleado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cb_TurnoEmpleado;
        private System.Windows.Forms.TextBox tb_DniEmpleado;
        private System.Windows.Forms.TextBox tb_ApellidoEmpleado;
        private System.Windows.Forms.TextBox tb_NombreEmpleado;
        private System.Windows.Forms.Label lbl_Turno;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_DniEmpleado;
        private System.Windows.Forms.Label lbl_ApellidoEmpleado;
        private System.Windows.Forms.Label lbl_nombreEmpleado;
        private System.Windows.Forms.ComboBox cb_CargoEmpleado;
        private System.Windows.Forms.Button btn_aceptarEmpleado;
    }
}