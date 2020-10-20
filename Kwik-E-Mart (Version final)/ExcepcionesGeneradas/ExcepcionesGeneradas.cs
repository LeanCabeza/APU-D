using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesGeneradasException
{
    public class ExcepcionesGeneradas : Exception
    {
        public ExcepcionesGeneradas(string mensajeError) : base("Hubo un problema con " + mensajeError)
        {

        }
    }    
 
}
