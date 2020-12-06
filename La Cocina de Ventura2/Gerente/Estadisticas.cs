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
    public partial class Estadisticas : UserControl
    {
        Cls_Gerente Obj_Gerente = new Cls_Gerente();
        String Fecha_inicial;
        String Fecha_Final_v;
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        public void CFechaInicial_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaInicial.Text = CFechaInicial.SelectionRange.Start.ToString();
            Fecha_inicial = CFechaInicial.SelectionRange.Start.ToString("yyyy")+"-"+ CFechaInicial.SelectionRange.Start.ToString("MM")+"-"+ CFechaInicial.SelectionRange.Start.ToString("dd");
            FechaInicial.Text = Fecha_inicial;
        }

        public void CFechaFinal_DateChanged(object sender, DateRangeEventArgs e)
        {
            //FechaFinal.Text = CFechaFinal.SelectionRange.Start.ToString();
            Fecha_Final_v = CFechaFinal.SelectionRange.Start.ToString("yyyy") + "-" + CFechaFinal.SelectionRange.Start.ToString("MM") + "-" + CFechaFinal.SelectionRange.Start.ToString("dd");
            FechaFinal.Text = Fecha_Final_v;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Obj_Gerente.ValidarFechas(Fecha_inicial, Fecha_Final_v) == false)
            {
                MessageBox.Show("En el rango de fecha seleccionado no se tienen resultados revise las fechas nuevamente.");
            }
            else
            {
                int[,] Matriz = Obj_Gerente.Coincididencia(Fecha_inicial, Fecha_Final_v);
                double[] Arreglo_totales = new double[20];
                double[] Arreglo_porcentajes = new double[20];
                double total = 0.00;
                int valor;
                double g, q, s, r;
                valor = Matriz.GetLength(0) - 1;

                for (int i = 1; i <= 18; i++)
                {
                    for (int j = 1; j <= valor; j++)
                    {
                        Arreglo_totales[i] = Arreglo_totales[i] + Matriz[j, i];
                        total = total + Matriz[j, i];
                    }
                }
                for (int i = 1; i <= 18; i++)
                {
                    Arreglo_porcentajes[i] = (Arreglo_totales[i] * 100) / total;
                }
                Obj_Gerente.Coincididencia(Fecha_inicial, Fecha_Final_v);
                //Gorditas
                PorcGorditasComalCQ.Text = Arreglo_porcentajes[1].ToString("F") + "%";
                PorcGorditasComalSQ.Text = Arreglo_porcentajes[2].ToString("F") + "%";
                PorcGorditaDoradaCQ.Text = Arreglo_porcentajes[3].ToString("F") + "%";
                PorcGorditaDoradaSQ.Text = Arreglo_porcentajes[4].ToString("F") + "%";
                //Gorditas total
                g = Arreglo_porcentajes[1] + Arreglo_porcentajes[2] + Arreglo_porcentajes[3] + Arreglo_porcentajes[4];
                PorcGorditas.Text = g.ToString("F") + "%";

                //Quesadillas
                PorcQuesadillaComal.Text = Arreglo_porcentajes[5].ToString("F") + "%";
                PorcQuesadillaDorada.Text = Arreglo_porcentajes[6].ToString("F") + "%";
                //Quesadillas total
                q = Arreglo_porcentajes[5] + Arreglo_porcentajes[6];
                PorcQuesadillas.Text = q.ToString("F") + "%";

                //Sopes
                PorcSopeSencillo.Text = Arreglo_porcentajes[7].ToString("F") + "%";
                PorcSopeGuisado.Text = Arreglo_porcentajes[8].ToString("F") + "%";
                //Tacos
                PorcTacos.Text = Arreglo_porcentajes[9].ToString("F") + "%";
                //Platos
                PorcPlatoChico.Text = Arreglo_porcentajes[10].ToString("F") + "%";
                PorcPlatoGrande.Text = Arreglo_porcentajes[11].ToString("F") + "%";
                //Sopes Tacos Platos totales
                s = Arreglo_porcentajes[7] + Arreglo_porcentajes[8] + Arreglo_porcentajes[9] + Arreglo_porcentajes[10] + Arreglo_porcentajes[11];
                PorcSopesTacos.Text = s.ToString("F") + "%";

                //Refrescos
                PorcRefrescos.Text = Arreglo_porcentajes[12].ToString("F") + "%";
                PorcDesechables.Text = Arreglo_porcentajes[13].ToString("F") + "%";
                PorcCocaDesechable.Text = Arreglo_porcentajes[14].ToString("F") + "%";
                PorcBebidasCalientes.Text = Arreglo_porcentajes[15].ToString("F") + "%";
                PorcNescafe.Text = Arreglo_porcentajes[16].ToString("F") + "%";
                //Refrescos totales
                r = Arreglo_porcentajes[12] + Arreglo_porcentajes[13] + Arreglo_porcentajes[14] + Arreglo_porcentajes[15] + Arreglo_porcentajes[16];
                PorcBebidas.Text = r.ToString("F") + "%";

                //Bolillos
                PorcBolilloGuisado.Text = Arreglo_porcentajes[17].ToString("F") + "%";
                //Bolillos totales
                PorcTortas.Text = Arreglo_porcentajes[17].ToString("F") + "%";

                //Especiales
                PorcChileRelleno.Text = Arreglo_porcentajes[18].ToString("F") + "%";
                //Total especiales
                PorcEspeciales.Text = Arreglo_porcentajes[18].ToString("F") + "%";
            }
        }
    }
}
