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
            CargarCamposProductos();
        }

        private void CargarCamposProductos()
        {

            foreach (Producto producto in this.listaProductos)
            {
                this.lb_Productos.Items.Add(producto.NombreProducto + " // " + producto.Marca + " // " + producto.Precio + " // " + producto.Peso + " // " + producto.Stock + " // " + producto.IdProducto );
            }

        }

        
    }
}
