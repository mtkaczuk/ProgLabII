using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15___Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15 - Calculadora Básica";

            #region Variables
            int opc15;
            int num1501;
            int num1502;
            string operador15;
            double resultado15;
            #endregion

            opc15 = Menu();
            while (opc15 != 5)
            {
                switch (opc15)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Suma");
                        Console.Write("Ingrese un número: ");
                        num1501 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro número: ");
                        num1502 = int.Parse(Console.ReadLine());
                        operador15 = "+";
                        resultado15 = Calculadora.Calcular(num1501, num1502, operador15);
                        Calculadora.Mostrar(resultado15);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Resta");
                        Console.Write("Ingrese un número: ");
                        num1501 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro número: ");
                        num1502 = int.Parse(Console.ReadLine());
                        operador15 = "-";
                        resultado15 = Calculadora.Calcular(num1501, num1502, operador15);
                        Calculadora.Mostrar(resultado15);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Multiplicación");
                        Console.Write("Ingrese un número: ");
                        num1501 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro número: ");
                        num1502 = int.Parse(Console.ReadLine());
                        operador15 = "*";
                        resultado15 = Calculadora.Calcular(num1501, num1502, operador15);
                        Calculadora.Mostrar(resultado15);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("División");
                        Console.Write("Ingrese un número: ");
                        num1501 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese otro número: ");
                        num1502 = int.Parse(Console.ReadLine());
                        operador15 = "/";
                        while (!(Calculadora.Validar(num1502)))
                        {
                            Console.WriteLine("¡Error! No se puede dividir por 0");
                            Console.Write("Ingrese un número: ");
                            num1502 = int.Parse(Console.ReadLine());
                        }
                        resultado15 = Calculadora.Calcular(num1501, num1502, operador15);
                        Calculadora.Mostrar(resultado15);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ha presionado el botón Salir. Gracias, vuelva pronto.");
                        break;
                    default:
                        Console.Write("Opción Incorrecta.");
                        break;
                }
                opc15 = Menu();
            }
        }
        #region Métodos
        private static int Menu()
        {
            int opc;
            Console.Clear();
            Console.WriteLine("Calculadora Básica \n");
            Console.Write("1.- Suma (+) \n");
            Console.Write("2.- Resta (-) \n");
            Console.Write("3.- Multiplicación (*) \n");
            Console.Write("4.- División (/) \n");
            Console.Write("5.- Salir\n");
            Console.Write("\nOpcion: ");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }
        #endregion
    }
}
