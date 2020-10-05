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
            this.dataGridView1.DataSource = listaCompras;

          //  CargarCamposCompras();
        }

      /*  private void CargarCamposCompras()
        {

            foreach (Compra c in this.listaCompras)
            {
                this.listbox_Compras.Items.Add("Empleado: " + c.Empleado.Nombre + "  " + c.Empleado.Apellido + " || Cliente : " + c.Cliente.Nombre + "  " + c.Cliente.Apellido +" || Productos Comprados : " + c.Productos );
            }
        }
     */



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
