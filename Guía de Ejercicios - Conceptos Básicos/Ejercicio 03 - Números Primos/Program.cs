using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03___Números_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 03 - Números Primos";
            #endregion

            #region Variables
            int num03;
            int contPrimos03 = 0;
            #endregion

            Console.Write("Ingrese un número: ");
            num03 = int.Parse(Console.ReadLine());

            #region Validación
            if (!ValidarNumero(num03))
            {
                Console.WriteLine("¡Error! El número que ingresaste es menor a 0!");
                Console.Write("Por favor, reingrese un número: ");
                num03 = int.Parse(Console.ReadLine());
            }
            #endregion
            
            for (int i = 2; i <= num03; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contPrimos03 = contPrimos03 + 1;
                    }
                }
                if (contPrimos03 < 3)
                {
                    Console.WriteLine(i);
                }
                contPrimos03 = 0;
            }
            Console.ReadKey();
        }
        #region Métodos
        private static bool ValidarNumero(int num03)
        {
            if (num03 >= 0)
                return true;
            else
                return false;
        }
        #endregion
    }
}
