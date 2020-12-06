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
    class Cls_Gerente
    {
        private string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=cocina_de_ventura;UID=root;PASSWORDS=;";

        public bool ActualizarPrecios(String valor, int i)
        {
            MySqlConnection cn = new MySqlConnection(conexion);
            cn.Open();
            String insertar = ("UPDATE `productos` SET `Precio_Producto` = '" + valor + "' WHERE `productos`.`ID_Producto` = " + i);
            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return false;
        }
        public List<Venta> MostrarVentas(String fecha)
        {
            List<Venta> lista = new List<Venta>();
            MySqlConnection cn = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=cocina_de_ventura;UID=root;PASSWORDS=;");
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("SELECT * FROM `ordenes` WHERE `Fecha_Orden` = '" + fecha + "'");
            MySqlDataReader leer = codigo.ExecuteReader();

            while (leer.Read())
            {
                Venta a = new Venta();
                a.Id = leer.GetInt32(0);
                a.Fecha = leer.GetString(1);
                a.Cantidad = leer.GetString(2);
                lista.Add(a);
            }

            return lista;
        }
        public int[,] Coincididencia(String fecha1, String fecha2)
        {
           
            int n;
            MySqlConnection cn = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=cocina_de_ventura;UID=root;PASSWORDS=;");
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("SELECT COUNT(`ID_Orden`) FROM `ordenes` WHERE `Fecha_Orden` >= '"+fecha1+ "' AND `Fecha_Orden` <= '" + fecha2 + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            n = leer.GetInt32(0);
            int[] Id_orden = new int[n+1];
            leer.Close();
            codigo.CommandText = ("SELECT `ID_Orden` FROM `ordenes` WHERE `Fecha_Orden` >= '" + fecha1 + "' AND `Fecha_Orden` <= '" + fecha2 + "'");
            MySqlDataReader leer2 = codigo.ExecuteReader();
            int i = 0;
            while (leer2.Read())
            {
                i = i + 1;
                Id_orden[i] = leer2.GetInt32(0);
            }
            leer2.Close();
            int[,] Matriz = new int[n+1, 19];
            
            for (i = 1; i <= n; i++)
            {
                codigo.CommandText = ("SELECT * FROM `cant_ordenes` WHERE `id_ordenes_cant` = " + Id_orden[i]);
                MySqlDataReader leer3 = codigo.ExecuteReader();
                while (leer3.Read())
                {
                    int j = 1;
                    //For para no escribir todo 18 veces equivalente a los 18 campos de las comidas
                    for(j = 1; j <= 18; j++)
                    {
                       Matriz[i, j] = leer3.GetInt32(j);
                    }
                }
                leer3.Close();
            }
            
            return Matriz;
        }

        public bool ValidarFechas(String fecha1, String fecha2)
        {
            MySqlConnection cn = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=cocina_de_ventura;UID=root;PASSWORDS=;");
            cn.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = cn;
            codigo.CommandText = ("SELECT COUNT(`ID_Orden`) FROM `ordenes` WHERE `Fecha_Orden` >= '" + fecha1 + "' AND `Fecha_Orden` <= '" + fecha2 + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();

            if (leer.GetInt32(0) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
