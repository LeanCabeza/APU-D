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
    public partial class Form_DatosEmpleados : Form
    {
        List<Empleado> listaEmpleados;
        public Form_DatosEmpleados(List<Empleado> listaEmpleados)
        {
            InitializeComponent();
            this.listaEmpleados = listaEmpleados;
            CargarCamposEmpleados();
        }

        private void CargarCamposEmpleados()
        {

            foreach (Empleado empleado in this.listaEmpleados)
            {
                this.lb_Empleado.Items.Add("Nombre: " + empleado.Nombre + " || Apellido : " + empleado.Apellido + " || Dni : " + empleado.Dni + " || Cargo : " + empleado.Cargo + " || Turno : " + empleado.Turno);
            }

        }

        private void Form_DatosEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
