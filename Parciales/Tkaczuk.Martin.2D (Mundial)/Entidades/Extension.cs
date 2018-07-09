using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        #region Métodos
        public static string FormatoTabla(this string myString, int espacios)
        {
            string retorno = String.Format("{0, 1}", myString, espacios);//revisar

            return "";
        }
        #endregion        
    }
}
