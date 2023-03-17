namespace Animalandia
{
    partial class EmpleadoReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportVEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtsearch_cedula = new System.Windows.Forms.TextBox();
            this.lblbuscador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportVEmpleado
            // 
            this.ReportVEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportVEmpleado.Location = new System.Drawing.Point(0, 0);
            this.ReportVEmpleado.Name = "ReportVEmpleado";
            this.ReportVEmpleado.ServerReport.BearerToken = null;
            this.ReportVEmpleado.Size = new System.Drawing.Size(841, 450);
            this.ReportVEmpleado.TabIndex = 0;
            // 
            // txtsearch_cedula
            // 
            this.txtsearch_cedula.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch_cedula.Location = new System.Drawing.Point(132, 3);
            this.txtsearch_cedula.Name = "txtsearch_cedula";
            this.txtsearch_cedula.Size = new System.Drawing.Size(152, 22);
            this.txtsearch_cedula.TabIndex = 1;
            this.txtsearch_cedula.TextChanged += new System.EventHandler(this.txtsearch_cedula_TextChanged);
            // 
            // lblbuscador
            // 
            this.lblbuscador.AutoSize = true;
            this.lblbuscador.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbuscador.Location = new System.Drawing.Point(30, 6);
            this.lblbuscador.Name = "lblbuscador";
            this.lblbuscador.Size = new System.Drawing.Size(89, 16);
            this.lblbuscador.TabIndex = 2;
            this.lblbuscador.Text = "BUSCADOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(208)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.lblbuscador);
            this.panel1.Controls.Add(this.txtsearch_cedula);
            this.panel1.Location = new System.Drawing.Point(5, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 29);
            this.panel1.TabIndex = 3;
            // 
            // EmpleadoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReportVEmpleado);
            this.Name = "EmpleadoReporte";
            this.Text = "EmpleadoReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmpleadoReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportVEmpleado;
        private System.Windows.Forms.TextBox txtsearch_cedula;
        private System.Windows.Forms.Label lblbuscador;
        private System.Windows.Forms.Panel panel1;
    }
}