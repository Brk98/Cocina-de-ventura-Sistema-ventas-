using La_Cocina_de_Ventura2.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using La_Cocina_de_Ventura2.Clases;

namespace La_Cocina_de_Ventura2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        Cls_Principal ObjPrin = new Cls_Principal();
        public static DataTable DtProductos = new DataTable();
        public static DataTable DtTotal = new DataTable();
        public void ProCrearDataTable ()
        {
            DtProductos.Dispose();
            DtProductos.Columns.Clear();
            DtProductos.Clear();
            DtProductos.Columns.Add("Productos");
            DtProductos.Columns.Add("Cantidad");
            DtProductos.Columns.Add("SubTotal");
        }
        private void CalcularTotal()
        {
            DtTotal.Dispose();
            DtTotal.Columns.Clear();
            DtTotal.Clear();
            DtTotal.Columns.Add("T O T A L");
        }
        private void changeview(string vista)
        {
            UserControl GorditasPanel = new GorditasMenu();
            UserControl QuesadillasPanel = new QuesadillasMenu();
            UserControl SopesTacosPanel = new SopesTacosMenu();
            UserControl BebidasPanel = new BebidasMenu();
            UserControl TortasPanel = new TortasMenu();
            UserControl EspecialesPanel = new EspecialesMenu();
            Contenedor.Controls.Clear();
            switch (vista)
            {
                case "PanelGorditas":
                    Contenedor.Controls.Add(GorditasPanel);
                    GorditasPanel.Dock = DockStyle.Fill;
                    break;
                case "QuesadillasPanel":
                    Contenedor.Controls.Add(QuesadillasPanel);
                    QuesadillasPanel.Dock = DockStyle.Fill;
                    break;
                case "SopesTacosPanel":
                    Contenedor.Controls.Add(SopesTacosPanel);
                    SopesTacosPanel.Dock = DockStyle.Fill;
                    break;
                case "BebidasPanel":
                    Contenedor.Controls.Add(BebidasPanel);
                    BebidasPanel.Dock = DockStyle.Fill;
                    break;
                case "TortasPanel":
                    Contenedor.Controls.Add(TortasPanel);
                    TortasPanel.Dock = DockStyle.Fill;
                    break;
                case "EspecialesPanel":
                    Contenedor.Controls.Add(EspecialesPanel);
                    EspecialesPanel.Dock = DockStyle.Fill;
                    break;
            }
        }
        //Se muestra el panel de gorditas y se ocultan los demas
        private void GorditasI_Click(object sender, EventArgs e)
        {
            changeview("PanelGorditas");
        }
        //Se muestra el panel de Quesadillas y se ocultan las demas
        private void QuesadillasI_Click(object sender, EventArgs e)
        {
            changeview("QuesadillasPanel");
        }
        //Se muestra el panel de Sopes y Tacos, se ocultan los demas
        private void SopesTacosI_Click(object sender, EventArgs e)
        {
            changeview("SopesTacosPanel");
        }
        //Se muestra el panel de Bebidas y se ocultan los demas
        private void BebidasI_Click(object sender, EventArgs e)
        {
            changeview("BebidasPanel");
        }
        //Se muestra el pabel de Tortas y se ocultan los demas
        private void TortasI_Click(object sender, EventArgs e)
        {
            changeview("TortasPanel");
        }
        //Se muestra el panel de Especiales y se ocultan los demas
        private void EspecialesI_Click(object sender, EventArgs e)
        {
            changeview("EspecialesPanel");
        }
        //Boton para salir del sistema
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProCrearDataTable();
            CalcularTotal();
            ListaProductos.DataSource = DtProductos;
            dvgTotal.DataSource = DtTotal;
        }

        private void ListaProductos_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void ListaProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ListaProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orden_Click(object sender, EventArgs e)
        {
            string[,] datos = new String[DtProductos.Rows.Count,2];

            //Guardo las variables de la tabla en una matriz
            
            var today = DateTime.Now;
            String fecha = today.ToString("yyyy") + "-" + today.ToString("MM") + "-" + today.ToString("dd");
            String id;
            ObjPrin.GuardarOrden(fecha, Cls_Principal.varTotal);
            ObjPrin.GuardarContenidoOrdenCargar();
            ObjPrin.FunDameIdOrden();
            id = Cls_Principal.varid;
         
            
            for (int i = 0; i < DtProductos.Rows.Count; i++)
            {
                datos[i, 0] = DtProductos.Rows[i][0].ToString();
                datos[i, 1] = DtProductos.Rows[i][1].ToString();
                ObjPrin.GuardarContenidoOrden(datos[i,0], datos[i,1],id);
            }

            ListaProductos.Columns.Clear();
            DtProductos.Dispose();
            DtProductos.Columns.Clear();
            DtProductos.Clear();
            DtProductos.Columns.Add("Productos");
            DtProductos.Columns.Add("Cantidad");
            DtProductos.Columns.Add("SubTotal");
            DtTotal.Dispose();
            DtTotal.Columns.Clear();
            DtTotal.Clear();
            DtTotal.Columns.Add("T O T A L");
            ProCrearDataTable();
            CalcularTotal();
            ListaProductos.DataSource = DtProductos;
            dvgTotal.DataSource = DtTotal;
           
          
        }
    }
}
