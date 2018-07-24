using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MaterialException : Exception
    {
        #region Constructores
        public MaterialException()
        {
        }

        public MaterialException(string message) : base(message)
        {
        }

        public MaterialException(string message, Exception innerException) : base(message, innerException)
        {
        }
        #endregion
    }
}
