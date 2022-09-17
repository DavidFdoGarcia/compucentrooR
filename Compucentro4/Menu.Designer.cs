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
            this.altaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEquiiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeRangosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeTécnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
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
            this.altaDeClientesToolStripMenuItem,
            this.altaDeEquiiposToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.altaDeRangosToolStripMenuItem,
            this.altaDeEmpleadosToolStripMenuItem,
            this.altaDeTécnicosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Altas";
            // 
            // altaDeClientesToolStripMenuItem
            // 
            this.altaDeClientesToolStripMenuItem.Name = "altaDeClientesToolStripMenuItem";
            this.altaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeClientesToolStripMenuItem.Text = "Alta de Usuarios";
            this.altaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.altaDeClientesToolStripMenuItem_Click);
            // 
            // altaDeEquiiposToolStripMenuItem
            // 
            this.altaDeEquiiposToolStripMenuItem.Name = "altaDeEquiiposToolStripMenuItem";
            this.altaDeEquiiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeEquiiposToolStripMenuItem.Text = "Alta de Equiipos";
            this.altaDeEquiiposToolStripMenuItem.Click += new System.EventHandler(this.altaDeEquiiposToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // altaDeRangosToolStripMenuItem
            // 
            this.altaDeRangosToolStripMenuItem.Name = "altaDeRangosToolStripMenuItem";
            this.altaDeRangosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeRangosToolStripMenuItem.Text = "Alta de Rangos";
            this.altaDeRangosToolStripMenuItem.Click += new System.EventHandler(this.altaDeRangosToolStripMenuItem_Click);
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
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
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
        private System.Windows.Forms.ToolStripMenuItem altaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeEquiiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeRangosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeTécnicosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
    }
}

