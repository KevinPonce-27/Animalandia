using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

using Animalandia;

namespace Animalandia
{
    internal class ControladorForms
    {
        private FormIniciarSesion forminiciarsesion = new FormIniciarSesion();

        public ControladorForms()
        {
        }

        public ControladorForms(FormIniciarSesion formIniciarSesion)
        {
            forminiciarsesion = formIniciarSesion;
        }

        public void error()
        {
            MessageBox.Show("Ingrese los datos correctos ", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            forminiciarsesion.txtpasswordlogin.Text = "Ingrese Contraseña";
            forminiciarsesion.txtpasswordlogin.ForeColor = Color.Silver;
            forminiciarsesion.txtusuariologin.Text = "Ingrese Usuario";
            forminiciarsesion.txtusuariologin.ForeColor = Color.Silver;
        }
        public void txtusuariologin_Enter()
        {
            try
            {
                if (forminiciarsesion.txtusuariologin.Text == "Ingrese Usuario")
                {
                    forminiciarsesion.txtusuariologin.Text = "";
                    forminiciarsesion.txtusuariologin.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void txtusuariologin_Leave()
        {
            try
            {
                if (forminiciarsesion.txtusuariologin.Text == "")
                {
                    forminiciarsesion.txtusuariologin.Text = "Ingrese Usuario";
                    forminiciarsesion.txtusuariologin.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        public void txtpasswordlogin_Leave()
        {
            try
            {
                if (forminiciarsesion.txtpasswordlogin.Text == "")
                {
                    forminiciarsesion.txtpasswordlogin.Text = "Ingrese Contraseña";
                    forminiciarsesion.txtpasswordlogin.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void txtpasswordlogin_Enter(object sender, EventArgs e)
        {

            try
            {
                if (forminiciarsesion.txtpasswordlogin.Text == "Ingrese Contraseña")
                {
                    forminiciarsesion.txtpasswordlogin.Text = "";
                    forminiciarsesion.txtpasswordlogin.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //CIERRA OJO Y ABRE

        public void btnvisualizarpassword_Click()
        {
            try
            {
                if (forminiciarsesion.txtpasswordlogin.PasswordChar == '*')
                {
                    forminiciarsesion.txtpasswordlogin.PasswordChar = '\0';
                    forminiciarsesion.btnvisualizarpassword.BackgroundImageLayout = ImageLayout.Zoom;
                    forminiciarsesion.btnvisualizarpassword.Image = Properties.Resources.eyeopen;
                    forminiciarsesion.btnvisualizarpassword.Image = new Bitmap(forminiciarsesion.btnvisualizarpassword.Image, forminiciarsesion.btnvisualizarpassword.Size);
                }
                else
                {
                    forminiciarsesion.txtpasswordlogin.PasswordChar = '*';
                    forminiciarsesion.btnvisualizarpassword.BackgroundImageLayout = ImageLayout.Zoom;
                    forminiciarsesion.btnvisualizarpassword.Image = Properties.Resources.eyeoculto;
                    forminiciarsesion.btnvisualizarpassword.Image = new Bitmap(forminiciarsesion.btnvisualizarpassword.Image, forminiciarsesion.btnvisualizarpassword.Size);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
