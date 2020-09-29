using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
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

        public Compra(Cliente cliente , Empleado empleado)
        {
            this.cliente = cliente;
            this.empleado = empleado;
        }

        public static bool operator +(Compra compra,Producto productos)
        {
            bool retorno = false;
            int stock = productos.Stock;

            if ( stock < 0)
            {
                compra.productos.Add(productos);
                retorno = true;
            }

            return retorno;
        }

    }
}
