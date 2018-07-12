using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {
        #region Variables
        private List<Grupo> grupos;
        private string nombre;
        public const int MAX_EQUIPOS_GRUPO = 4;
        #endregion

        #region Propiedades
        public List<Grupo> Grupos
        {
            get
            {
                return this.grupos;
            }
        }
        #endregion

        #region Constructores
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }
        #endregion

        #region Implementaciones Interfaz
        public bool Leer()
        {
            return false;
        }

        public bool Guardar()
        {
            bool ret = false;
            try
            {
                foreach (Grupo grupo in grupos)
                {
                    string archivo = string.Format("grupo-{0}.xml", grupo.Letra);
                    XmlSerializer serializer = new XmlSerializer(typeof(Grupo));
                    XmlTextWriter writer = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + archivo, Encoding.UTF8);
                    serializer.Serialize(writer, grupo);
                    writer.Close();
                    ret = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }
        #endregion
    }
}
