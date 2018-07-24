using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantidadMaximaProductos : Exception
    {
        #region Constructores
        public CantidadMaximaProductos()
        {
        }

        public CantidadMaximaProductos(string message) : base(message)
        {
        }

        public CantidadMaximaProductos(string message, Exception innerException) : base(message, innerException)
        {
        }
        #endregion
    }
}
