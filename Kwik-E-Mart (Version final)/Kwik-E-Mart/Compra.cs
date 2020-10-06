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
        private float monto;

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

        public float Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }

        public Compra(Cliente cliente, Empleado empleado,float monto)
        {
            this.cliente = cliente;
            this.empleado = empleado;
            this.monto = monto;
        }


        public static bool operator +(Compra compra, Producto productos)
        {

            bool retorno = false;
            bool Existe = false;

            foreach (Producto a in compra.productos)
            {
                if (a == productos)
                {
                    Existe = true;
                    break;
                }
            }

            if (Existe == false )
            {
                compra.productos.Add(productos);
                retorno = true;
            }

            return retorno;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Empleado: " + this.empleado + " - " + "Cliente: " + this.cliente + " - " + " Productos: " + this.productos + " - " + " Monto Compra : $" +this.monto );

            return sb.ToString();
        }

    }
}