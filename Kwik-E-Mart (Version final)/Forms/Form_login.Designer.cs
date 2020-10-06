namespace Forms
{
    partial class Form_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.PB_Login = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(386, 178);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(118, 31);
            this.btn_aceptar.TabIndex = 1;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_usuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(367, 61);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(137, 27);
            this.txt_usuario.TabIndex = 2;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(268, 61);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(86, 25);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "USUARIO ";
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(15)))));
            this.lbl_contrasenia.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasenia.Location = new System.Drawing.Point(251, 113);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(114, 25);
            this.lbl_contrasenia.TabIndex = 6;
            this.lbl_contrasenia.Text = "CONTRASEÑA";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_pass.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(367, 111);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(137, 27);
            this.txt_pass.TabIndex = 3;
            // 
            // PB_Login
            // 
            this.PB_Login.Image = global::Forms.Properties.Resources.login;
            this.PB_Login.Location = new System.Drawing.Point(8, 12);
            this.PB_Login.Name = "PB_Login";
            this.PB_Login.Size = new System.Drawing.Size(237, 248);
            this.PB_Login.TabIndex = 7;
            this.PB_Login.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(289, 86);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(35, 13);
            this.usuario.TabIndex = 8;
            this.usuario.Text = "admin";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(289, 138);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(31, 13);
            this.pass.TabIndex = 9;
            this.pass.Text = "1234";
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(547, 260);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.PB_Login);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Form_login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_contrasenia;
        private System.Windows.Forms.PictureBox PB_Login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label pass;
    }
}

