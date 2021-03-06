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

namespace Forms
{
    public partial class Form_DatosClientes : Form
    {
        private List<Cliente> listaClientes;

        public Form_DatosClientes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Cargo los datos de todos los clientes que estan en listaClientes en el listbox
        /// </summary>
        private void CargarCamposClientes()
        {

            foreach (Cliente cliente in this.listaClientes)
            {
                this.lb_clientes.Items.Add("Nombre: "+cliente.Nombre + " || Apellido:" + cliente.Apellido + " || Dni: " + cliente.Dni + " || Correo: " + cliente.CorreoElectronico + " || Domicilio: " + cliente.Domicilio + " || Telefono:" + cliente.NroTelefono);
            }

        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DatosClientes_Load(object sender, EventArgs e)
        {
            CargarCamposClientes();
        }
    }
}
