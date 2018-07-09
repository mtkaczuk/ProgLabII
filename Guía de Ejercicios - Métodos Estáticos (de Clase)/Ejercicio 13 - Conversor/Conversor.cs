using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13___Conversor
{
    public static class Metodos
    {
        public static string DecimalBinario(double numdec)
        {

            #region Variables
            int num = Convert.ToInt32(numdec);
            string numeroenBinario = "";
            int aux;
            #endregion

            do
            {
                aux = num % 2;
                num = num / 2;
                numeroenBinario = aux + numeroenBinario;
            } while (num > 0);

            return numeroenBinario;
        }
        public static double BinarioDecimal(string numbin)
        {
            #region Variables
            int exponente = numbin.Length - 1;
            int num_decimal = 0;
            string numDeci = Convert.ToString(num_decimal);
            double numeroenDecimal = 0;
            #endregion

            for (int i = 0; i < numbin.Length; i++)
            {
                if (int.Parse(numbin.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }

            numeroenDecimal = num_decimal;

            return numeroenDecimal;
        }
        public static int Menu()
        {
            int opc;
            Console.Clear();
            Console.WriteLine("Conversor\n");
            Console.Write("1.- Decimal a Binario\n");
            Console.Write("2.- Binario a Decimal\n");
            Console.Write("3.- Salir\n");
            Console.Write("\nOpcion: ");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }
}
