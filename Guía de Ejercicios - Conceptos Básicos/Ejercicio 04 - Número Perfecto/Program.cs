using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04___Número_Perfecto
{
    class Program
    {
        #region Variables de Clase
        static int NumerosPerfectos = 1;
        #endregion

        static void Main(string[] args)
        {
            #region Título
            Console.Title = "Ejercicio Nro 04 - Números Perfectos";
            #endregion
            
            #region Variables
            int contPerfectos = 1;
            const int consPerfecto = 10000;
            #endregion

            while (contPerfectos <= consPerfecto)
            {
                bool esPerfecto = EsNumeroPerfecto(contPerfectos);

                if (esPerfecto && (NumerosPerfectos > 1))
                {
                    Console.WriteLine("{0} es perfecto", NumerosPerfectos);
                }
                NumerosPerfectos = 1;
                contPerfectos++;
            }
            Console.ReadKey();
        }
        #region Métodos
        static bool EsNumeroPerfecto(int num)
        {
            int tempPerfectos;
            int cont = 2;
            bool EsPerfecto = false;

            while (cont <= (num - 1))
            {
                tempPerfectos = num % cont;
                if (tempPerfectos == 0)
                {
                    NumerosPerfectos = NumerosPerfectos + cont;
                }
                cont++;
            }

            if ((NumerosPerfectos) == num)
                EsPerfecto = true;
            else
                EsPerfecto = false;
            return EsPerfecto;
        }
        #endregion
    }
}
