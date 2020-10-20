using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Cliente : Persona
    {
        private string correoElectronico;
        private string domicilio;
        private int nroTelefono;

        #region Propiedades

        /// <summary>
        /// Devuelve el correo electronico 
        /// </summary>
        public string CorreoElectronico
        {
            get { return this.correoElectronico; }
            
        }
        /// <summary>
        /// Devuelve el domicilio
        /// </summary>
        public string Domicilio
        {
            get { return this.domicilio;}
           
        }
        /// <summary>
        /// Devuelve el numero de telefono 
        /// </summary>
        public int NroTelefono
        {
            get { return this.nroTelefono; }
            
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de un Cliente
        /// </summary>
        /// <param name="nombre">Nombre Cliente</param>
        /// <param name="apellido">Apellido Cliente</param>
        /// <param name="dni">Dni Cliente</param>
        /// <param name="correoElectronico">Correo eletronico del cliente</param>
        /// <param name="domicilio">Domicilio del cliente</param>
        /// <param name="nroTelefono">Nro de telefono del cliente</param>
        public Cliente(string nombre, string apellido, int dni,string correoElectronico ,string domicilio,int nroTelefono) : base(nombre, apellido, dni)
        {
            this.correoElectronico = correoElectronico;
            this.domicilio = domicilio;
            this.nroTelefono = nroTelefono;
        }

        #endregion

        #region Metodos 
        /// <summary>
        ///  Sobrecarga metodo toString ( en realidad sigue existiendo pero le doy otra funcionalidad )
        /// </summary>
        /// <returns> Retorna un cliente con los datos de un cliente formateados </returns>
        public override string ToString()
        {
            // implemento del metodo to string en clase derivada  

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Correo Electronico : " + this.correoElectronico + " - " + "Domicilio : " + this.domicilio + " - " + "Telefono : " + this.nroTelefono);

            return sb.ToString();
        }

        public override string Saludar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Saludar() + " y fui el Cliente." );

            return sb.ToString();
        }
        #endregion

    }
}
