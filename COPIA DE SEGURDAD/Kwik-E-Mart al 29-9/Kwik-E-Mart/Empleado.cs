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

        public ECargo Cargo
        {
            get{return this.cargo;}
            set{this.cargo = value;}
        }

        public ETurno Turno
        {
            get{ return this.turno; }
            set{ this.turno = value;}
        }
        #endregion

        #region Constructores
        public Empleado(string nombre, string apellido, int dni, ECargo cargo, ETurno turno) : base(nombre, apellido, dni)
        {
            this.cargo = cargo;
            this.turno = turno;
        }
        #endregion
    }
}   
