namespace Animalandia
{
    partial class FormIniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarSesion));
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.txtusuariologin = new System.Windows.Forms.TextBox();
            this.txtpasswordlogin = new System.Windows.Forms.TextBox();
            this.btnvisualizarpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingreso.BackgroundImage")));
            this.btn_ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ingreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingreso.FlatAppearance.BorderSize = 0;
            this.btn_ingreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingreso.Location = new System.Drawing.Point(658, 377);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(136, 34);
            this.btn_ingreso.TabIndex = 0;
            this.btn_ingreso.UseVisualStyleBackColor = true;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(658, 434);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(136, 34);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info.BackgroundImage")));
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Location = new System.Drawing.Point(840, 470);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(32, 34);
            this.btn_info.TabIndex = 2;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // txtusuariologin
            // 
            this.txtusuariologin.BackColor = System.Drawing.Color.White;
            this.txtusuariologin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuariologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuariologin.Location = new System.Drawing.Point(649, 236);
            this.txtusuariologin.Name = "txtusuariologin";
            this.txtusuariologin.Size = new System.Drawing.Size(169, 22);
            this.txtusuariologin.TabIndex = 3;
            this.txtusuariologin.Text = "Ingrese Usuario";
            this.txtusuariologin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuariologin.Enter += new System.EventHandler(this.txtusuariologin_Enter);
            this.txtusuariologin.Leave += new System.EventHandler(this.txtusuariologin_Leave);
            // 
            // txtpasswordlogin
            // 
            this.txtpasswordlogin.BackColor = System.Drawing.Color.White;
            this.txtpasswordlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpasswordlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordlogin.Location = new System.Drawing.Point(650, 303);
            this.txtpasswordlogin.Name = "txtpasswordlogin";
            this.txtpasswordlogin.PasswordChar = '*';
            this.txtpasswordlogin.Size = new System.Drawing.Size(169, 22);
            this.txtpasswordlogin.TabIndex = 4;
            this.txtpasswordlogin.Text = "Ingrese Contraseña";
            this.txtpasswordlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpasswordlogin.Enter += new System.EventHandler(this.txtpasswordlogin_Enter);
            this.txtpasswordlogin.Leave += new System.EventHandler(this.txtpasswordlogin_Leave);
            // 
            // btnvisualizarpassword
            // 
            this.btnvisualizarpassword.BackColor = System.Drawing.Color.Transparent;
            this.btnvisualizarpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvisualizarpassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnvisualizarpassword.FlatAppearance.BorderSize = 0;
            this.btnvisualizarpassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvisualizarpassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvisualizarpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisualizarpassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnvisualizarpassword.Location = new System.Drawing.Point(836, 297);
            this.btnvisualizarpassword.Name = "btnvisualizarpassword";
            this.btnvisualizarpassword.Size = new System.Drawing.Size(32, 29);
            this.btnvisualizarpassword.TabIndex = 5;
            this.btnvisualizarpassword.UseVisualStyleBackColor = false;
            this.btnvisualizarpassword.Click += new System.EventHandler(this.btnvisualizarpassword_Click);
            // 
            // FormIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(876, 508);
            this.Controls.Add(this.btnvisualizarpassword);
            this.Controls.Add(this.txtpasswordlogin);
            this.Controls.Add(this.txtusuariologin);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.FormIniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_ingreso;
        public System.Windows.Forms.TextBox txtusuariologin;
        public System.Windows.Forms.TextBox txtpasswordlogin;
        public System.Windows.Forms.Button btnvisualizarpassword;
    }
}

