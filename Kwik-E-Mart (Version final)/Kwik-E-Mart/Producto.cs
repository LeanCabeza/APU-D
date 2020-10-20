using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        private string nombreProducto;
        private string marca;
        private float precio;
        private float peso;
        private int stock;
        private int idProducto;

        #region Propiedades
        /// <summary>
        /// Devuelve el nombre del producto y permite settearlo
        /// </summary>
        public string NombreProducto
            {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value ; }
            }
        /// <summary>
        /// Devuelve la marca del producto y permite settearlo
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value;}
        }
        /// <summary>
        /// Devuelve el precio del producto y permite settearlo
        /// </summary>
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        /// <summary>
        /// Devuelve el peso del producto y permite settearlo
        /// </summary>
        public float Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        /// <summary>
        /// Devuelve el stock del producto y permite settearlo
        /// </summary>
        public int Stock
        {
            get { return this.stock;}
            set { this.stock = value; }
        }
        /// <summary>
        /// Devuelve el id del producto y permite settearlo
        /// </summary>
        public int IdProducto
        {
            get { return this.idProducto; }
            set { this.idProducto = value; }
        }


        #endregion

        #region Constructores 

        /// <summary>
        /// Constructor de producto 
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="peso">Peso del producto</param>
        /// <param name="stock">Stock del producto</param>
        /// <param name="idProducto">Id del producto</param>
        public Producto(string nombreProducto,string marca , float precio,float peso,int stock,int idProducto)
        {
            this.nombreProducto = nombreProducto;
            this.marca = marca;
            this.precio = precio;
            this.peso = peso;
            this.stock = stock;
            this.idProducto = idProducto;
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga delmetodo to string 
        /// </summary>
        /// <returns>Retorna un producto con los datos del producto formateados </returns>
        public override string ToString()
        {
            // implemento del metodo to string en clase derivada  

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Producto: " + this.nombreProducto + " - " + "Marca: " + this.marca + " - " + "Precio: " + this.precio + " " + this.peso + " - " + "Stock : " + this.stock + " - " + "Id Producto : " + this.idProducto);
            return sb.ToString();
        }
        #endregion
    }
}
