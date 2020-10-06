using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            /// Si el usuario es admin y es 1234 , te dejo acceder el programa , sino , no.
            if (txt_usuario.Text == "admin" && txt_pass.Text == "1234")
            {
                Form_principal menu = new Form_principal();
                this.IsMdiContainer = true;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error vuelva a intentarlo");
            }
        }
    }
}
