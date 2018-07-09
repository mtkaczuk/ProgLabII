using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10___Pirámide
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 10 - Pirámide";
            #endregion

            #region Variables
            int altura, a;
            int espacios;
            #endregion

            Console.Write("Ingrese el Altura de la Pirámide: ");
            altura = int.Parse(Console.ReadLine());

            #region Validación
            if (!ValidarAltura(altura))
            {
                Console.WriteLine("¡Error! La altura de la Pirámide no puede ser menor a 0.");
                Console.Write("Por favor, reingrese la altura de la Pirámide");
                altura = int.Parse(Console.ReadLine());
            }
            #endregion

            for (int i = 1; i <= altura; i++)
            {
                string piramide = "";
                espacios = altura - i;
                a = i + (i - 1);
                for (int j = 0; j < espacios; j++)
                {
                    piramide += " ";
                }
                for (int l = 0; l < a; l++)
                {
                    piramide += "*";
                }
                Console.WriteLine(piramide);
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
