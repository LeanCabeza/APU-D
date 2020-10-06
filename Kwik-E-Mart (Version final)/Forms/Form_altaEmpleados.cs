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
    public partial class Form_altaEmpleados : Form
    {
        private Empleado empleado;

        //Estos campos se utilizan para verificar que el cliente a dar de alta no se encuentre ya agregado
        // si lo cargo directamente como un empleado puede ser que surja algun error y termina cargando por error un cliente que no quiero que cargue

        private List<Empleado> listaEmpleados = new List<Empleado>();

        #region Propiedades

        public Empleado Empleado
        {
            get { return this.empleado; }
        }

        #endregion 

        public Form_altaEmpleados(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this.listaEmpleados = listaEmpleados;
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_aceptarEmpleado_Click(object sender, EventArgs e)
        {
            //Atributos Persona
            bool nombreOK = false;
            bool apellidoOK = false;
            bool dniOk = false;
            int auxDni;

            //Atributos Empleado
            bool cargoOk = false;
            bool turnoOk = false;

            StringBuilder mensajeError = new StringBuilder();

            //Valido atributos Persona

            // NOMBRE 
            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.tb_NombreEmpleado.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre");
            }
            else
            {
                nombreOK = true;
            }
            // Apellido

            if (!(ValidacionesTexto.ValidarStringSoloLetras(this.tb_ApellidoEmpleado.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el apellido");
            }
            else
            {
                apellidoOK = true;
            }

            // Dni

            if (!(int.TryParse(this.tb_DniEmpleado.Text, out auxDni)))
            {
                mensajeError.AppendLine("Ocurrio un error con el DNI");
            }
            else
            {
                bool existe = false;

                foreach (Empleado a in listaEmpleados)
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

            // CARGO 

            if ((this.cb_CargoEmpleado.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un cargo");
            }
            else
            {
                cargoOk = true;
            }

            // TURNO 

            if ((this.cb_TurnoEmpleado.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un Turno");
            }
            else
            {
                turnoOk = true;
            }

            //Si se pasan todas las validaciones creo el objeto Cliente

            if (nombreOK && apellidoOK && dniOk && cargoOk && turnoOk)
            {
                //Atributos de la clase Persona
                string nombre = this.tb_NombreEmpleado.Text;
                string apellido = this.tb_ApellidoEmpleado.Text;
                int dni = int.Parse(this.tb_DniEmpleado.Text);

                // CARGO 
                ECargo cargo = 0;

                //Indice 0 corresponde a limpieza
                if (this.cb_CargoEmpleado.SelectedIndex == 0)
                {
                    cargo = ECargo.Limpieza;
                }

                //Indice 1 corresponde a repositor
                if (this.cb_CargoEmpleado.SelectedIndex == 1)
                {
                    cargo = ECargo.Repositor;
                }
                //Indice 2 corresponde a vendedor
                if (this.cb_CargoEmpleado.SelectedIndex == 2)
                {
                    cargo = ECargo.Vendedor;

                }

                //TURNO 
                ETurno turno = 0;

                //Indice 0 correspondo a turno mañana
                if (this.cb_TurnoEmpleado.SelectedIndex == 0)
                {
                    turno = ETurno.Maniana;
                }

                //Indice 1 correspondo a turno tarde
                if (this.cb_TurnoEmpleado.SelectedIndex == 1)
                {
                    turno = ETurno.Tarde;
                }
                //Indice 2 correspondo a turno Noche
                if (this.cb_TurnoEmpleado.SelectedIndex == 2)
                {
                    turno = ETurno.Noche;
                }

                this.empleado = new Empleado(nombre, apellido, dni, cargo, turno);

                //Verifico que el empleado no sea duplicado

                bool existe = false;

                foreach (Empleado a in this.listaEmpleados)
                {
                    if ((a).ToString() == this.listaEmpleados.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Ya hay un empleado con esa informacion dado de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void Form_altaEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}