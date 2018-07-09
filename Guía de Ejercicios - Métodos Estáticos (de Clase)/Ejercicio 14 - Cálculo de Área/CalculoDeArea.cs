using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14___Cálculo_de_Área
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double lad)
        {
            double areaCuadrado = lad * lad;
            return areaCuadrado;
        }
        public static double CalcularTriangulo(double bas, double alt)
        {
            double areaTriangulo = bas * alt;
            return areaTriangulo;
        }
        public static double CalcularCirculo(double rad)
        {
            double areaCirculo = 3.14 * (Math.Pow(rad, 2));
            return areaCirculo;
        }
    }
}
