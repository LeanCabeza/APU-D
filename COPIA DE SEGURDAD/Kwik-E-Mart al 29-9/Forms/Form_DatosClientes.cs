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
    public partial class Form_DatosClientes : Form
    {
        private List<Cliente> listaClientes;

        public Form_DatosClientes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            CargarCamposClientes();
        }

        private void CargarCamposClientes()
        {

            foreach (Cliente cliente in this.listaClientes)
            {
                this.lb_clientes.Items.Add("Nombre: "+cliente.Nombre + " || Apellido:" + cliente.Apellido + " || Dni: " + cliente.Dni + " || Correo: " + cliente.CorreoElectronico + " || Domicilio: " + cliente.Domicilio + " || Telefono:" + cliente.NroTelefono);
            }

        }

    }
}
