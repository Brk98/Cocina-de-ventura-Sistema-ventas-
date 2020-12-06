using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace La_Cocina_de_Ventura2.Clases
{
    class Cls_Principal
    {
        public static string varUsuario = string.Empty;
        public static string varContras = string.Empty;
        public static string varTipo = string.Empty;
        public static string varid = string.Empty;
        public static string varTotal = string.Empty;
        private string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=cocina_de_ventura;UID=root;PASSWORDS=;";
        public void CalculaTotal(DataTable SumaTotal)
        {
            // --- Cálculamos el total pagado
            double varMonPaga=0;
            double varPagado_ = 0;
            foreach (DataRow objDataRow in SumaTotal.Rows)
            {
                varMonPaga = Convert.ToDouble(objDataRow["SubTotal"].ToString());
                varPagado_ += varMonPaga;
                varTotal = varPagado_.ToString();
            }
            Form2.DtTotal.Rows.Clear();
            Form2.DtTotal.Rows.Add
                (
                    new object[]
                    {
                        varPagado_
                    }
                );
            //Form2.dvgTotal.ColumnHeadersDefaultCellStyle.Font = new Font("Agency FB", 16, FontStyle.Bold);
        }
        public bool Login(string Usuario, string Contraseña)
        {
  
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("select * from usuarios where usuario = '" + Usuario+ "' and password = '" + Contraseña+"' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                varTipo = ""  + leer["tipo"];
                return true;
            }
            return false;
            cn.Close();
        }
   
        public double FunDamePrecio(string ParProducto)
        {
            double VarPrecio = 0;
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("select * from productos where Nombre_Producto = '" + ParProducto + "' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                VarPrecio = Convert.ToDouble(leer["Precio_Producto"]);
                return VarPrecio;
            }
            cn.Close();

            return VarPrecio;
        }
        public Boolean GuardarOrden(String time, String total)
        {
       
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("INSERT INTO ordenes (Fecha_Orden,total) VALUES('"+time+ "','"+total+"')");
            try
            {
                codigo.ExecuteNonQuery();
                return true;

            }
            catch
            {

            }

                return false;
        }
        public Boolean GuardarContenidoOrdenCargar()
        {

            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            
            String insertar = ("INSERT INTO `cant_ordenes` (`Gordita de Comal c/Queso`, `Gordita de Comal sin Ques`, `Gordita Dorada c/Queso`, `Gordita Dorada sin Queso`, `Quesadilla de Comal`, `Quesadilla Dorada`, `Sope Sencillo`, `Sope con Guisado`, `Tacos`, `Plato Chico`, `Plato Grande`, `Refrescos`, `Refrescos Desechables`, `Coca-Cola Desechable`, `Bebidas Calientes`, `Nescafe`, `Bolillo con Guisado`, `Chile Relleno`) VALUES ('0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0')");
            MySqlCommand cmd = new MySqlCommand(insertar,cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return false;
        }
        public Boolean FunDameIdOrden()
        {
            String VarOrId = "";
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("SELECT id_ordenes_cant FROM cant_ordenes ORDER BY id_ordenes_cant DESC LIMIT 1");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                varid = "" + leer["id_ordenes_cant"];
               
                
            }
            cn.Close();

            return true;
        }
        public Boolean GuardarContenidoOrden(String nombre, String cantidad, String id)
        {
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            String insertar = ("UPDATE `cant_ordenes` SET `" + nombre + "` = '" + cantidad + "' WHERE `cant_ordenes`.`id_ordenes_cant` = " + id);
            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.ExecuteNonQuery();
            
            cn.Close();
           

            return false;
        }



        public Cls_DataReader drSQL(string parstrSQL)
        {
            Cls_Conexion objCnxOrac = new Cls_Conexion();
            SqlConnection objConnect = new SqlConnection();
            SqlCommand objCommand = new SqlCommand();
            Cls_DataReader objDataRea = new Cls_DataReader();
            SqlDataReader sqlDataRea;

            try
            {
                objConnect = objCnxOrac.conSqlServ();
                objConnect.Open();
                objCommand.Connection = objConnect;
                objCommand.CommandText = parstrSQL;
                sqlDataRea = objCommand.ExecuteReader();
                objDataRea.drSQL = sqlDataRea;
                objDataRea.conSQL = objConnect;
            }
            catch (Exception ex)
            {
                object p = MessageBox.Show("No pude generar el DR de SQL. ERROR: " +
                    Convert.ToString(ex));
            }

            return objDataRea;
        }
    }
}
