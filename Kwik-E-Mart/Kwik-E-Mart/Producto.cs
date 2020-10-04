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

        public string NombreProducto
            {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value ; }
            }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value;}
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public float Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        public int Stock
        {
            get { return this.stock;}
            set { this.stock = value; }
        }

        public int IdProducto
        {
            get { return this.idProducto; }
            set { this.idProducto = value; }
        }


        #endregion
        public Producto(string nombreProducto,string marca , float precio,float peso,int stock,int idProducto)
        {
            this.nombreProducto = nombreProducto;
            this.marca = marca;
            this.precio = precio;
            this.peso = peso;
            this.stock = stock;
            this.idProducto = idProducto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre Producto: " + this.nombreProducto + " - " + "Marca: " + this.marca + " - " + "Precio: " + this.precio + " " + this.peso + " - " + "Stock : " + this.stock + " - " + "Id Producto : " + this.idProducto);
            return sb.ToString();
        }
    }
}
