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
    public partial class BebidasMenu : UserControl
    {
        public BebidasMenu()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        private void Bebidas_Click(object sender, EventArgs e)
        {
            
            int vrefrescos = Convert.ToInt32(Math.Round(Refrescos.Value, 0));
            int vdesechables = Convert.ToInt32(Math.Round(Desechables.Value, 0));
            int vcoca = Convert.ToInt32(Math.Round(CocaDesechable.Value, 0));
            int vbebidas = Convert.ToInt32(Math.Round(BebidasCalientes.Value, 0));
            int vnescafe = Convert.ToInt32(Math.Round(Nescafe.Value, 0));
            double precio;
            if (vrefrescos > 0)
            {
                string producto = "Refrescos";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vrefrescos,
                        precio*vrefrescos
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (vdesechables > 0)
            {
                string producto = "Refrescos Desechables";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vdesechables,
                        precio*vdesechables
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (vcoca > 0)
            {
                string producto = "Coca-Cola Desechable";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vcoca,
                        precio*vcoca
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (vbebidas > 0)
            {
                string producto = "Bebidas Calientes";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vbebidas,
                        precio*vbebidas
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
            if (vnescafe > 0)
            {
                string producto = "Nescafe";
                precio = ObjPrin.FunDamePrecio(producto);

                Form2.DtProductos.Rows.Add
                (
                    new object[]
                    {
                        producto,
                        vnescafe,
                        precio*vnescafe
                    }
                );
                ObjPrin.CalculaTotal(Form2.DtProductos);
            }
        }
    }
}
