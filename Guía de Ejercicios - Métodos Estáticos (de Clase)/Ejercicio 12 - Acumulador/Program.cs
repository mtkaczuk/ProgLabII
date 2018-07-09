using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12___Acumulador
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 12 - Acumulador";
            #endregion

            #region Variables
            int num12, acum12 = 0;
            char rta;
            #endregion

            do
            {
                Console.Write("Ingrese un número: ");
                num12 = int.Parse(Console.ReadLine());
                acum12 = acum12 + num12;
                Console.WriteLine("¿Desea seguir ingresando números S/N?");
                rta = char.Parse(Console.ReadLine());
                if (ValidarRespuesta.ValidaS_N(rta))
                {
                    Console.WriteLine("¡Error! El respuesta no es válida.");
                    Console.WriteLine("Por favor, reingrese su respuesta: ");
                    rta = char.Parse(Console.ReadLine());
                }                
            } while (rta == 's');

            Console.WriteLine("El total acumulado fue: {0}", acum12);
            Console.ReadKey();
        }
    }
}
