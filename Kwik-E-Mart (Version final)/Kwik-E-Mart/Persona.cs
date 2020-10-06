using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Persona // para que no se pueda crear un objeto persona directamente 
    {

        private string nombre; 
        private string apellido; 
        private int dni;   

        #region Propiedades
        /// <summary>
        /// Devuelve el nombre de la persona 
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }   
        }
        /// <summary>
        /// Devuelve el apellido de la persona
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
        }
        /// <summary>
        /// Devuelve el dni de la persona y permite asignarlo
        /// </summary>

        public int Dni
        {
            get { return this.dni;}
            set { this.dni = value;}
        }

        #endregion

        #region Constructores

        /// <summary>
        ///  Constructor de persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">Dni de la persona </param>
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
        }

        #endregion

        #region  Sobrecargas
        /// <summary>
        /// Sobrecarga del metodo to string
        /// </summary>
        /// <returns>Retorna una persona con sus datos formateados</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.nombre + " " + this.apellido + " - " + "DNI: " + this.dni);

            return sb.ToString();
        }
        #endregion
    }
}
