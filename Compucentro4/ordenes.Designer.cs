﻿namespace Compucentro4
{
    partial class ordenes
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
            this.pictureCabecera = new System.Windows.Forms.PictureBox();
            this.picturePie = new System.Windows.Forms.PictureBox();
            this.cmbAtendio = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleado = new Compucentro4.empleado();
            this.label9 = new System.Windows.Forms.Label();
            this.datei = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtSerieID = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new Compucentro4.empleadoTableAdapters.EmpleadoTableAdapter();
            this.cmbAtendioID = new System.Windows.Forms.ComboBox();
            this.btnimprimir2 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(897, 674);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(749, 674);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureCabecera
            // 
            this.pictureCabecera.Image = global::Compucentro4.Properties.Resources.CABECERA_COMPUCENTRO1;
            this.pictureCabecera.Location = new System.Drawing.Point(4, 5);
            this.pictureCabecera.Margin = new System.Windows.Forms.Padding(5);
            this.pictureCabecera.Name = "pictureCabecera";
            this.pictureCabecera.Size = new System.Drawing.Size(1026, 99);
            this.pictureCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCabecera.TabIndex = 35;
            this.pictureCabecera.TabStop = false;
            // 
            // picturePie
            // 
            this.picturePie.Image = global::Compucentro4.Properties.Resources.PIEPAGINA_COMPUCENTRO2;
            this.picturePie.Location = new System.Drawing.Point(4, 594);
            this.picturePie.Name = "picturePie";
            this.picturePie.Size = new System.Drawing.Size(1026, 65);
            this.picturePie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePie.TabIndex = 45;
            this.picturePie.TabStop = false;
            // 
            // cmbAtendio
            // 
            this.cmbAtendio.DataSource = this.empleadoBindingSource1;
            this.cmbAtendio.DisplayMember = "nombre";
            this.cmbAtendio.FormattingEnabled = true;
            this.cmbAtendio.Location = new System.Drawing.Point(266, 539);
            this.cmbAtendio.Name = "cmbAtendio";
            this.cmbAtendio.Size = new System.Drawing.Size(248, 29);
            this.cmbAtendio.TabIndex = 46;
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.empleadoBindingSource;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = this.empleado;
            this.empleadoBindingSource.Position = 0;
            // 
            // empleado
            // 
            this.empleado.DataSetName = "empleado";
            this.empleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 542);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "¿Quién atendio?";
            // 
            // datei
            // 
            this.datei.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datei.Location = new System.Drawing.Point(189, 123);
            this.datei.Name = "datei";
            this.datei.Size = new System.Drawing.Size(158, 27);
            this.datei.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Fecha";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(580, 125);
            this.txtOrden.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(64, 27);
            this.txtOrden.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "No.Orden";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(471, 396);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(5);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(173, 27);
            this.txtEquipo.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 64;
            this.label10.Text = "Equipo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(166, 396);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(118, 27);
            this.txtModelo.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Modelo";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Acttivo",
            "Inactivo"});
            this.cmbStatus.Location = new System.Drawing.Point(602, 244);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 29);
            this.cmbStatus.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = "Status";
            // 
            // txtFalla
            // 
            this.txtFalla.Location = new System.Drawing.Point(131, 499);
            this.txtFalla.Margin = new System.Windows.Forms.Padding(5);
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.Size = new System.Drawing.Size(498, 27);
            this.txtFalla.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Falla";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(173, 442);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(5);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(445, 27);
            this.txtComplemento.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 445);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "Complementos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(151, 165);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(249, 27);
            this.txtCliente.TabIndex = 65;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(151, 305);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(249, 27);
            this.txtSerie.TabIndex = 66;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(434, 165);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(58, 27);
            this.txtClienteID.TabIndex = 67;
            // 
            // txtSerieID
            // 
            this.txtSerieID.Location = new System.Drawing.Point(434, 308);
            this.txtSerieID.Name = "txtSerieID";
            this.txtSerieID.Size = new System.Drawing.Size(58, 27);
            this.txtSerieID.TabIndex = 68;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(183, 256);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(220, 27);
            this.txtCelular.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 21);
            this.label11.TabIndex = 74;
            this.label11.Text = "Celular";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 203);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 27);
            this.txtTelefono.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 21);
            this.label12.TabIndex = 73;
            this.label12.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(189, 352);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(500, 27);
            this.txtDireccion.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 72;
            this.label13.Text = "Dirrección";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAtendioID
            // 
            this.cmbAtendioID.DataSource = this.empleadoBindingSource1;
            this.cmbAtendioID.DisplayMember = "idEmpleado";
            this.cmbAtendioID.FormattingEnabled = true;
            this.cmbAtendioID.Location = new System.Drawing.Point(542, 542);
            this.cmbAtendioID.Name = "cmbAtendioID";
            this.cmbAtendioID.Size = new System.Drawing.Size(76, 29);
            this.cmbAtendioID.TabIndex = 75;
            // 
            // btnimprimir2
            // 
            this.btnimprimir2.Location = new System.Drawing.Point(423, 674);
            this.btnimprimir2.Name = "btnimprimir2";
            this.btnimprimir2.Size = new System.Drawing.Size(111, 61);
            this.btnimprimir2.TabIndex = 77;
            this.btnimprimir2.Text = "Imprimir2";
            this.btnimprimir2.UseVisualStyleBackColor = true;
            this.btnimprimir2.Click += new System.EventHandler(this.btnimprimir2_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(557, 674);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 61);
            this.btnImprimir.TabIndex = 76;
            this.btnImprimir.Text = "Imprimir1";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.btnimprimir2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbAtendioID);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSerieID);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFalla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAtendio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picturePie);
            this.Controls.Add(this.pictureCabecera);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ordenes";
            this.Text = "ordenes";
            this.Load += new System.EventHandler(this.ordenes_Load);
            this.Controls.SetChildIndex(this.pictureCabecera, 0);
            this.Controls.SetChildIndex(this.picturePie, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbAtendio, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtOrden, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.datei, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComplemento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtFalla, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtEquipo, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.txtClienteID, 0);
            this.Controls.SetChildIndex(this.txtSerieID, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.cmbAtendioID, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnimprimir2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCabecera;
        private System.Windows.Forms.PictureBox picturePie;
        private System.Windows.Forms.ComboBox cmbAtendio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtSerieID;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private empleado empleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private empleadoTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.ComboBox cmbAtendioID;
        private System.Windows.Forms.Button btnimprimir2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}