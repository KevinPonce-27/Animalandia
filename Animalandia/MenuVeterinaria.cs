using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animalandia
{
    public partial class MenuVeterinaria : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize; 



        public MenuVeterinaria()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(0, 192, 65);//Border color

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


        private void MenuVeterinaria_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(2, 2, 2, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void MenuVeterinaria_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Inicio form_inicio = new Inicio();
            form_inicio.TopLevel = false;
            panelForm.Controls.Add(form_inicio);
            form_inicio.Dock = DockStyle.Fill;
            form_inicio.Show();
            lblNombrePanel.Text = "INICIO";
        }

        private void FormResize()
        {
            MenuVeterinaria form_menu = new MenuVeterinaria();
            if(form_menu != null)
            {
                form_menu.WindowState = FormWindowState.Maximized;
                form_menu.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(rjDdmRegistro, sender);
            lblNombrePanel.Text = "REGISTROS > ... ";
        }
        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2,ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);

        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                {
                    ctrl.BackColor = Color.FromArgb(0, 192, 65);
                }
                else
                {
                    ctrl.BackColor = Color.FromArgb(0, 192, 65);
                }
            }
        }

        private void btnRClientes_Click(object sender, EventArgs e)
        {
            lblNombrePanel.Text = "REGISTROS > clientes ";
        }
    }
}
