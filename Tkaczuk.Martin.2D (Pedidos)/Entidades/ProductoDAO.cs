using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class ProductoDAO
    {
        #region Variables
        private string _connectionString;
        private static SqlConnection _conexion;
        private SqlCommand _comando;
        #endregion

        #region Constructores
        static ProductoDAO()
        {
            _conexion = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=final-20180712;Integrated Security=True");
        }
        #endregion

        #region Métodos
        public List<Producto> ObtenerProducto()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                Material auxMaterial = Material.Aluminio;

                string query;
                query = "SELECT * FROM dbo.Productos";

                _comando.CommandText = query;
                _comando.CommandType = System.Data.CommandType.Text;
                _comando.Connection = _conexion;
                _conexion.Open();

                SqlDataReader data = _comando.ExecuteReader();
                while (data.Read())
                {

                    if (string.Compare(data["material"].ToString(), Material.Aluminio.ToString()) == 0)
                    {
                        auxMaterial = Material.Aluminio;
                    }
                    else if (string.Compare(data["material"].ToString(), Material.Caucho.ToString()) == 0)
                    {
                        auxMaterial = Material.Caucho;
                    }
                    else if (string.Compare(data["material"].ToString(), Material.Plastico.ToString()) == 0)
                    {
                        auxMaterial = Material.Caucho;
                    }

                    if (data["tipo"].ToString() == "A")
                    {

                        ProductoA miProdA = new ProductoA
                        {
                            Descripcion = Convert.ToString(data["descripcion"]),
                            Diametro = Convert.ToInt16(data["diametro"]),
                            Material = auxMaterial

                        };
                        productos.Add(miProdA);
                    }
                    else if (data["tipo"].ToString() == "B")
                    {
                        ProductoB miProdB = new ProductoB(Convert.ToString(data["descripcion"]), Convert.ToInt16(data["alto"]), Convert.ToInt16(data["ancho"]), Convert.ToInt16(data["largo"]));
                        productos.Add(miProdB);
                    }
                }
                return productos;
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
                _conexion.Close();
            }
        }

        public bool GuardarProducto(Producto p)
        {
            return true;
        }
        #endregion

    }
}
