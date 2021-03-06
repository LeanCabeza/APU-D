﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Moneda;


namespace Forms
{
    public partial class Form_Compra : Form
    {
        private List<Empleado> listaEmpleados;
        private List<Cliente> listaClientes;
        private List<Producto> listaProductos;

        private Compra compra;

        public Compra Compra
        {
            get { return this.compra;}
        }


        public Form_Compra(List<Empleado> listaEmpleados, List<Cliente> listaClientes, List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaEmpleados = listaEmpleados;
            this.listaClientes = listaClientes;
            this.listaProductos = listaProductos;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        #region Metodos

        /// <summary>
        /// Carga los campos de los productos en la list box
        /// </summary>
        private void CargarCamposProductos()
        {
            
            foreach (Producto producto in this.listaProductos)
            {
                this.listbox_Productos.Items.Add("Producto: " + producto.NombreProducto + " - " + "Marca: " + producto.Marca + " - " + "Precio: " + producto.Precio + " " + producto.Peso + " - " + "Stock : " + producto.Stock + " - " + "Id Producto : " + producto.IdProducto);
            }

        }

        /// <summary>
        /// Cargo los combo box con sus datos correspondientes
        /// </summary>
        private void CargarComboBox()
        {
           
            this.cmb_Empleados.Enabled = true;
            this.cmb_Clientes.Enabled = true;
            this.cmb_Empleados.DataSource = listaEmpleados;
            this.cmb_Clientes.DataSource = listaClientes;
        }

        /// <summary>
        /// Calcula el monto total de todos los productos que estan en la listbox y corrobora si hay un simpson como cliente y le hace el descuento
        /// </summary>
        private void CalcularTotal()
        {
            float precio = 0;


            foreach (string productoTexto in this.listbox_Compra.Items)
            {
                foreach (Producto productoObjeto in this.listaProductos)
                {

                    if ((productoTexto + "\r\n") == productoObjeto.ToString())
                    {
                        if (cmb_Clientes.SelectedItem.ToString().Contains("Simpson"))
                        {
                            precio = precio + productoObjeto.Precio;
                            float descuento = (precio * 13) / 100;
                            precio = precio - descuento;
                            lbl_Descuento.Text = "[DESCUENTO] Sos de la familia simpson pagas 13% menos ,te ahorraste : $" + descuento;
                        }
                        else
                        {
                            precio = precio + productoObjeto.Precio;
                            lbl_Descuento.Text = "[No tenes descuento]";
                        }


                    }
                }
            }

            string precioStr = precio.ToString();

            this.txtbox_precioactualizado.Text = precioStr;
            this.label_dolares.Text = Monedas.PesoADolar(precioStr);
        }
        #endregion

        #region Evento Drag and drop

        //Estos manejadores de eventos permiten arrastrar a los productos para agregarlos a la compra

        private void lb_Productos_MouseDown(object sender, MouseEventArgs e)
        { 
            if (!(listbox_Productos.SelectedItem is null))
            {
                this.listbox_Productos.DoDragDrop(listbox_Productos.SelectedItem.ToString(), DragDropEffects.Copy);
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
            listbox_Compra.Items.Add(e.Data.GetData(DataFormats.Text));
            CalcularTotal();

        }

        #endregion

        // Doble click para sacar de la lista 

        private void listbox_Compra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(listbox_Compra.SelectedItem is null))
            {
                string producto = this.listbox_Compra.SelectedItem.ToString();
                this.listbox_Compra.Items.Remove(producto);
                CalcularTotal();
            }
        }


        private void Form_Compra_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            CargarCamposProductos();
        }


        // Agregando la compra 

