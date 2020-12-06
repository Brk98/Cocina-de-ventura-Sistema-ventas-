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
    public partial class TortasMenu : UserControl
    {
        public TortasMenu()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        private void TortasB_Click(object sender, EventArgs e)
        {
            int vbolillo = Convert.ToInt32(Math.Round(BolilloGuisado.Value, 0));
            double precio = 0;
            if (vbolillo > 0)
            {
                string producto = "Bolillo con Guisado";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vbolillo,
                        precio*vbolillo
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
        }
    }
}
