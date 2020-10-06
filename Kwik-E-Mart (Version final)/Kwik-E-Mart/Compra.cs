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
       
        #region Propiedades 
        /// <summary>
        /// Devuelve y permite asignar productos
        /// </summary>
        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        /// <summary>
        /// Devue y pemite asingar empleados
        /// </summary>
        public Empleado Empleado
        {
            get { return this.empleado; }
            set { this.empleado = value; }
        }

        /// <summary>
        ///  Devuelve y permite asingar clientes
        /// </summary>
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        /// <summary>
        /// Deuvle y permite asginar montos
        /// </summary>
        public float Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Compra
        /// </summary>
        /// <param name="cliente">Cliente que efecuta la compra</param>
        /// <param name="empleado">Empleado que atiende al cliente</param>
        /// <param name="monto">Monto de la compra</param>
        public Compra(Cliente cliente, Empleado empleado,float monto)
        {
            this.cliente = cliente;
            this.empleado = empleado;
            this.monto = monto;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador "+" para que permita agregar un producto a una compra
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="productos"></param>
        /// <returns>True si se pudo hacer , false si no se pudo hacer la carga</returns>
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

        /// <summary>
        /// Sobrecarga el metodo toString
        /// </summary>
        /// <returns>Retorna empleado con los datos de una compra formateados </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Empleado: " + this.empleado + " - " + "Cliente: " + this.cliente + " - " + " Productos: " + this.productos + " - " + " Monto Compra : $" +this.monto );

            return sb.ToString();
        }

        #endregion
    }
}