using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public static class Monedas
    {
       /// <summary>
       /// Convierte de pesos a dolares y retorna el precio convertido en string
       /// </summary>
       /// <param name="stringPeso">Pesos a convertir( en string ) </param>
       /// <returns></returns>

        public static string PesoADolar(string stringPeso)
        {
            float precioDolar = 175;

            int pesos = int.Parse(stringPeso);

            // Convierto a dolares

            string dolares = (pesos / precioDolar).ToString() + " Dolares";

            return dolares;
        }

    }
}
