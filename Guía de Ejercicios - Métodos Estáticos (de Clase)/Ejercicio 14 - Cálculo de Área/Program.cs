using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14___Cálculo_de_Área
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 14 - Cálculo de Aréa";
            #endregion

            #region Variables
            int opc14;
            double ladocuadrado14;
            double basetriangulo14;
            double alturatriangulo14;
            double radiocirculo14;
            double area14;
            #endregion

            opc14 = Menu();
            while (opc14 != 4)
            {
                switch (opc14)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Área del Cuadrado");
                        Console.Write("Ingrese el lado del cuadrado: ");
                        ladocuadrado14 = int.Parse(Console.ReadLine());
                        area14 = CalculoDeArea.CalcularCuadrado(ladocuadrado14);
                        Console.WriteLine("El Área del Cuadrado es: {0}", area14);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Área del Triángulo");
                        Console.Write("Ingrese la base del triángulo: ");
                        basetriangulo14 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        alturatriangulo14 = int.Parse(Console.ReadLine());
                        area14 = CalculoDeArea.CalcularTriangulo(basetriangulo14, alturatriangulo14);
                        Console.WriteLine("El Área del Cuadrado es: {0}", area14);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Área del Círculo");
                        Console.Write("Ingrese el radio del círculo: ");
                        radiocirculo14 = int.Parse(Console.ReadLine());
                        area14 = CalculoDeArea.CalcularCirculo(radiocirculo14);
                        Console.WriteLine("El Área del Cuadrado es: {0}", area14);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                opc14 = Menu();
            }
        }
        #region Métodos
        private static int Menu()
        {
            int opc;
            Console.Clear();
            Console.WriteLine("Cálculo de Área");
            Console.WriteLine("1.- Cálculo de Cuadrado");
            Console.WriteLine("2.- Cálculo de Triángulo");
            Console.WriteLine("3.- Cálculo de Círculo");
            Console.WriteLine("4.- Salir");
            Console.Write("\nOpcion: ");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }
        #endregion
    }
}
