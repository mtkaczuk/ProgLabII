using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01___Máximo__Mínimo_y_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 01 - Máximo, Mínimo y Promedio";
            #endregion

            #region Variables
            double num01, min01 = 9999, max01 = -9999, acum01 = 0, prom01;
            const int cantNumeros01 = 5;
            #endregion

            for (int i = 0; i < cantNumeros01; i++)
            {
                Console.Write("Ingrese un número: ");
                num01 = double.Parse(Console.ReadLine());
                if (num01 < min01)
                {
                    min01 = num01;
                }
                if (num01 > max01)
                {
                    max01 = num01;
                }
                acum01 = acum01 + num01;
            }

            #region Cálculos
            prom01 = CalcularPromedio(acum01, cantNumeros01);
            #endregion

            #region Resultados
            Console.WriteLine("El máximo fue: {0}", max01);
            Console.WriteLine("El mínimo fue: {0}", min01);
            Console.WriteLine("El promedio de los números ingresados fue: {0}", prom01);
            Console.ReadKey();
            #endregion
        }
        private static double CalcularPromedio (double acum, int cantNumeros)
        {
            double prom = (double) acum / cantNumeros;
            return prom;
        }
    }
}
