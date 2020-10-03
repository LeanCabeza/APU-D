using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona // para que no se pueda crear un objeto persona directamente 
    {
        private string nombre;  // para no hacerlo publico que no se puede hago el get y el set , y poder settearlo desde donde yo quiera
        private string apellido; 
        private int dni;   

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Dni
        {
            get { return this.dni;}
            set { this.dni = value;}
        }

        #endregion

        #region Constructores

        public Persona()
        {

        }
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.nombre + " " + this.apellido + " - " + "DNI: " + this.dni);

            return sb.ToString();
        }

    }
}
