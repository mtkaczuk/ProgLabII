using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09___Media_Pirámide
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 09 - Media Pirámide";
            #endregion

            #region Variables
            int alturaPiramide09;
            int incremento09 = 0;
            #endregion

            Console.Write("Ingrese altura de la piramide: ");
            alturaPiramide09 = int.Parse(Console.ReadLine());

            #region Validación
            if (!ValidarAltura(alturaPiramide09))
            {
                Console.WriteLine("¡Error! La altura de la Pirámide no puede ser menor a 0.");
                Console.Write("Por favor, reingrese la altura de la Pirámide");
                alturaPiramide09 = int.Parse(Console.ReadLine());
            }
            #endregion

            while (incremento09 <= alturaPiramide09)
            {
                incremento09++;
                for (int i = 0; i < incremento09; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        #region Métodos
        private static bool ValidarAltura(int altura)
        {
            if (altura >= 0)
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
