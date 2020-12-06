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

namespace La_Cocina_de_Ventura2.Gerente
{
    public partial class Precios : UserControl
    {
        public Precios()
        {
            InitializeComponent();
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        Cls_Gerente ObjGerente = new Cls_Gerente();
        public String[] actualizar = new string[19];
        private void Precios_Load(object sender, EventArgs e)
        {
            int gcomalcq = Convert.ToInt32(Math.Round(PGorditasComalCQ.Value, 0));
            int gcomalsq = Convert.ToInt32(Math.Round(PGorditasComalSQ.Value, 0));
            int gdoradassq = Convert.ToInt32(Math.Round(GorditaDoradaCQ.Value, 0));
            int gdoradascq = Convert.ToInt32(Math.Round(GorditaDoradaSQ.Value, 0));
            int qcomal = Convert.ToInt32(Math.Round(PQuesadillasComal.Value, 0));
            int qdoradas = Convert.ToInt32(Math.Round(PQuesadillaDorada.Value, 0));
            int ssencillo = Convert.ToInt32(Math.Round(PSopeSencillo.Value, 0));
            int sguisado = Convert.ToInt32(Math.Round(PSopeGuisado.Value, 0));
            int stacos = Convert.ToInt32(Math.Round(PTacos.Value, 0));
            int pchico = Convert.ToInt32(Math.Round(PPlatoChico.Value, 0));
            int pgrande = Convert.ToInt32(Math.Round(PPlatoGrande.Value, 0));
            int vrefrescos = Convert.ToInt32(Math.Round(PRefrescos.Value, 0));
            int vdesechables = Convert.ToInt32(Math.Round(PDesechales.Value, 0));
            int vcoca = Convert.ToInt32(Math.Round(PCocaDesechable.Value, 0));
            int vbebidas = Convert.ToInt32(Math.Round(PBebidasCalientes.Value, 0));
            int vnescafe = Convert.ToInt32(Math.Round(PNescafe.Value, 0));
            int vbolillo = Convert.ToInt32(Math.Round(PBolilloGuisado.Value, 0));
            int crelleno = Convert.ToInt32(Math.Round(PChileRelleno.Value, 0));
            double precio = 0;
            
            if(gcomalcq<1)
            {
                string producto = "Gordita de Comal c/Queso";
                precio = ObjPrin.FunDamePrecio(producto);
                PGorditasComalCQ.Value = Convert.ToInt32(precio);


            }
            if (gcomalsq< 1)
            {
                string producto = "Gordita de Comal sin Ques";
                precio = ObjPrin.FunDamePrecio(producto);
                PGorditasComalSQ.Value = Convert.ToInt32(precio);
            }
            if (gdoradascq < 1)
            {
                string producto = "Gordita Dorada c/Queso";
                precio = ObjPrin.FunDamePrecio(producto);
                GorditaDoradaCQ.Value = Convert.ToInt32(precio);
            }
            if (gdoradassq < 1)
            {
                string producto = "Gordita Dorada sin Queso";
                precio = ObjPrin.FunDamePrecio(producto);
                GorditaDoradaSQ.Value = Convert.ToInt32(precio);
            }
            //
            if (qcomal < 1)
            {
                string producto = "Quesadilla de Comal";
                precio = ObjPrin.FunDamePrecio(producto);
                PQuesadillasComal.Value = Convert.ToInt32(precio);
            }
            if (qdoradas < 1)
            {
                string producto = "Quesadilla Dorada";
                precio = ObjPrin.FunDamePrecio(producto);
                PQuesadillaDorada.Value = Convert.ToInt32(precio);
                
            }
            //
            if (ssencillo < 1)
            {
                string producto = "Sope Sencillo";
                precio = ObjPrin.FunDamePrecio(producto);
                PSopeSencillo.Value = Convert.ToInt32(precio);
                
            }
            if (sguisado < 1)
            {
                string producto = "Sope con Guisado";
                precio = ObjPrin.FunDamePrecio(producto);
                PSopeGuisado.Value = Convert.ToInt32(precio);
                
            }
            if (stacos < 1)
            {
                string producto = "Tacos";
                precio = ObjPrin.FunDamePrecio(producto);
                PTacos.Value = Convert.ToInt32(precio);
                
            }
            if (pchico < 1)
            {
                string producto = "Plato Chico";
                precio = ObjPrin.FunDamePrecio(producto);
                PPlatoChico.Value = Convert.ToInt32(precio);
                
            }
            if (pgrande < 1)
            {
                string producto = "Plato Grande";
                precio = ObjPrin.FunDamePrecio(producto);
                PPlatoGrande.Value = Convert.ToInt32(precio);
                
            }
            //
            if (vrefrescos < 1)
            {
                string producto = "Refrescos";
                precio = ObjPrin.FunDamePrecio(producto);
                PRefrescos.Value = Convert.ToInt32(precio);
                
            }
            if (vdesechables < 1)
            {
                string producto = "Refrescos Desechables";
                precio = ObjPrin.FunDamePrecio(producto);
                PDesechales.Value = Convert.ToInt32(precio);
                
            }
            if (vcoca < 1)
            {
                string producto = "Coca-Cola Desechable";
                precio = ObjPrin.FunDamePrecio(producto);
                PCocaDesechable.Value = Convert.ToInt32(precio);
                
            }
            if (vbebidas < 1)
            {
                string producto = "Bebidas Calientes";
                precio = ObjPrin.FunDamePrecio(producto);
                PBebidasCalientes.Value = Convert.ToInt32(precio);
                
            }
            if (vnescafe < 1)
            {
                string producto = "Nescafé";
                precio = ObjPrin.FunDamePrecio(producto);
                PNescafe.Value = Convert.ToInt32(precio);
                
            }
            //
            if (vbolillo< 1)
            {
                string producto = "Bolillo con Guisado";
                precio = ObjPrin.FunDamePrecio(producto);
                PBolilloGuisado.Value = Convert.ToInt32(precio);
                
            }
            //
            if (crelleno < 1)
            {
                string producto = "Chile Relleno";
                precio = ObjPrin.FunDamePrecio(producto);
                PChileRelleno.Value = Convert.ToInt32(precio);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar[1] = PGorditasComalCQ.Value.ToString();
            actualizar[2] = PGorditasComalSQ.Value.ToString();
            actualizar[3] = GorditaDoradaCQ.Value.ToString();
            actualizar[4] = GorditaDoradaSQ.Value.ToString();
            actualizar[5] = PQuesadillasComal.Value.ToString();
            actualizar[6] = PQuesadillaDorada.Value.ToString();
            actualizar[7] = PSopeSencillo.Value.ToString();
            actualizar[8] = PSopeGuisado.Value.ToString();
            actualizar[9] = PTacos.Value.ToString();
            actualizar[10] = PPlatoChico.Value.ToString();
            actualizar[11] = PPlatoGrande.Value.ToString();
            actualizar[12] = PRefrescos.Value.ToString();
            actualizar[13] = PDesechales.Value.ToString();
            actualizar[14] = PCocaDesechable.Value.ToString();
            actualizar[15] = PBebidasCalientes.Value.ToString();
            actualizar[16] = PNescafe.Value.ToString();
            actualizar[17] = PBolilloGuisado.Value.ToString();
            actualizar[18] = PChileRelleno.Value.ToString();

            for (int i = 1; i <= 18; i++)
            {
                ObjGerente.ActualizarPrecios(actualizar[i],i);
            }
            
        }
    }
}