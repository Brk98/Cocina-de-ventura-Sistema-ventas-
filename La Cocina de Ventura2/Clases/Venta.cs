using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Cocina_de_Ventura2.Clases
{
    public class Venta
    {
        public int Id { get; set; }
        public String Fecha { get; set; }
        public String Cantidad { get; set; }
        public Venta() { }

        public Venta(int Id, String Fecha, String Cantidad)
        {
            this.Id = Id;
            this.Fecha = Fecha;
            this.Cantidad = Cantidad;
        }
    }
}
