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
        private List<Compra> listaCompras = new List<Compra>();

        public Form_principal()
        {
            InitializeComponent();
        }

        private void tsm_CargarDatos_Click(object sender, EventArgs e)
        {
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            listaProductos = new List<Producto>();

            //Clientes 
            listaClientes.Add(new Cliente("Homero", "Simpson", 78458250, "HomeroSimpson@gmail.com", "742 Evergreen Terrace", 1133457845));
            listaClientes.Add(new Cliente("Marge", "Simpson", 50305045, "MargeSimpson@gmail.com", "742 Evergreen Terrace", 1133458854));
            listaClientes.Add(new Cliente("Bart", "Simpson", 30458582, "BartSimpson@gmail.com", "742 Evergreen Terrace", 911582554));
            listaClientes.Add(new Cliente("Lisa", "Simpson", 28305045, "LisaSimpson@gmail.com", "742 Evergreen Terrace", 158258854));
            listaClientes.Add(new Cliente("Moe", "Szyslak", 51805045, "MoeElCantinero@gmail.com", "La taberna de Moe 41", 1653745854));
            listaClientes.Add(new Cliente("Edna", "Krabappel", 42805045, "EdnaLaProfe@gmail.com", "St James Ave 326", 925374554));
            listaClientes.Add(new Cliente("Seymour", "Skinner", 5805045, "Seeymourrr@gmail.com", "Bay St 786", 184745854));
            listaClientes.Add(new Cliente("Barney", "Gumble", 42582458, "EbrioBarney@gmail.com", "Colton St 175", 174545854));
            listaClientes.Add(new Cliente("Ned", "Flanders", 52582458, "LaBibliaDeNed@gmail.com", "744 Evergreen Terrace", 244545854));
           
            //Emplelados
            listaEmpleados.Add(new Empleado("Appu", "Nahasapeemapetilon",40458383,ECargo.Vendedor,ETurno.Noche));
            listaEmpleados.Add(new Empleado("Ronnie", "Nahasapeemapetilon",41458383, ECargo.Vendedor, ETurno.Tarde));

            //Productos 
            listaProductos.Add(new Producto("Zapatillas Airmax90","Nike",16000,1000,30,100));
            listaProductos.Add(new Producto("Gorra Trucker", "Volcom", 1200,200,90, 101));
            listaProductos.Add(new Producto("Gorra SB", "NikeSB", 1600, 200,120, 102));
            listaProductos.Add(new Producto("Buzo Capucha","Trasher",3600, 200,1000, 103));
            listaProductos.Add(new Producto("Sachet de Leche", "LaSerenisima",120,300,300, 104));
            listaProductos.Add(new Producto("Tomate","VerduMax",10,100,900, 105));
            listaProductos.Add(new Producto("Banana","VerduMax",10, 100, 1000, 106));
            listaProductos.Add(new Producto("Lechuga","VerduMax",10, 100, 60, 107));
            listaProductos.Add(new Producto("Naranja","VerduMax", 10, 100, 60, 108));
            listaProductos.Add(new Producto("Mandarina","VerduMax", 10, 100, 60, 109));
            listaProductos.Add(new Producto("Zapallito","VerduMax", 10, 100, 60, 110));
            listaProductos.Add(new Producto("Acelga","VerduMax", 10,100, 60, 111));
            listaProductos.Add(new Producto("Rucula","VerduMax", 10,100, 60, 112));
            listaProductos.Add(new Producto("Radicheta","VerduMax", 10,100, 60, 113));
            listaProductos.Add(new Producto("Manzana", "VerduMax",10,100,60,114));
            listaProductos.Add(new Producto("Anana", "VerduMax", 10, 100, 60, 115));
            listaProductos.Add(new Producto("Zandia", "VerduMax", 10, 100, 20, 116));
            listaProductos.Add(new Producto("Frutilla", "VerduMax", 10, 1500, 2000, 117));
            listaProductos.Add(new Producto("Berenjena", "VerduMax", 10, 1500, 2000, 118));
            listaProductos.Add(new Producto("Televisor", "Samsung", 100000,12000,30, 119));
            listaProductos.Add(new Producto("Televisor", "NOBLEX", 160000,11000, 50, 120));
            listaProductos.Add(new Producto("Celular j6", "Samsung",160000,300, 50, 121));
            listaProductos.Add(new Producto("Snack Papafrita", "Pringles",150, 600, 500, 122));
            listaProductos.Add(new Producto("Snack Triangulitos", "Doritos", 90, 400, 200, 123));
            listaProductos.Add(new Producto("Snack Maiz", "Cheetos",110, 400, 200, 124));
            listaProductos.Add(new Producto("Bicileta", "Venzo", 19000, 12000, 6, 125));
            listaProductos.Add(new Producto("Bicileta", "Bicimax", 10000, 12000, 5, 126));
            listaProductos.Add(new Producto("Neumatico", "Pirelli", 8000, 1000,9, 127));
            listaProductos.Add(new Producto("Neumatico","GoodYear", 7500, 1000, 9, 128));
            listaProductos.Add(new Producto("Neumatico", "FateO", 5000, 1000, 9, 129));
            listaProductos.Add(new Producto("Neumatico", "Yokohoma", 6000, 1000, 9, 130));


            MessageBox.Show("Datos instanciados con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void comprarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compra form_nuevaCompra = new Form_Compra(this.listaEmpleados, this.listaClientes, this.listaProductos);
            form_nuevaCompra.ShowDialog();

            if (form_nuevaCompra.DialogResult == DialogResult.OK)
            {
                this.listaCompras.Add(form_nuevaCompra.Compra);

                MessageBox.Show("Compra agregado al listado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        private void listadoDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_DatosCompra datosCompras = new Form_DatosCompra(this.listaCompras);
            datosCompras.ShowDialog();
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
