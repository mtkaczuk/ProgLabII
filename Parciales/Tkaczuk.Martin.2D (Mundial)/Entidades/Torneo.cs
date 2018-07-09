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
            bool retorno = false;
            try
            {
                for (int i = 0; i < this.grupos.Count; i++)
                {
                    string Archivo = String.Format("grupo-{0}.xml", this.grupos[i].LetraGrupo);
                    XmlTextWriter writer;
                    XmlSerializer ser;
                    writer = new XmlTextWriter(Archivo, Encoding.UTF32);
                    ser = new XmlSerializer(typeof(Grupo));
                    ser.Serialize(writer, this.grupos[i]);
                    writer.Close();
                    retorno = true;
                }
            }
            catch
            {
            }
            return retorno;
        }
        #endregion
    }
}
