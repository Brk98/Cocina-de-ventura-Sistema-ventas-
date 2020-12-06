using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using La_Cocina_de_Ventura2.Clases;

namespace La_Cocina_de_Ventura2.Menu
{
    public partial class EspecialesMenu : UserControl
    {
        public EspecialesMenu()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        private void EspecialesB_Click(object sender, EventArgs e)
        {
            int crelleno = Convert.ToInt32(Math.Round(ChileRelleno.Value, 0));
            double precio = 0;
            if (crelleno > 0)
            {
                string producto = "Chile Relleno";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        crelleno,
                        precio*crelleno
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);

            }
        }
    }
}
