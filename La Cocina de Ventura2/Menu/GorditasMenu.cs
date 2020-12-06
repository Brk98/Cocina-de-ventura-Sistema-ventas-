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
    public partial class GorditasMenu : UserControl
    {
        public GorditasMenu()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        private void button1_Click(object sender, EventArgs e)
        {
            //Se toman los datos de la cantidad de productos pedidos
            int gcomalcq = Convert.ToInt32(Math.Round(GorditasComalcQ.Value, 0));
            int gcomalsq = Convert.ToInt32(Math.Round(GorditaComalsQ.Value, 0));
            int gdoradassq = Convert.ToInt32(Math.Round(GorditaDoradacQ.Value, 0));
            int gdoradascq = Convert.ToInt32(Math.Round(GorditaDoradasQ.Value, 0));
            double precio = 0;


            if(gcomalcq>0)
            {
                string producto= "Gordita de Comal c/Queso";
                precio = ObjPrin.FunDamePrecio(producto);//Se manda a llamar el precio de las gorditas
                
                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        gcomalcq,
                        precio*gcomalcq//Se calcula el subtotal
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);//Se llama a la funcion CalculaTotal para ir guardando el total de la venta
            }
            if (gcomalsq > 0)
            {
                string producto = "Gordita de Comal sin Ques";
                precio = ObjPrin.FunDamePrecio(producto);
                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        gcomalsq,
                        precio*gcomalsq
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (gdoradascq > 0)
            {
                string producto = "Gordita Dorada c/Queso";
                precio = ObjPrin.FunDamePrecio(producto);
                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        gdoradascq,
                        precio*gdoradascq
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (gdoradassq > 0)
            {
                string producto = "Gordita Dorada sin Queso";
                precio = ObjPrin.FunDamePrecio(producto);
                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        gdoradassq,
                        precio*gdoradassq
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
