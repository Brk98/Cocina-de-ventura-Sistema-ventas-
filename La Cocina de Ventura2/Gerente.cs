using La_Cocina_de_Ventura2.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2.Menu
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void Gerente_Load(object sender, EventArgs e)
        {

        }
        private void changeview(string vista)
        {
            UserControl PrecioPanel = new Precios();
            UserControl ReportePanel = new Reportes();
            UserControl VentasPanel = new Ventas();
            UserControl EstadisticasPanel = new Estadisticas();
            ContenedorGerente.Controls.Clear();
            switch (vista)
            {
                case "Precios":
                    ContenedorGerente.Controls.Add(PrecioPanel);
                    PrecioPanel.Dock = DockStyle.Fill;
                    break;
                case "Reportes":
                    ContenedorGerente.Controls.Add(ReportePanel);
                    ReportePanel.Dock = DockStyle.Fill;
                    break;
                case "Ventas":
                    ContenedorGerente.Controls.Add(VentasPanel);
                    VentasPanel.Dock = DockStyle.Fill;
                    break;
                case "Estadisticas":
                    ContenedorGerente.Controls.Add(EstadisticasPanel);
                    EstadisticasPanel.Dock = DockStyle.Fill;
                    break;
            }
        }
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeview("Precios");
        }

        private void ReportesB_Click(object sender, EventArgs e)
        {
            changeview("Reportes");
        }

        private void VentasB_Click(object sender, EventArgs e)
        {
            changeview("Ventas");
        }

        private void EstadisticasB_Click(object sender, EventArgs e)
        {
            changeview("Estadisticas");
        }
    }
}
