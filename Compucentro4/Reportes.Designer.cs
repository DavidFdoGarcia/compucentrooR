﻿namespace Compucentro4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReparo = new System.Windows.Forms.ComboBox();
            this.operadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTecnico = new Compucentro4.dataTecnico();
            this.operadorTableAdapter = new Compucentro4.dataTecnicoTableAdapters.OperadorTableAdapter();
            this.cmbReparoID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvver = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usu = new Compucentro4.usu();
            this.label7 = new System.Windows.Forms.Label();
            this.cliente = new Compucentro4.Cliente();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Compucentro4.ClienteTableAdapters.UsuarioTableAdapter();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.equipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipo = new Compucentro4.Equipo();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.equipoTableAdapter = new Compucentro4.EquipoTableAdapters.EquipoTableAdapter();
            this.cmbEquipoID = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new Compucentro4.usuTableAdapters.UsuarioTableAdapter();
            this.txtPieza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.operadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTecnico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(509, 652);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(359, 650);
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
            this.label4.Location = new System.Drawing.Point(30, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Quién reparo?";
            // 
            // cmbReparo
            // 
            this.cmbReparo.DataSource = this.operadorBindingSource;
            this.cmbReparo.DisplayMember = "nombre";
            this.cmbReparo.FormattingEnabled = true;
            this.cmbReparo.Location = new System.Drawing.Point(185, 378);
            this.cmbReparo.Name = "cmbReparo";
            this.cmbReparo.Size = new System.Drawing.Size(226, 29);
            this.cmbReparo.TabIndex = 10;
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
            // cmbReparoID
            // 
            this.cmbReparoID.DataSource = this.operadorBindingSource;
            this.cmbReparoID.DisplayMember = "idOperador";
            this.cmbReparoID.FormattingEnabled = true;
            this.cmbReparoID.Location = new System.Drawing.Point(439, 375);
            this.cmbReparoID.Name = "cmbReparoID";
            this.cmbReparoID.Size = new System.Drawing.Size(60, 29);
            this.cmbReparoID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 597);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reporte";
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(158, 591);
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(468, 27);
            this.txtReporte.TabIndex = 13;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(613, 27);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(83, 27);
            this.txtOrden.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Orden";
            // 
            // dgvver
            // 
            this.dgvver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvver.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvver.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvver.GridColor = System.Drawing.Color.Silver;
            this.dgvver.Location = new System.Drawing.Point(33, 117);
            this.dgvver.Name = "dgvver";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvver.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvver.RowTemplate.Height = 24;
            this.dgvver.Size = new System.Drawing.Size(466, 153);
            this.dgvver.TabIndex = 16;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(574, 311);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(109, 63);
            this.btnConsulta.TabIndex = 17;
            this.btnConsulta.Text = "Agregar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(208, 650);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 63);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Refacciones";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.usuarioBindingSource2;
            this.cmbCliente.DisplayMember = "nombre";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(121, 311);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(258, 29);
            this.cmbCliente.TabIndex = 21;
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            this.usuarioBindingSource2.DataSource = this.usu;
            // 
            // usu
            // 
            this.usu.DataSetName = "usu";
            this.usu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cliente";
            // 
            // cliente
            // 
            this.cliente.DataSetName = "Cliente";
            this.cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.cliente;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cmbID
            // 
            this.cmbID.DataSource = this.usuarioBindingSource2;
            this.cmbID.DisplayMember = "idUsuario";
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(414, 311);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(62, 29);
            this.cmbID.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 452);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Equipo";
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource1, "Modelo", true));
            this.txtModelo.Location = new System.Drawing.Point(158, 515);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(175, 27);
            this.txtModelo.TabIndex = 29;
            // 
            // equipoBindingSource1
            // 
            this.equipoBindingSource1.DataMember = "Equipo";
            this.equipoBindingSource1.DataSource = this.equipoBindingSource;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = this.equipo;
            this.equipoBindingSource.Position = 0;
            // 
            // equipo
            // 
            this.equipo.DataSetName = "Equipo";
            this.equipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 521);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Modelo";
            // 
            // txtSerie
            // 
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource1, "Serie", true));
            this.txtSerie.Location = new System.Drawing.Point(453, 515);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(175, 27);
            this.txtSerie.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 518);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Serie";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.DataSource = this.equipoBindingSource1;
            this.cmbEquipo.DisplayMember = "Tipo";
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(158, 444);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(226, 29);
            this.cmbEquipo.TabIndex = 32;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEquipoID
            // 
            this.cmbEquipoID.DataSource = this.equipoBindingSource1;
            this.cmbEquipoID.DisplayMember = "idEquipo";
            this.cmbEquipoID.FormattingEnabled = true;
            this.cmbEquipoID.Location = new System.Drawing.Point(414, 444);
            this.cmbEquipoID.Name = "cmbEquipoID";
            this.cmbEquipoID.Size = new System.Drawing.Size(62, 29);
            this.cmbEquipoID.TabIndex = 33;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.usu;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // txtPieza
            // 
            this.txtPieza.Location = new System.Drawing.Point(587, 117);
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.Size = new System.Drawing.Size(131, 27);
            this.txtPieza.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pieza";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(613, 243);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(105, 27);
            this.txtPrecio.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(635, 174);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(83, 27);
            this.txtCantidad.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cantidad";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(613, 401);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(105, 27);
            this.txtMonto.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(527, 404);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 40;
            this.label13.Text = "Monto";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 727);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPieza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEquipoID);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dgvver);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbReparoID);
            this.Controls.Add(this.cmbReparo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbReparo, 0);
            this.Controls.SetChildIndex(this.cmbReparoID, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtReporte, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtOrden, 0);
            this.Controls.SetChildIndex(this.dgvver, 0);
            this.Controls.SetChildIndex(this.btnConsulta, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbCliente, 0);
            this.Controls.SetChildIndex(this.cmbID, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.cmbEquipo, 0);
            this.Controls.SetChildIndex(this.cmbEquipoID, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPieza, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.operadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTecnico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReparo;
        private dataTecnico dataTecnico;
        private System.Windows.Forms.BindingSource operadorBindingSource;
        private dataTecnicoTableAdapters.OperadorTableAdapter operadorTableAdapter;
        private System.Windows.Forms.ComboBox cmbReparoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvver;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label7;
        private Cliente cliente;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ClienteTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private Equipo equipo;
        private System.Windows.Forms.BindingSource equipoBindingSource1;
        private EquipoTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.ComboBox cmbEquipoID;
        private usu usu;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private usuTableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private System.Windows.Forms.TextBox txtPieza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label13;
    }
}