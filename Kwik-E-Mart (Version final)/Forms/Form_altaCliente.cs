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
using Validaciones;

namespace Forms
{
    public partial class Form_altaCliente : Form
    {
        private Cliente cliente;
        //Estos campos se utilizan para verificar que el cliente a dar de alta no se encuentre ya agregado
        // si lo cargo directamente como un empleado puede ser que surja algun error y termina cargando por error un cliente que no quiero que cargue
        private List<Cliente> listaClientes =  new List<Cliente>();

        #region Propiedades

        public Cliente Cliente
        {
            get { return this.cliente; }
        }

        #endregion 

        public Form_altaCliente(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btn_aceptarCliente_Click(object sender, EventArgs e)
        {
            //Atributos Persona
            bool nombreOK = false;
            bool apellidoOK = false;
            bool dniOk = false;
            int auxDni;

            //Atributos Cliente
            bool correoElectronicoOk = false;
            bool domicilioOk = false;
            bool telefonoOk = false;
            int auxTelefono;

            StringBuilder mensajeError = new StringBuilder();

            //Valido atributos Persona

            // NOMBRE 
            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.tb_NombreCliente.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre");
            }
            else
            {
                nombreOK = true;
            }
            // Apellido

            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.tb_ApellidoCliente.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el apellido");
            }
            else
            {
                apellidoOK = true;
            }

            // Dni
            // Verifico que el dni no exista en la lista 


            if (!(int.TryParse(this.tb_DniCliente.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {

                bool existe = false;

                foreach (Cliente a in listaClientes)
                {
                    if (a.Dni == auxDni)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe == false)
                {
                    dniOk = true;

                }
                else
                {
                    mensajeError.AppendLine("Ya se registraron con ese dni");
                }
       
            }


            // Email 

            if (!(ValidacionesTexto.Validar_Email(this.tb_EmailCliente.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el email");
            }
            else
            {
                correoElectronicoOk = true;
            }

            // Domicilio

            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumeros(this.tb_DomicilioCliente.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el Domicilio");
            }
            else
            {
                domicilioOk = true;
            }

            // Telefono

            if (!(int.TryParse(this.tb_TelefonoCliente.Text, out auxTelefono)))
            {
                mensajeError.AppendLine("Ocurrio un error con el Telefono");
            }
            else
            {
                telefonoOk = true;
            }


            //Si se pasan todas las validaciones creo el objeto Cliente

            if (nombreOK && apellidoOK && dniOk && correoElectronicoOk && domicilioOk && telefonoOk)
            {
                //Atributos de la clase Persona
                string nombre = this.tb_NombreCliente.Text;
                string apellido = this.tb_ApellidoCliente.Text;
                int dni = int.Parse(this.tb_DniCliente.Text);

                string email = this.tb_EmailCliente.Text;
                string domicilio = this.tb_DomicilioCliente.Text;
                int telefono = int.Parse(this.tb_TelefonoCliente.Text);


                this.cliente = new Cliente(nombre, apellido, dni, email, domicilio, telefono);

                //Verifico que el cliente no sea duplicado
                //2 alumnos son iguales si tienen igual numero de dni
                bool existe =false;

                foreach (Cliente a in this.listaClientes)
                {
                    if ((a).ToString() == this.listaClientes.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un Cliente con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
        }

        private void Form_altaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
