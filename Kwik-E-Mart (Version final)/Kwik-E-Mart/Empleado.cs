using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum ECargo
    {
        Limpieza = 1,
        Repositor =2,
        Vendedor = 3
    }

    public enum ETurno
    {
        Maniana = 11,
        Tarde = 22,
        Noche = 33
    }

    public class Empleado : Persona 
    {

        private ECargo cargo;
        private ETurno turno;


        #region Propiedades

        /// <summary>
        /// Deuvle el cargo de un empleado
        /// </summary>
        public ECargo Cargo
        {
            get{return this.cargo;}
           
        }
        /// <summary>
        /// Devuelve el turno en el que trabajo un empleado
        /// </summary>
        public ETurno Turno
        {
            get{ return this.turno; }
           
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de Empleado
        /// </summary>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del Empleado</param>
        /// <param name="dni">Dni del Empleado</param>
        /// <param name="cargo">Cargo del empleado</param>
        /// <param name="turno">Turno en el que trabaja el empleado</param>
        public Empleado(string nombre, string apellido, int dni, ECargo cargo, ETurno turno) : base(nombre, apellido, dni)
        {
            this.cargo = cargo;
            this.turno = turno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga el metodo To string
        /// </summary>
        /// <returns>Retorna losdatos del empleado con los datos formateados</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + this.cargo + " - " + this.turno);

            return sb.ToString();
        }

        #endregion
    }
}   
