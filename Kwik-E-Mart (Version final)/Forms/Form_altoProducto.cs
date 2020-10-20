
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Entidades;
using ExcepcionesGeneradasException;

namespace Forms
{
    public partial class Form_altoProducto : Form
    {
        private Producto producto;

        private List<Producto> listaProductos = new List<Producto>();

        #region Propiedades

        public Producto Producto
        {
            get { return this.producto; }
        }

        #endregion

        public Form_altoProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_aceptarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {

            // atributos de producto

            bool nombreProductoOk = false;
            bool marcaOk = false;

            bool precioOk = false;
            float auxPrecio;

            bool pesoOk = false;
            float auxPeso;

            bool stockOk = false;
            int auxStock;

            bool idProductoOk = false;
            int auxId;

            StringBuilder mensajeError = new StringBuilder();

            //Valido atributos Producto
            
            // NOMBRE 
            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumerosEspacios(this.tb_NombreProd.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre");
            }
            else
            {
                nombreProductoOk = true;
            }

            //MARCA 
            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumerosEspacios(this.tb_marca.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con la marca");
            }
            else
            {
                marcaOk = true;
            }
            //Precio
            if (!(float.TryParse(this.tb_precio.Text, out auxPrecio)))
            {
                mensajeError.AppendLine("Ocurrio un error con el precio");
            }
            else
            {
                precioOk = true;
            }

            //Peso
            if (!(float.TryParse(this.tb_peso.Text, out auxPeso)))
            {
                mensajeError.AppendLine("Ocurrio un error con el peso");
            }
            else
            {
                pesoOk = true;
            }
            // stock 

            if (!(int.TryParse(this.tb_stock.Text, out auxStock)))
            {
                mensajeError.AppendLine("Ocurrio un error con el stock");
            }
            else
            {
                stockOk = true;
            }

            // ID 
            //Valido que el id no sea repetido

            if (!(int.TryParse(this.tb_idProd.Text, out auxId)))
            {
                mensajeError.AppendLine("Ocurrio un error con el id");
            }
            else
            {
                bool existe = false;

                foreach (Producto a in listaProductos)
                {
                    if (a.IdProducto == auxId)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe == false)
                {
                    idProductoOk = true;

                }
                else
                {
                    mensajeError.AppendLine("Ya registraron un producto con ese Id");
                }

            }


            //Si se pasan todas las validaciones creo el objeto Producto

            if (nombreProductoOk && marcaOk && precioOk && pesoOk && stockOk && idProductoOk)
            {
                string nombreProducto = this.tb_NombreProd.Text;
                string marcaProducto = this.tb_marca.Text;
                float precioProducto = float.Parse(this.tb_precio.Text);
                float pesoProducto = float.Parse(this.tb_peso.Text);
                int stock = int.Parse(this.tb_stock.Text);
                int id = int.Parse(this.tb_idProd.Text);

                this.producto = new Producto(nombreProducto, marcaProducto, precioProducto, pesoProducto, stock,id);

                //Verifico que el producto no sea duplicado
                bool existe = false;

                foreach (Producto a in this.listaProductos)
                {
                    if ((a).ToString() == this.listaProductos.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un producto con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            int stockAux = int.Parse(tb_stock.Text);
            int pesoAux= int.Parse(tb_idProd.Text);
            int precioAux = int.Parse(tb_precio.Text);
            

            if ( stockAux <0 || pesoAux <0 || precioAux <0 )
                 {
                    throw new ExcepcionesGeneradas("El stock, o el peso , o el precio son menores a 0 , procedo a cerrar el programa");
                 }


            }
            catch (ExcepcionesGeneradas stockProblem)
            {
                MessageBox.Show(stockProblem.Message);
                Application.Exit();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
