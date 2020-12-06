using System.Data.SqlClient;

namespace La_Cocina_de_Ventura2.Clases
{
    class Cls_DataReader
    {
        public SqlDataReader drSQL
        {
            get;
            set;
        }
        public SqlConnection conSQL
        {
            get;
            set;
        }
    }
}
