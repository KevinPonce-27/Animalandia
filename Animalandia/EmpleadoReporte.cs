using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animalandia
{
    public partial class EmpleadoReporte : Form
    {
        ConexionSQL conexion_sql = new ConexionSQL();
        SqlCommand empleado;
        DataSet oDS = new DataSet();
        public EmpleadoReporte()
        {
            InitializeComponent();
        }

        private void EmpleadoReporte_Load(object sender, EventArgs e)
        {

            conexion_sql.AbrirConexion();

            try
            {
                this.ReportVEmpleado.RefreshReport();
                string cadena = @"SELECT E.id_empleado, P.cedula,P.Nombres,P.Apellidos,P.Celular,P.Email,E.sueldo,E.cargo FROM [dbo].[Persona] P  " +
                    "INNER JOIN [dbo].[Empleado] E ON P.id_persona = E.id_persona";

                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource();
                Microsoft.Reporting.WinForms.ReportDataSource dataset2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportVEmpleado.LocalReport.DataSources.Clear();
                oDS = conexion_sql.retornaRegistros(cadena);

                this.ReportVEmpleado.RefreshReport();
                ReportVEmpleado.LocalReport.ReportEmbeddedResource = "Animalandia.Empleado.rdlc";
                try
                {
                    dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DatasetEmpleado", oDS.Tables[0]);
                }
                catch
                {
                    MessageBox.Show("Error al generar reporte");
                    conexion_sql.CerrarConexion();
                }
                ReportVEmpleado.LocalReport.DataSources.Add(dataset);
                ReportVEmpleado.LocalReport.Refresh();
                ReportVEmpleado.RefreshReport();
                conexion_sql.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                conexion_sql.CerrarConexion();
            }
        }

        private void txtsearch_cedula_TextChanged(object sender, EventArgs e)
        {
            conexion_sql.AbrirConexion();

            try
            {
                this.ReportVEmpleado.RefreshReport();
                string cadena = @"SELECT E.id_empleado, P.cedula,P.Nombres,P.Apellidos,P.Celular,P.Email,E.sueldo,E.cargo FROM [dbo].[Persona] P  " +
                    "INNER JOIN [dbo].[Empleado] E ON P.id_persona = E.id_persona where P.cedula  like '%" + txtsearch_cedula.Text + "%'";

                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource();
                Microsoft.Reporting.WinForms.ReportDataSource dataset2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportVEmpleado.LocalReport.DataSources.Clear();
                oDS = conexion_sql.retornaRegistros(cadena);

                this.ReportVEmpleado.RefreshReport();
                ReportVEmpleado.LocalReport.ReportEmbeddedResource = "Animalandia.Empleado.rdlc";
                try
                {
                    dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DatasetEmpleado", oDS.Tables[0]);
                }
                catch
                {
                    MessageBox.Show("Error al generar reporte");
                    conexion_sql.CerrarConexion();

                }
                ReportVEmpleado.LocalReport.DataSources.Add(dataset);
                ReportVEmpleado.LocalReport.Refresh();
                ReportVEmpleado.RefreshReport();
                conexion_sql.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                conexion_sql.CerrarConexion();

            }
        }
    }
}
