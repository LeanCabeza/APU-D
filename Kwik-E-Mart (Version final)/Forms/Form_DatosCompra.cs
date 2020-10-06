using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{

    public partial class Form_DatosCompra : Form
    {
        List<Compra> listaCompras;

        public Form_DatosCompra(List<Compra> listaCompras)
        {
            InitializeComponent();
            this.listaCompras = listaCompras;
            this.dgv_ComprasRealizadas.DataSource = listaCompras;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            dgv_ComprasRealizadas.ReadOnly = true;
        }


        private void listbox_Compras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_DatosCompra_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
