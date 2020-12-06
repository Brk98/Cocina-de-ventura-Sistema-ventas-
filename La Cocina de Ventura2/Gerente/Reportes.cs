using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2.Gerente
{
    public partial class Reportes : UserControl
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void FechaInicial_Click(object sender, EventArgs e)
        {

        }

        private void CFechaInicial_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaInicial.Text = CFechaInicial.SelectionRange.Start.ToString();
        }

        private void CFechaFinal_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaFinal.Text = CFechaFinal.SelectionRange.Start.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FechaFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
