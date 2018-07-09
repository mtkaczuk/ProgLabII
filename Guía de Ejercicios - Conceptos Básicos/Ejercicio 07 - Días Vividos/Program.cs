using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07___Días_Vividos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 07 - Días Vividos";
            #endregion

            #region Variables
            DateTime fechaNacimiento07;
            DateTime hoy07 = DateTime.Now;
            TimeSpan diferencia07;
            #endregion

            Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
            fechaNacimiento07 = DateTime.Parse(Console.ReadLine());

            #region Validación
            if (!ValidaFechaDeNacimiento(fechaNacimiento07))
            {
                Console.Write("¡Error! Ingresaste una fecha de nacimiento incorrecta\n");
                Console.Write("Ingrese un fecha de nacimiento: ");
                fechaNacimiento07 = DateTime.Parse(Console.ReadLine());
            }
            #endregion

            diferencia07 = CalculaDiferencia(fechaNacimiento07, hoy07);

            #region Resultados
            Console.WriteLine("La fecha de nacimiento es: {0}", fechaNacimiento07.ToString("dd/MM/yyyy"));
            Console.WriteLine("La fecha de hoy es: {0}", hoy07.Date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Los dias de vida vividos son: {0}", diferencia07.Days);
            Console.ReadLine();
            #endregion
        }
        #region Métodos
        private static bool ValidaFechaDeNacimiento(DateTime nacimiento)
        {
            string minimo = "01/01/1000";
            string maximo = "31/12/9999";
            DateTime DiaMinimo = DateTime.Parse(minimo);
            DateTime DiaMaximo = DateTime.Parse(maximo);
            if (nacimiento >= DiaMinimo && nacimiento <= DiaMaximo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static TimeSpan CalculaDiferencia(DateTime fechadenacimiento, DateTime hoy)
        {
            TimeSpan diferencia;
            diferencia = hoy - fechadenacimiento;
            return diferencia;
        }
        #endregion
    }
}
