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
    public partial class Form_StockMenorA10 : Form
    {

        private List<Producto> listaProductos;

        public Form_StockMenorA10(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CargarCamposProductos()
        {

            foreach (Producto producto in this.listaProductos)
            {
                if (producto.Stock <= 10)
                {
                    this.lb_StockMenor0.Items.Add(producto.NombreProducto + " || Marca :" + producto.Marca + " || Precio :$" + producto.Precio + " || Peso: " + producto.Peso + "grs || Stock :" + producto.Stock + " || Id Producto :" + producto.IdProducto);
                }
            }

        }


        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_StockMenorA10_Load(object sender, EventArgs e)
        {
            CargarCamposProductos();
        }
    }
}
