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
    public partial class Form_DatosProductos : Form
    {
        private List<Producto> listaProductos;

        public Form_DatosProductos(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Cargo todos los campos de los productos que estan en lista producto , formateados.
        /// </summary>
        private void CargarCamposProductos()
        {

            foreach (Producto producto in this.listaProductos)
            {
                this.lb_Productos.Items.Add(producto.NombreProducto + " || Marca :" + producto.Marca + " || Precio :$" + producto.Precio + " || Peso: " + producto.Peso + "grs || Stock :" + producto.Stock + " || Id Producto :" + producto.IdProducto );
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DatosProductos_Load(object sender, EventArgs e)
        {
            CargarCamposProductos();
        }
    }
}
