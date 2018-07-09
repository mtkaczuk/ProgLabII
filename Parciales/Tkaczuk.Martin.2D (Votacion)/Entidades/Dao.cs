using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        public Votacion Leer(string nombre)
        {
            throw new NotImplementedException();           
        }

        public bool Guardar(string nombre, Votacion objeto)
        {
            // CREO UN OBJETO SQLCONECTION
            String connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=votacion-sp-2018;Integrated Security=True";            
            Dao._conexion = new SqlConnection(connectionStr);//
            // CREO UN OBJETO SQLCOMMAND
            Dao._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            Dao._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            Dao._comando.Connection = Dao._conexion;
            //TODO revisar si se busca que lo cree y lo modifique dependiendo de si esta creado 
            bool todoOk = true;
            string nombreAlumno = "Avila.Lucas.Ariel.2C";
            try
            {
                string sql = "INSERT INTO "+nombre+" (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES(";
                sql = sql + "'" + objeto.NombreLey + "'," + objeto.Afirmativos + "," + objeto.Negativos + "," + objeto.Abstencion + ",'" +nombreAlumno+ "')";
                // LE PASO LA INSTRUCCION SQL
                Dao._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                Dao._conexion.Open();

                // EJECUTO EL COMMAND
                Dao._comando.ExecuteNonQuery();

                todoOk = true;              
            }
            catch (Exception e)
            {
                todoOk = false;
                throw e;
            }
            finally
            {
                if (todoOk)
                    Dao._conexion.Close();
            }
            return todoOk;
        }
        
    }
}
