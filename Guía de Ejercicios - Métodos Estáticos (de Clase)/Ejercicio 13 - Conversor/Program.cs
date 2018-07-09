using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13___Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 13 - Conversor";
            #endregion

            #region Variables
            int opc13;
            double numDec13;
            string numBin13;
            string numeroSalidaBinario13;
            double numeroSalidaDecimal13;
            #endregion

            Console.WriteLine("Conversor de Decimal a Binario y de Binario a Decimal");
            opc13 = Metodos.Menu();
            while (opc13 != 3)
            {
                switch (opc13)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Decimal a Binario");
                        Console.Write("\nEscribe un numero decimal: ");
                        numDec13 = double.Parse(Console.ReadLine());
                        numeroSalidaBinario13 = Metodos.DecimalBinario(numDec13);
                        Console.Clear();
                        Console.WriteLine("Decimal: {0}", numDec13);
                        Console.WriteLine("Binario: {0}", numeroSalidaBinario13);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Binario a Decimal");
                        Console.Write("\nEscribe un numero binario: ");
                        numBin13 = Console.ReadLine();
                        numeroSalidaDecimal13 = Metodos.BinarioDecimal(numBin13);
                        Console.Clear();
                        Console.WriteLine("Binario: {0}", numBin13);
                        Console.Write("Decimal: {0}", numeroSalidaDecimal13);
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        Console.Write("Opcion incorrecta.");
                        break;
                }
                opc13 = Metodos.Menu();
            }
        }
    }
}
