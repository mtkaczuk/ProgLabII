using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02___Cuadrado_y_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 02 - Cuadrado y Cubo";
            #endregion

            #region Variables
            double num02 = 0, cuad02 = 0, cubo02 = 0;
            #endregion

            Console.Write("Ingrese un número: ");
            num02 = double.Parse(Console.ReadLine());

            #region Cálculos
            cuad02 = CalcularCuadrado(num02, cuad02);
            cubo02 = CalcularCubo(num02, cubo02);
            #endregion

            #region Resultados
            Console.WriteLine("Su número fue: {0}", num02);
            Console.WriteLine("Su cuadrado es: {0}", cuad02);
            Console.WriteLine("Su cubo es: {0}", cubo02);
            Console.ReadLine();
            #endregion
        }
        #region Métodos
        private static double CalcularCuadrado(double num02, double cuad02)
        {
            cuad02 = Math.Pow(num02, 2);
            return cuad02;
        }
        private static double CalcularCubo(double num02, double cubo02)
        {
            cubo02 = Math.Pow(num02, 3);
            return cubo02;
        }
        #endregion
    }
}
