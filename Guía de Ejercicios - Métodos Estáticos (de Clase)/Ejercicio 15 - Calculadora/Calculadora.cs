using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15___Calculadora
{
    public static class Calculadora
    {
        public static double Calcular(int num1501, int num1502, string operador)
        {
            double rtdo = 0;
            switch (operador)
            {
                case "+":
                    rtdo = num1501 + num1502;
                    break;
                case "-":
                    rtdo = num1501 - num1502;
                    break;
                case "*":
                    rtdo = num1501 / num1502;
                    break;
                case "/":
                    rtdo = num1501 / num1502;
                    break;
            }
            return rtdo;
        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine("El resultado es {0}", resultado);
        }

        internal static bool Validar(int num1502)
        {
            if (num1502 != 0)
                return true;
            else
                return false;
        }
    }
}
