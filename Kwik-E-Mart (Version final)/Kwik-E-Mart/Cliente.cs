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

        public string CorreoElectronico
        {
            get { return this.correoElectronico; }
            set { this.correoElectronico = value; }
        }

        public string Domicilio
        {
            get { return this.domicilio;}
            set { this.domicilio = value;}
        }

        public int NroTelefono
        {
            get { return this.nroTelefono; }
            set { this.nroTelefono = value; }
        }

        #endregion

        #region Constructores

        public Cliente(string nombre, string apellido, int dni,string correoElectronico ,string domicilio,int nroTelefono) : base(nombre, apellido, dni)
        {
            this.correoElectronico = correoElectronico;
            this.domicilio = domicilio;
            this.nroTelefono = nroTelefono;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Correo Electronico : " + this.correoElectronico + " - " + "Domicilio : " + this.domicilio + " - " + "Telefono : " + this.nroTelefono);

            return sb.ToString();
        }


    }
}
