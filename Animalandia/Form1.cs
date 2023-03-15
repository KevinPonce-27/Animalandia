using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animalandia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Info ventana_info = new Info();
            ventana_info.Show();
            Hide();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            MenuVeterinaria ventana_menu = new MenuVeterinaria();  
            ventana_menu.Show();
            Hide();
        }
    }
}
