using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GrupoDAO
    {
        #region Variables
        static private SqlCommand comando;
        static private SqlConnection conexion;
        #endregion
            
        #region Constructores
        static GrupoDAO()
        {
            conexion = new SqlConnection(Entidades.Properties.Settings.Default.CadenaConexion);
            comando = new SqlCommand();
        }
        #endregion

        #region Métodos
        public Grupo ObtieneGrupo(Grupo grupo)
        {
            try
            {
                string query;
                query = string.Format("SELECT * FROM dbo.Equipos where grupo = '{0}'", grupo.LetraGrupo);
                comando.CommandText = query;
                comando.Connection = conexion;
                conexion.Open();
                SqlDataReader data = comando.ExecuteReader();

                Equipo nuevoEquipo = new Equipo((int)data[1], data[2].ToString());
                grupo = grupo + nuevoEquipo;
            }
            catch (SqlException et)
            {
                throw et;
            }
            catch (Exception ee)
            {
                throw ee;
            }
            finally
            {
                conexion.Close();
            }
            return grupo;
        }
        #endregion
    }
}
