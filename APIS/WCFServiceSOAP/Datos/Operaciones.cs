using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceSOAP.Datos
{
    public class Operaciones
    {
        public int ResultadoOperacion (int a, int b, string operacion)
        {
            int resultado = 0;
            if (operacion == "+")
            {
                resultado = a + b; 
            }
            else if(operacion == "-")
            {
                resultado = a - b;
            }
            else if (operacion == "/")
            {
                resultado = a / b;
            }
            else if (operacion == "*")
            {
                resultado = a * b;
            }
            return resultado;

        }
    }
}