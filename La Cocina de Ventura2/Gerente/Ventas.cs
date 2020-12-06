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
    public partial class Ventas : UserControl
    {
        Cls_Gerente funciones = new Cls_Gerente();
        Cls_Principal ObjPrin = new Cls_Principal();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Today;
            String fecha = today.ToString("yyyy") + "-" + today.ToString("MM") + "-" + today.ToString("dd");
            Titulo_ventas.Text = "Ventas del dia "+fecha;
            dgvVentas.DataSource = funciones.MostrarVentas(fecha);
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
