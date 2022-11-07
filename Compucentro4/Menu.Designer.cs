namespace Compucentro4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeTécnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulaDetallesOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaOrdenPorFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.altaDeDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.modificacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenToolStripMenuItem,
            this.altaDeEmpleadosToolStripMenuItem,
            this.altaDeTécnicosToolStripMenuItem,
            this.altaDeReportesToolStripMenuItem,
            this.altaDeDiagnosticoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Altas";
            // 
            // ordenToolStripMenuItem
            // 
            this.ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            this.ordenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenToolStripMenuItem.Text = "orden";
            this.ordenToolStripMenuItem.Click += new System.EventHandler(this.ordenToolStripMenuItem_Click);
            // 
            // altaDeEmpleadosToolStripMenuItem
            // 
            this.altaDeEmpleadosToolStripMenuItem.Name = "altaDeEmpleadosToolStripMenuItem";
            this.altaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeEmpleadosToolStripMenuItem.Text = "Alta de Empleados";
            this.altaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.altaDeEmpleadosToolStripMenuItem_Click);
            // 
            // altaDeTécnicosToolStripMenuItem
            // 
            this.altaDeTécnicosToolStripMenuItem.Name = "altaDeTécnicosToolStripMenuItem";
            this.altaDeTécnicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeTécnicosToolStripMenuItem.Text = "Alta de Técnicos";
            this.altaDeTécnicosToolStripMenuItem.Click += new System.EventHandler(this.altaDeTécnicosToolStripMenuItem_Click);
            // 
            // altaDeReportesToolStripMenuItem
            // 
            this.altaDeReportesToolStripMenuItem.Name = "altaDeReportesToolStripMenuItem";
            this.altaDeReportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeReportesToolStripMenuItem.Text = "Alta de Reportes";
            this.altaDeReportesToolStripMenuItem.Click += new System.EventHandler(this.altaDeReportesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulaDetallesOrdenesToolStripMenuItem,
            this.consultaOrdenPorFiltrosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consulaDetallesOrdenesToolStripMenuItem
            // 
            this.consulaDetallesOrdenesToolStripMenuItem.Name = "consulaDetallesOrdenesToolStripMenuItem";
            this.consulaDetallesOrdenesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.consulaDetallesOrdenesToolStripMenuItem.Text = "Consula Detalles Ordenes";
            this.consulaDetallesOrdenesToolStripMenuItem.Click += new System.EventHandler(this.consulaDetallesOrdenesToolStripMenuItem_Click);
            // 
            // consultaOrdenPorFiltrosToolStripMenuItem
            // 
            this.consultaOrdenPorFiltrosToolStripMenuItem.Name = "consultaOrdenPorFiltrosToolStripMenuItem";
            this.consultaOrdenPorFiltrosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.consultaOrdenPorFiltrosToolStripMenuItem.Text = "Consulta Orden por Filtros";
            this.consultaOrdenPorFiltrosToolStripMenuItem.Click += new System.EventHandler(this.consultaOrdenPorFiltrosToolStripMenuItem_Click);
            // 
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarOrdenToolStripMenuItem,
            this.toolStripMenuItem1});
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
            // 
            // modificarOrdenToolStripMenuItem
            // 
            this.modificarOrdenToolStripMenuItem.Name = "modificarOrdenToolStripMenuItem";
            this.modificarOrdenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modificarOrdenToolStripMenuItem.Text = "Modificar Orden";
            this.modificarOrdenToolStripMenuItem.Click += new System.EventHandler(this.modificarOrdenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Compucentro4.Properties.Resources.COMPUUCENTRO__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // altaDeDiagnosticoToolStripMenuItem
            // 
            this.altaDeDiagnosticoToolStripMenuItem.Name = "altaDeDiagnosticoToolStripMenuItem";
            this.altaDeDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeDiagnosticoToolStripMenuItem.Text = "Alta de Diagnostico";
            this.altaDeDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.altaDeDiagnosticoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeTécnicosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulaDetallesOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaOrdenPorFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDiagnosticoToolStripMenuItem;
    }
}

