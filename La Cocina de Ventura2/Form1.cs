using La_Cocina_de_Ventura2.Clases;
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
using MySql.Data.MySqlClient;

namespace La_Cocina_de_Ventura2
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        Cls_Principal objPrin = new Cls_Principal();

        //Aqui se cierra el formulario "Login" y se abre el Form2 (ventas)
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean log;
            log = objPrin.Login(cv.Text, contraseña.Text);
            if(log != true)
            {
                MessageBox.Show("Usuario Incorrecto");
                return;
            }
            if(log = true)
            {
                Login frm = new Login();
                
                

                this.Hide();

                if (Cls_Principal.varTipo.Equals("Gerente"))
                {
                    Form frm1 = new Menu.Gerente();
                    frm1.Show();
                }
                else
                {
                    Form2 frm3 = new Form2();
                    frm3.Show();
                }
            }

         
            
        }
        //Boton para salir del programa
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
