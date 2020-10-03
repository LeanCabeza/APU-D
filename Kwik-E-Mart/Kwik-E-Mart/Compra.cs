using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        private Cliente cliente;
        private Empleado empleado;
        private List<Producto> productos;

        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public Empleado Empleado
        {
            get { return this.empleado; }
            set { this.empleado = value; }
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public Compra(Cliente cliente, Empleado empleado)
        {
            this.cliente = cliente;
            this.empleado = empleado;
        }

        public static bool operator +(Compra compra, Producto productos)
        {
          
            compra.productos.Add(productos);

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Empleado: " + this.empleado + " - " + "Cliente: " + this.cliente + " - " + " Productos: " + this.productos);

            return sb.ToString();
        }

    }
}