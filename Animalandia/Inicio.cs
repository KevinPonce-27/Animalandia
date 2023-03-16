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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            panelUser1.Size = new System.Drawing.Size(200, 100);
            panelUser3.Size = new System.Drawing.Size(200, 100);
            panelUser2.Size = new System.Drawing.Size(250, 100);
        }

        private void Inicio_ResizeEnd(object sender, EventArgs e)
        {
            panelUser1.Size = new System.Drawing.Size(200, 100);
            panelUser3.Size = new System.Drawing.Size(200, 100);
            panelUser2.Size = new System.Drawing.Size(250, 100);

        }

        private void tm_Fecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
