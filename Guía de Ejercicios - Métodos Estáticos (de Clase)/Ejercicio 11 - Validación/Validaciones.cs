using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___Validación
{
    public static class Validacion
    {
        public static bool ValidarNumero(int num, int min, int max)
        {
            if (num >= min && num <= max)
            {
                return true;
            }
            return false;
        }
        public static double CalcularPromedio(int acum, int cantNumeros)
        {
            double prom = acum / cantNumeros;
            return prom;
        }
    }
}
