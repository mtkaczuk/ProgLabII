using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08___Recibo_Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio 08 - Recibo Empleado";
            #endregion

            #region Variables
            int antiguedad08, totalAntiguedadEmpleado08;
            double valorHora08, cantHorasMes08, totalHorasEmpleado08, totalSueldoBrutoEmpleado08, totalDescuentosEmpleado08, totalSueldoNetoEmpleado08;
            string nombreApellido08;
            #endregion

            #region Carga de Datos y Validaciones
            Console.Write("Ingrese el Nombre del Empleado: ");
            nombreApellido08 = Console.ReadLine();

            Console.Write("Ingrese el Valor Hora de {0}: $", nombreApellido08);
            valorHora08 = double.Parse(Console.ReadLine());
            if (!ValidarHoras(valorHora08))
            {
                Console.WriteLine("¡Error! El valor Hora no puede ser menor a 0.");
                Console.Write("Por favor, reingrese la Cantidad Mensual de Horas Trabajadas por {0}: ", nombreApellido08);
                valorHora08 = double.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese la Antigüedad de {0}: ", nombreApellido08);
            antiguedad08 = int.Parse(Console.ReadLine());
            if (!ValidarHoras(antiguedad08))
            {
                Console.WriteLine("¡Error! La Antigüedad de {0} no puede ser menor a 0.");
                Console.Write("Por favor, reingrese la antigüedad de {0}: ", nombreApellido08);
                antiguedad08 = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese la Cantidad Mensual de Horas Trabajadas por {0}: ", nombreApellido08);
            cantHorasMes08 = double.Parse(Console.ReadLine());
            if (!ValidarHoras(cantHorasMes08))
            {
                Console.WriteLine("¡Error! La cantidad de horas trabajadas por {0} no puede ser menor a 0.");
                Console.Write("Por favor, reingrese la Cantidad Mensual de Horas Trabajadas por {0}: ", nombreApellido08);
                cantHorasMes08 = double.Parse(Console.ReadLine());
            }
            #endregion

            #region Asignaciones
            totalHorasEmpleado08 = CalcularTotalHoras(valorHora08, cantHorasMes08);
            totalAntiguedadEmpleado08 = CalcularAntiguedad(antiguedad08);
            totalSueldoBrutoEmpleado08 = CalcularSueldoBruto(totalHorasEmpleado08, totalAntiguedadEmpleado08);
            totalDescuentosEmpleado08 = CalcularDescuentos(totalSueldoBrutoEmpleado08);
            totalSueldoNetoEmpleado08 = CalcularSueldoNeto(totalSueldoBrutoEmpleado08, totalDescuentosEmpleado08);
            #endregion

            #region Resultados
            Console.Clear();
            Console.WriteLine("Los Datos del Empleados son: \n");
            Console.WriteLine("Nombre: {0}", nombreApellido08);
            Console.WriteLine("Antiguedad: {0} años", antiguedad08);
            Console.WriteLine("Valor Hora: ${0}", valorHora08);
            Console.WriteLine("Sueldo Bruto: ${0}", totalSueldoBrutoEmpleado08);
            Console.WriteLine("Descuentos: ${0}", totalDescuentosEmpleado08);
            Console.WriteLine("Sueldo Neto: ${0}", totalSueldoNetoEmpleado08);
            Console.ReadLine();
            #endregion
        }
        #region Métodos
        private static bool ValidarAntiguedad(int antiguedad)
        {
            if (antiguedad >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ValidarHoras(double horas)
        {
            if (horas >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool ValidarValorHoras(float valorHora)
        {
            if (valorHora >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Cálculos
        private static double CalcularTotalHoras(double valorHora, double horasPorMes)
        {
            double totalHorasMes = valorHora * horasPorMes;
            return totalHorasMes;
        }
        private static int CalcularAntiguedad(int aniosAntiguedad)
        {
            int totalAntiguedad = aniosAntiguedad * 150;
            return totalAntiguedad;
        }
        private static double CalcularSueldoBruto(double totalHoras, int totalAntiguedad)
        {
            double totalSueldoBruto = totalHoras + totalAntiguedad;
            return totalSueldoBruto;
        }
        private static double CalcularDescuentos(double totalBruto)
        {
            double totalDescuentos = totalBruto * 0.13;
            return totalDescuentos;
        }
        private static double CalcularSueldoNeto(double totalBruto, double totalDescuentos)
        {
            double totalSueldoNeto = totalBruto - totalDescuentos;
            return totalSueldoNeto;
        }
        #endregion
    }
}
