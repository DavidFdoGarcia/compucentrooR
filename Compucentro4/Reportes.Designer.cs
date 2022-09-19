namespace Compucentro4
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdReparo = new System.Windows.Forms.ComboBox();
            this.operadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTecnico = new Compucentro4.dataTecnico();
            this.operadorTableAdapter = new Compucentro4.dataTecnicoTableAdapters.OperadorTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.operadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(819, 367);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(671, 367);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Quién reparo?";
            // 
            // cmdReparo
            // 
            this.cmdReparo.DataSource = this.operadorBindingSource;
            this.cmdReparo.DisplayMember = "nombre";
            this.cmdReparo.FormattingEnabled = true;
            this.cmdReparo.Location = new System.Drawing.Point(180, 111);
            this.cmdReparo.Name = "cmdReparo";
            this.cmdReparo.Size = new System.Drawing.Size(194, 29);
            this.cmdReparo.TabIndex = 10;
            // 
            // operadorBindingSource
            // 
            this.operadorBindingSource.DataMember = "Operador";
            this.operadorBindingSource.DataSource = this.dataTecnico;
            // 
            // dataTecnico
            // 
            this.dataTecnico.DataSetName = "dataTecnico";
            this.dataTecnico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operadorTableAdapter
            // 
            this.operadorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.operadorBindingSource;
            this.comboBox1.DisplayMember = "idOperador";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 29);
            this.comboBox1.TabIndex = 11;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 727);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdReparo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmdReparo, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.operadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmdReparo;
        private dataTecnico dataTecnico;
        private System.Windows.Forms.BindingSource operadorBindingSource;
        private dataTecnicoTableAdapters.OperadorTableAdapter operadorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}