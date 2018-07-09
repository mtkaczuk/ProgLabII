using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06___Año_Bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 06 - Año Bisiesto";
            #endregion

            #region Variables
            int anio06;
            #endregion

            Console.Write("Ingrese un año: ");
            anio06 = int.Parse(Console.ReadLine());

            #region Validación
            if (!ValidaAnios(anio06))
            {
                Console.WriteLine("Error!! Debe ingresar un año entre 1000 y 9999");
                Console.WriteLine("Ingrese un año: ");
                anio06 = int.Parse(Console.ReadLine());
            }
            #endregion

            if (anio06 % 4 == 0 || (anio06 % 100 != 0 && anio06 % 400 == 0))
            {
                Console.WriteLine("El año {0} es bisiesto", anio06);
            }
            else
            {
                Console.WriteLine("El año {0} no es bisiesto", anio06);
            }
            Console.ReadKey();
        }
        #region Métodos
        private static bool ValidaAnios(double anio)
        {
            if (anio >= 1000 && anio <= 9999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
