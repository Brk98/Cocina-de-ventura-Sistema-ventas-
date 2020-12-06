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
    public partial class QuesadillasMenu : UserControl
    {
        public QuesadillasMenu()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        private void QuesadillaB_Click(object sender, EventArgs e)
        {
            int qcomal = Convert.ToInt32(Math.Round(QuesadillaComal.Value, 0));
            int qdoradas = Convert.ToInt32(Math.Round(QuesadillaDorada.Value, 0));
            double precio = 0;


            if (qcomal > 0)
            {
                string producto = "Quesadilla de Comal";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        qcomal,
                        precio*qcomal
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (qdoradas > 0)
            {
                string producto = "Quesadilla Dorada";
                precio = ObjPrin.FunDamePrecio(producto);
                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        qdoradas,
                        precio*qdoradas
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
        }

        private void QuesadillaComal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
