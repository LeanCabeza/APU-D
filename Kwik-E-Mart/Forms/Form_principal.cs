using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;
using Validaciones;




namespace Forms
{
    public partial class Form_principal : Form
    {
        private List<Cliente>  listaClientes = new List<Cliente>();
        private List<Empleado> listaEmpleados = new List<Empleado>();
        private List<Producto> listaProductos = new List<Producto>();

        public Form_principal()
        {
            InitializeComponent();
        }

        private void tsm_CargarDatos_Click(object sender, EventArgs e)
        {
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();


            listaClientes.Add(new Cliente("Homero", "Simpson", 78458250, "HomeroSimpson@gmail.com", "742 Evergreen Terrace", 1133457845));
            listaClientes.Add(new Cliente("Marge", "Simpson", 50305045, "MargeSimpson@gmail.com", "742 Evergreen Terrace", 1133458854));
            listaClientes.Add(new Cliente("Bart", "Simpson", 30458582, "BartSimpson@gmail.com", "742 Evergreen Terrace", 911582554));
            listaClientes.Add(new Cliente("Lisa", "Simpson", 28305045, "LisaSimpson@gmail.com", "742 Evergreen Terrace", 158258854));
            listaClientes.Add(new Cliente("Moe", "Szyslak", 51805045, "MoeElCantinero@gmail.com", "La taberna de Moe 41", 1653745854));
            listaClientes.Add(new Cliente("Edna", "Krabappel", 42805045, "EdnaLaProfe@gmail.com", "St James Ave 326", 925374554));
            listaClientes.Add(new Cliente("Seymour", "Skinner", 5805045, "Seeymourrr@gmail.com", "Bay St 786", 184745854));
            listaClientes.Add(new Cliente("Barney", "Gumble", 42582458, "EbrioBarney@gmail.com", "Colton St 175", 174545854));
            listaClientes.Add(new Cliente("Ned", "Flanders", 52582458, "LaBibliaDeNed@gmail.com", "744 Evergreen Terrace", 244545854));

            listaEmpleados.Add(new Empleado("Appu", "Nahasapeemapetilon",40458383,ECargo.Vendedor,ETurno.Noche));
            listaEmpleados.Add(new Empleado("Ronnie", "Nahasapeemapetilon",41458383, ECargo.Vendedor, ETurno.Tarde));

            MessageBox.Show("Clientes instanciados con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form_altaCliente Form_nuevoCliente = new Form_altaCliente(this.listaClientes);
                Form_nuevoCliente.ShowDialog();

            if (Form_nuevoCliente.DialogResult == DialogResult.OK)
            {
                this.listaClientes.Add(Form_nuevoCliente.Cliente);
                MessageBox.Show("Cliente agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_altaEmpleados Form_nuevoEmpleado = new Form_altaEmpleados(this.listaEmpleados);
            Form_nuevoEmpleado.ShowDialog();

            if (Form_nuevoEmpleado.DialogResult == DialogResult.OK)
            {
                this.listaEmpleados.Add(Form_nuevoEmpleado.Empleado);
                MessageBox.Show("Empleado agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_altoProducto Form_nuevoProducto = new Form_altoProducto(this.listaProductos);
            Form_nuevoProducto.ShowDialog();

            if (Form_nuevoProducto.DialogResult == DialogResult.OK)
            {
                this.listaProductos.Add(Form_nuevoProducto.Producto);
                MessageBox.Show("Producto agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmListadoDeClientes_Click(object sender, EventArgs e)
        {
            Form_DatosClientes datosClientes = new Form_DatosClientes(this.listaClientes);
            datosClientes.ShowDialog();

        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
                
        }

        private void listadoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DatosEmpleados datosEmpleaedos = new Form_DatosEmpleados(this.listaEmpleados);
            datosEmpleaedos.ShowDialog();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DatosProductos datosProductos = new Form_DatosProductos(this.listaProductos);
            datosProductos.ShowDialog();
        }

        private void comprarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compra f = new Form_Compra(this.listaEmpleados, this.listaClientes,this.listaProductos);
            f.ShowDialog();
        }
    }
}
