using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2.Clases
{
    class Cls_Conexion
    {
        public SqlConnection conSqlServ()
        {

            string connString = "Data Source     =LAPTOP-EESFSTBC; " +
                                "Initial Catalog =VenturaBD; " +
                                "User ID         =user; " +
                                "Password        =admin; ";

            try // Hacemos conexión a la base de datos
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connString;
                return conn;
            }
            catch (Exception ex) // Si ocurré un error mandamos un mensaje mostrando el error generado
            {
                MessageBox.Show("Problemas al hacer conexión: " + Convert.ToString(ex),
                                "Conexión errónea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool cerrarConexion(SqlConnection conexion)
        {
            if (conexion != null)
            {
                try
                {
                    conexion.Close();
                    conexion.Dispose();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
