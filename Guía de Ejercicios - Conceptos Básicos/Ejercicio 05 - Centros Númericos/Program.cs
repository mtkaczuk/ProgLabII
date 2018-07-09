using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05___Centros_Númericos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 05 - Centros Númericos";
            #endregion

            #region Variables
            double num05;
            double sumaAdelante05 = 0;
            double sumaAtras05 = 0;
            double aumento05 = 1;
            #endregion

            Console.Write("Ingrese un numero: ");
            num05 = double.Parse(Console.ReadLine());

            #region Validación
            if (!ValidarNumero(num05))
            {
                Console.WriteLine("¡Error! El número que ingresaste es menor a 0!");
                Console.Write("Por favor, reingrese un número: ");
                num05 = int.Parse(Console.ReadLine());
            }
            #endregion

            while (aumento05 < num05)
            {
                aumento05++;

                for (double i = 1; i < aumento05; i++)
                {
                    sumaAtras05 = sumaAtras05 + i;
                }

                for (double j = aumento05 + 1; j <= sumaAtras05; j++)
                {
                    if ((sumaAdelante05 == sumaAtras05) || (sumaAdelante05 > sumaAtras05))
                    {
                        break;
                    }
                    sumaAdelante05 = sumaAdelante05 + j;
                }
                if (sumaAtras05 == sumaAdelante05)
                    Console.WriteLine("Es centro numerico: {0}", aumento05);
            }
            Console.ReadLine();
        }

        #region Métodos
        private static bool ValidarNumero(double num05)
        {
            if (num05 >= 0)
                return true;
            else
                return false;
        }
        #endregion
    }
}
