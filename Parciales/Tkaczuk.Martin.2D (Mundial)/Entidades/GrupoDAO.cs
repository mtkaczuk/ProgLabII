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
        private static SqlCommand command;
        private static SqlConnection connection;

        public GrupoDAO()
        {
            connection = new SqlConnection(Entidades.Properties.Settings.Default.ConeccionString);
            command = new SqlCommand();
        }

        public Grupo ObtieneGrupo(Grupo grupo)
        {
            try
            {
                string query;
                query = string.Format("SELECT * FROM dbo.Equipo WHERE grupo = '{0}'", grupo.Letra.ToString());
                command.CommandText = query;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                connection.Open();
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    Equipo nuevoEquipo = new Equipo((int)data[1], data[2].ToString());
                    grupo = grupo + nuevoEquipo;
                }
            }
            catch (SqlException exSQL)
            {
                throw exSQL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    connection.Close();
                }				
            }

            return grupo;
        }
    }
}
