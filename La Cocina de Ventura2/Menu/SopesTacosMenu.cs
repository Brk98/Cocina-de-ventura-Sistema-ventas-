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
    public partial class SopesTacosMenu : UserControl
    {
        Cls_Principal ObjPrin = new Cls_Principal();
        public SopesTacosMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SopesTacosB_Click(object sender, EventArgs e)
        {
            int ssencillo = Convert.ToInt32(Math.Round(SopeSencillo.Value, 0));
            int sguisado = Convert.ToInt32(Math.Round(SopeGuisado.Value, 0));
            int stacos = Convert.ToInt32(Math.Round(Tacos.Value, 0));
            int pchico = Convert.ToInt32(Math.Round(PlatoChico.Value, 0));
            int pgrande = Convert.ToInt32(Math.Round(PlatoGrande.Value, 0));
            double precio = 0;
            if (ssencillo > 0)
            {
                string producto = "Sope Sencillo";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        ssencillo,
                        precio*ssencillo
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (sguisado > 0)
            {
                string producto = "Sope con Guisado";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        sguisado,
                        precio*sguisado
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (stacos > 0)
            {
                string producto = "Tacos";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        stacos,
                        precio*stacos
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (pchico> 0)
            {
                string producto = "Plato Chico";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        pchico,
                        precio*pchico
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (pgrande > 0)
            {
                string producto = "Plato Grande";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        pgrande,
                        precio*pgrande
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
        }
    }
}
