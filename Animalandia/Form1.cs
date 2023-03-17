using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Animalandia
{
    public partial class FormIniciarSesion : Form
    {

        MenuVeterinaria ventana_menu = new MenuVeterinaria();
        ConexionSQL conexion_sql = new ConexionSQL();
        private static SqlDataReader lectora_sentencia;
        private static SqlCommand comando_consulta;
        ControladorForms controladorform;
        EmpleadoReporte empleadoreporte = new EmpleadoReporte();


        public FormIniciarSesion()
        {

            InitializeComponent();

        }

        private void FormIniciarSesion_Load(object sender, EventArgs e)
        {
            controladorform = new ControladorForms(this);
            btnvisualizarpassword.Image = Properties.Resources.eyeopen;
            btnvisualizarpassword.Image = new Bitmap(btnvisualizarpassword.Image, btnvisualizarpassword.Size);
            txtusuariologin.ForeColor = Color.Silver;
            txtpasswordlogin.ForeColor = Color.Silver;
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
            try
            {
                if (txtusuariologin.Text == "Ingrese Usuario" 
                    && txtpasswordlogin.Text == "Ingrese Contraseña")
                {
                    MessageBox.Show("Rellene todos los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                     comando_consulta = new 
                        SqlCommand("SELECT * FROM [dbo].[Persona] P INNER JOIN [dbo].[Empleado] E ON P.id_persona = E.id_persona where E.usuario_empleado = '"+ txtusuariologin.Text +"' and E.password_empleado='" + txtpasswordlogin.Text + "' and E.cargo= 'Administrador'", conexion_sql.AbrirConexion());

                    lectora_sentencia = comando_consulta.ExecuteReader();

                    if (lectora_sentencia.Read())
                    {
                        ventana_menu.Show();
                        Hide();
                        lectora_sentencia.Close();
                        return;
                    }
                    else 
                    {
                        conexion_sql.CerrarConexion();
                        lectora_sentencia.Close();
                        comando_consulta = new
                       SqlCommand("SELECT P.id_persona, E.id_empleado, Cj.id_caja FROM [dbo].[Persona] P INNER JOIN [dbo].[Empleado] E ON P.id_persona = E.id_persona " +
                       "INNER JOIN [dbo].[Empleado_Jornada] Ej ON E.id_empleado= Ej.id_empleado " +
                       "INNER JOIN [dbo].[Jornada] J ON J.id_jornada=EJ.id_jornada " +
                       "INNER JOIN  [dbo].[Cajero] Cj ON Cj.id_empleado=E.id_empleado " +
                       "INNER JOIN [dbo].[Movimiento_Caja] Mc " +
                       "on Cj.id_caja=Mc.id_caja  " +
                       "where E.usuario_empleado = '" + txtusuariologin.Text + "' and E.password_empleado='" + txtpasswordlogin.Text + "'", conexion_sql.AbrirConexion());
                        lectora_sentencia = comando_consulta.ExecuteReader();
                        if (lectora_sentencia.Read())
                        {
                            MessageBox.Show("EMPLEADO");
                            lectora_sentencia.Close();
                            return;
                        }
                        else
                        {
                           conexion_sql.CerrarConexion();
                           lectora_sentencia.Close();
                           comando_consulta = new
                           SqlCommand("SELECT P.id_persona, E.id_empleado, P.Nombres FROM [dbo].[Persona] P INNER JOIN [dbo].[Empleado] E ON P.id_persona = E.id_persona " +
                           "INNER JOIN [dbo].[Empleado_Jornada] Ej ON E.id_empleado= Ej.id_empleado \r\nINNER JOIN [dbo].[Jornada] J ON J.id_jornada=EJ.id_jornada " +
                           "where E.usuario_empleado = '" + txtusuariologin.Text + "' and E.password_empleado='" + txtpasswordlogin.Text + "'", conexion_sql.AbrirConexion());
                            lectora_sentencia = comando_consulta.ExecuteReader();
                            if (lectora_sentencia.Read())
                            {
                                empleadoreporte.ShowDialog();
                                int id_persona = lectora_sentencia.GetInt32(0);
                                int id_empleado = lectora_sentencia.GetInt32(1);
                                MessageBox.Show("NO TIENE CAJA " + id_persona + "OTRA " + id_empleado + "Nombre" + lectora_sentencia.GetString(2));
                                lectora_sentencia.Close();
                                return;
                            }
                        }
                    }
                    this.controladorform.error();

                    conexion_sql.CerrarConexion();
                }
                conexion_sql.CerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion_sql.CerrarConexion();

            }
        }










        //OJO
        private void btnvisualizarpassword_Click(object sender, EventArgs e)
        {
            this.controladorform.btnvisualizarpassword_Click();
        }

        //ayuda en el placeholder = Ingrese Usuario (Leave,Enter)
        private void txtusuariologin_Enter(object sender, EventArgs e)
        {
            this.controladorform.txtusuariologin_Enter();
        }
        private void txtusuariologin_Leave(object sender, EventArgs e)
        {
            this.controladorform.txtusuariologin_Leave();
        }

        private void txtpasswordlogin_Leave(object sender, EventArgs e)
        {
            this.controladorform.txtpasswordlogin_Leave();
        }

        private void txtpasswordlogin_Enter(object sender, EventArgs e)
        {
            this.controladorform.txtpasswordlogin_Enter(sender, e);
        }




    }
}
