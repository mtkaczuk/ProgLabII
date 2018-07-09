using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___Validación
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 12 - Validación";
            #endregion

            #region Variables
            int num11, numMin11 = 999, numMax11 = -999, acum11 = 0;
            double prom11 = 0;
            const int min11 = -100, max11 = 100, cantNumeros = 10;
            #endregion

            for (int i = 0; i < cantNumeros; i++)
            {
                Console.Write("Ingrese un número: ");
                num11 = int.Parse(Console.ReadLine());
                if (!Validacion.ValidarNumero(num11, min11, max11))
                {
                    Console.WriteLine("¡Error! El número ingresado excedió los límites prefijados.");
                    Console.WriteLine("Por favor, reingrese su número: ");
                    num11 = int.Parse(Console.ReadLine());
                }
                if (num11 < numMin11)
                {
                    numMin11 = num11;
                }
                if (num11 > numMax11)
                {
                    numMax11 = num11;
                }
                acum11 = acum11 + num11;
            }

            prom11 = Validacion.CalcularPromedio(acum11, cantNumeros);

            #region Resultados
            Console.WriteLine("El número mínimo fue: {0}", min11);
            Console.WriteLine("El número máximo fue: {0}", max11);
            Console.WriteLine("El promedio de los números ingresados fue: {0}", prom11);
            Console.ReadKey();
            #endregion
        }
    }
}
