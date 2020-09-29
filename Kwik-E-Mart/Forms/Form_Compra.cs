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
    public partial class Form_Compra : Form
    {
        private List<Empleado> listaEmpleados;
        private List<Cliente> listaClientes;
        private List<Producto> listaProductos;
      
        public Form_Compra(List<Empleado> listaEmpleados, List<Cliente> listaClientes, List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaEmpleados = listaEmpleados;
            this.listaClientes = listaClientes;
            this.listaProductos = listaProductos;
            CargarCamposProductos();

        }

        private void btn_BuscarEmpleado_Click(object sender, EventArgs e)
        {
            this.listBox_Empleados.Items.Clear();
            bool existe = false;

            bool dniOk = false;
            int auxDni;

            StringBuilder mensajeError = new StringBuilder();

            if (!(int.TryParse(this.tb_dniEmpleado.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                dniOk = true;
            }

            if (dniOk)
            {

                foreach (Empleado a in this.listaEmpleados)
                {
                    if (auxDni == a.Dni)
                    {
                        this.listBox_Empleados.Items.Add((a.Nombre + " // " + a.Apellido + " // " + a.Dni + " // " + a.Cargo + " // " + a.Turno));
                        existe = true;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("¡Empleado encontrados con ese dni!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("No existe Empleado con ese dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error , el dni debe ser en formato numeros y sin espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_AltaEmpleado_Click(object sender, EventArgs e)
        {
            Form_altaEmpleados Form_nuevoEmpleado = new Form_altaEmpleados(this.listaEmpleados);
            Form_nuevoEmpleado.ShowDialog();

            if (Form_nuevoEmpleado.DialogResult == DialogResult.OK)
            {
                this.listaEmpleados.Add(Form_nuevoEmpleado.Empleado);
                MessageBox.Show("Empleado agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            Form_altaCliente Form_nuevoCliente = new Form_altaCliente(this.listaClientes);
            Form_nuevoCliente.ShowDialog();

            if (Form_nuevoCliente.DialogResult == DialogResult.OK)
            {
                this.listaClientes.Add(Form_nuevoCliente.Cliente);
                MessageBox.Show("Cliente agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_AltaProducto_Click(object sender, EventArgs e)
        {
            Form_altoProducto Form_nuevoProducto = new Form_altoProducto(this.listaProductos);
            Form_nuevoProducto.ShowDialog();

            if (Form_nuevoProducto.DialogResult == DialogResult.OK)
            {
                this.listaProductos.Add(Form_nuevoProducto.Producto);
                MessageBox.Show("Producto agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
                this.lb_Productos.Items.Clear();
                CargarCamposProductos();
            }
            
        }

        private void CargarCamposProductos()
        {

            foreach (Producto producto in this.listaProductos)
            {
                this.lb_Productos.Items.Add(producto.NombreProducto + " Marca : " + producto.Marca + " Precio : $ " + producto.Precio + " Peso :" + producto.Peso + "grmos" + " Stock : " + producto.Stock + " IdProducto : " + producto.IdProducto);
            }

        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            this.lstbox_Cliente.Items.Clear();
            bool existe = false;

            bool dniOk = false;
            int auxDni;

            StringBuilder mensajeError = new StringBuilder();

            if (!(int.TryParse(this.tb_dniCliente.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                dniOk = true;
            }

            if (dniOk)
            {
                foreach (Cliente a in this.listaClientes)
                {
                    if (auxDni == a.Dni)
                    {
                        this.lstbox_Cliente.Items.Add((a.Nombre + " // " + a.Apellido + " // " + a.Dni + " // " + a.CorreoElectronico + " // " + a.Domicilio + " // " + a.NroTelefono));
                        existe = true;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("¡Cliente encontrados con ese dni!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("No existe Cliente con ese dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Error , el dni debe ser en formato numeros y sin espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
       
        }

        private void btn_VerEmpleado_Click(object sender, EventArgs e)
        {
            Form_DatosEmpleados datosEmpleaedos = new Form_DatosEmpleados(this.listaEmpleados);
            datosEmpleaedos.ShowDialog();
        }

        private void btn_VerClientes_Click(object sender, EventArgs e)
        {
            Form_DatosClientes datosClientes = new Form_DatosClientes(this.listaClientes);
            datosClientes.ShowDialog();
        }


        #region Evento Drag and drop

        //Estos manejadores de eventos permiten arrastrar a los productos para agregarlos a la compra

        private void lb_Productos_MouseDown(object sender, MouseEventArgs e)
        {

            
            if (!(lb_Productos.SelectedItem is null))
            {
              
                this.lb_Productos.DoDragDrop(lb_Productos.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }

        private void lb_Compra_DragEnter(object sender, DragEventArgs e)
        {
            //Valida que al dropear algo en la listbox de productos a compra solo se agrege si es texto
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lb_Compra_DragDrop(object sender, DragEventArgs e)
        {
            //Agrego el producto pasado a string a la listbox compra
            lb_Compra.Items.Add(e.Data.GetData(DataFormats.Text));

            //Aca tendria que descontar -1 en stock

        }

        #endregion


        private void listBox_Empleados_DoubleClick(object sender, EventArgs e)
        {
            txtbox_Empleado.Text = this.listBox_Empleados.SelectedItem.ToString();

        }

        private void lstbox_Cliente_DoubleClick(object sender, EventArgs e)
        {
            txtbox_Cliente.Text = this.lstbox_Cliente.SelectedItem.ToString();
        }

        private void Form_Compra_Load(object sender, EventArgs e)
        {

        }

    }
}