        private void btn_AgregarCompra_Click(object sender, EventArgs e)
        {
            //Auxiliares de validacion
            bool EmpleadoOK = false;
            bool ClienteOK = false;
            bool ListaProductosOk = false;
            bool precioCalculadoOk = false;
            bool hayStockOk = false;
            bool permitirCompra = true;


            StringBuilder mensajeError = new StringBuilder();

            // Valido que se haya elegido algun empleado

            if ((this.cmb_Empleados.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un Empleado");
            }
            else
            {
                EmpleadoOK = true;
            }

            //Valido que se haya elegido algun cliente

            if ((this.cmb_Clientes.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un Cliente");
            }
            else
            {
                ClienteOK = true;
                string apellido = cmb_Clientes.SelectedValue.ToString();

            }

            // Valido que tengan al menos un producto en la lista de compras , sino no, no hay compra.

            if (this.listbox_Compra.Items.Count < 0)
            {
                mensajeError.AppendLine("La compra debe ser de por lo menos un producto");
            }
            else
            {
                ListaProductosOk = true;
            }

            // Corroboro que el gasto total no este en 0

            if ((string.IsNullOrEmpty(txtbox_precioactualizado.Text)))
            {
                mensajeError.AppendLine("Debe calcular el precio total primero");
            }
            else
            {
                precioCalculadoOk = true;
            }

            // hay stock ? , si no hay stock no permito hace la compra hasta que no saquen el producto sin stock


            foreach (string productoTexto in this.listbox_Compra.Items)
            {
                foreach (Producto productoObjeto in this.listaProductos)
                {
                    if ((productoTexto + "\r\n") == productoObjeto.ToString())
                    {
                        if (productoObjeto.Stock >= 1)
                        {
                            productoObjeto.Stock = productoObjeto.Stock - 1;
                            hayStockOk = true;
                           
                        }
                        else
                        {
                            mensajeError.AppendLine("No hay tanto stock de " + productoTexto.ToString());
                            permitirCompra = false;

                        }
                        
                    }
                }
            }


            //Si se pasan todas las validaciones creo el objeto Compra 

            if (ClienteOK && EmpleadoOK && ListaProductosOk && precioCalculadoOk&& hayStockOk && permitirCompra)
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea terminar la compra con los productos seleccionados?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.OK)
                {
                  
                    //Encuentro al Cliente que tengo que referenciar a la compra
                    Cliente cliente = null;
                    string auxCliente = this.cmb_Clientes.SelectedItem.ToString();

                    foreach (Cliente c in this.listaClientes)
                    {
                        if (c.ToString() == auxCliente)
                        {
                            cliente = c;
                            break;
                        }
                        
                    }

                    //Encuentro al Empleado que tengo que referenciar a la compra
                    Empleado empleado = null;
                    string auxEmpleado = this.cmb_Empleados.SelectedItem.ToString();

                    foreach (Empleado d in this.listaEmpleados)
                    {
                        if (d.ToString() == auxEmpleado)
                        {
                            empleado = d;
                            break;
                        }
                        
                    }
                    
                    string numeroEntrado = txtbox_precioactualizado.Text;

                    float precioTotal = float.Parse(numeroEntrado);


                    this.compra = new Compra(cliente,empleado,precioTotal);
                    
                    
                    //Agrego los productos a la compra

                    this.compra.Productos = new List<Producto>();

                    List<Producto> listaProductos = new List<Producto>();

                    int cantProductosAgregados = 0;

                    foreach (string productoTexto in this.listbox_Compra.Items)
                    {
                        foreach (Producto productoObjeto in this.listaProductos)
                        {
                            if ( (productoTexto + "\r\n") == productoObjeto.ToString())
                            {
                                //La sobrecarga del operador + hace el Add
                                if (compra + productoObjeto)
                                {
                                    cantProductosAgregados++;
                                }
                            }
                        }
                    }

                   // Esto esta echo solamente para usar un overray , Informa quien fue el cliente y el empleado.

                    MessageBox.Show(empleado.Saludar() +"\n"+ cliente.Saludar(),"Gracias , vuelva Prontoss!!") ;

                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtbox_precioactualizado_TextChanged(object sender, EventArgs e)
        {
            txtbox_precioactualizado.ReadOnly = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
