namespace Compucentro4
{
    partial class AltaOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaOrden));
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente = new Compucentro4.Cliente();
            this.usuarioTableAdapter = new Compucentro4.ClienteTableAdapters.UsuarioTableAdapter();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipo = new Compucentro4.Equipo();
            this.equipoTableAdapter = new Compucentro4.EquipoTableAdapters.EquipoTableAdapter();
            this.cmbIDEquipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAtendio = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleado = new Compucentro4.empleado();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuaario2 = new Compucentro4.Usuaario2();
            this.usuarioTableAdapter1 = new Compucentro4.Usuaario2TableAdapters.UsuarioTableAdapter();
            this.cmbAtendioID = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureCabecera = new System.Windows.Forms.PictureBox();
            this.empleadoTableAdapter = new Compucentro4.empleadoTableAdapters.EmpleadoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.datei = new System.Windows.Forms.DateTimePicker();
            this.usu = new Compucentro4.usu();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter2 = new Compucentro4.usuTableAdapters.UsuarioTableAdapter();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteee = new Compucentro4.clienteee();
            this.usuarioTableAdapter3 = new Compucentro4.clienteeeTableAdapters.UsuarioTableAdapter();
            this.cmbIDCliente = new System.Windows.Forms.ComboBox();
            this.picturePie = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnimprimir2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuaario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(579, 629);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(431, 629);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(589, 118);
            this.txtOrden.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(64, 27);
            this.txtOrden.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "No.Orden";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.cliente;
            // 
            // cliente
            // 
            this.cliente.DataSetName = "Cliente";
            this.cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cmbSerie
            // 
            this.cmbSerie.DataSource = this.equipoBindingSource;
            this.cmbSerie.DisplayMember = "Serie";
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(176, 274);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(290, 29);
            this.cmbSerie.TabIndex = 2;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.equipo;
            // 
            // equipo
            // 
            this.equipo.DataSetName = "Equipo";
            this.equipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbIDEquipo
            // 
            this.cmbIDEquipo.DataSource = this.equipoBindingSource;
            this.cmbIDEquipo.DisplayMember = "idEquipo";
            this.cmbIDEquipo.FormattingEnabled = true;
            this.cmbIDEquipo.Location = new System.Drawing.Point(511, 274);
            this.cmbIDEquipo.Name = "cmbIDEquipo";
            this.cmbIDEquipo.Size = new System.Drawing.Size(56, 29);
            this.cmbIDEquipo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 513);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "¿Quién atendio?";
            // 
            // cmbAtendio
            // 
            this.cmbAtendio.DataSource = this.empleadoBindingSource;
            this.cmbAtendio.DisplayMember = "Nombre";
            this.cmbAtendio.FormattingEnabled = true;
            this.cmbAtendio.Location = new System.Drawing.Point(218, 510);
            this.cmbAtendio.Name = "cmbAtendio";
            this.cmbAtendio.Size = new System.Drawing.Size(248, 29);
            this.cmbAtendio.TabIndex = 7;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.empleado;
            // 
            // empleado
            // 
            this.empleado.DataSetName = "empleado";
            this.empleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.usuaario2;
            // 
            // usuaario2
            // 
            this.usuaario2.DataSetName = "Usuaario2";
            this.usuaario2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbAtendioID
            // 
            this.cmbAtendioID.DataSource = this.empleadoBindingSource;
            this.cmbAtendioID.DisplayMember = "idEmpleado";
            this.cmbAtendioID.FormattingEnabled = true;
            this.cmbAtendioID.Location = new System.Drawing.Point(504, 505);
            this.cmbAtendioID.Name = "cmbAtendioID";
            this.cmbAtendioID.Size = new System.Drawing.Size(52, 29);
            this.cmbAtendioID.TabIndex = 32;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureCabecera
            // 
            this.pictureCabecera.Image = global::Compucentro4.Properties.Resources.CABECERA_COMPUCENTRO1;
            this.pictureCabecera.Location = new System.Drawing.Point(1, 2);
            this.pictureCabecera.Name = "pictureCabecera";
            this.pictureCabecera.Size = new System.Drawing.Size(733, 83);
            this.pictureCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCabecera.TabIndex = 34;
            this.pictureCabecera.TabStop = false;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fecha";
            // 
            // datei
            // 
            this.datei.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datei.Location = new System.Drawing.Point(198, 116);
            this.datei.Name = "datei";
            this.datei.Size = new System.Drawing.Size(158, 27);
            this.datei.TabIndex = 40;
            // 
            // usu
            // 
            this.usu.DataSetName = "usu";
            this.usu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            this.usuarioBindingSource2.DataSource = this.usu;
            // 
            // usuarioTableAdapter2
            // 
            this.usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.usuarioBindingSource3;
            this.cmbCliente.DisplayMember = "Nombre";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(132, 204);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(285, 29);
            this.cmbCliente.TabIndex = 1;
            // 
            // usuarioBindingSource3
            // 
            this.usuarioBindingSource3.DataMember = "Usuario";
            this.usuarioBindingSource3.DataSource = this.clienteee;
            // 
            // clienteee
            // 
            this.clienteee.DataSetName = "clienteee";
            this.clienteee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter3
            // 
            this.usuarioTableAdapter3.ClearBeforeFill = true;
            // 
            // cmbIDCliente
            // 
            this.cmbIDCliente.DataSource = this.usuarioBindingSource3;
            this.cmbIDCliente.DisplayMember = "idUsuario";
            this.cmbIDCliente.FormattingEnabled = true;
            this.cmbIDCliente.Location = new System.Drawing.Point(459, 207);
            this.cmbIDCliente.Name = "cmbIDCliente";
            this.cmbIDCliente.Size = new System.Drawing.Size(84, 29);
            this.cmbIDCliente.TabIndex = 43;
            // 
            // picturePie
            // 
            this.picturePie.Image = global::Compucentro4.Properties.Resources.PIEPAGINA_COMPUCENTRO2;
            this.picturePie.Location = new System.Drawing.Point(1, 556);
            this.picturePie.Name = "picturePie";
            this.picturePie.Size = new System.Drawing.Size(733, 65);
            this.picturePie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePie.TabIndex = 44;
            this.picturePie.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Serie";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Complementos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(176, 398);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(5);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(445, 27);
            this.txtComplemento.TabIndex = 5;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Falla";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFalla
            // 
            this.txtFalla.Location = new System.Drawing.Point(134, 455);
            this.txtFalla.Margin = new System.Windows.Forms.Padding(5);
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.Size = new System.Drawing.Size(498, 27);
            this.txtFalla.TabIndex = 6;
            this.txtFalla.TextChanged += new System.EventHandler(this.txtFalla_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Acttivo",
            "Inactivo"});
            this.cmbStatus.Location = new System.Drawing.Point(605, 248);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 29);
            this.cmbStatus.TabIndex = 8;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Modelo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Modelo", true));
            this.txtModelo.Location = new System.Drawing.Point(154, 340);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(118, 27);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "Equipo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtEquipo
            // 
            this.txtEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Tipo", true));
            this.txtEquipo.Location = new System.Drawing.Point(459, 340);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(5);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(173, 27);
            this.txtEquipo.TabIndex = 4;
            this.txtEquipo.TextChanged += new System.EventHandler(this.txtEquipo_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(288, 629);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 61);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir1";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnimprimir2
            // 
            this.btnimprimir2.Location = new System.Drawing.Point(154, 629);
            this.btnimprimir2.Name = "btnimprimir2";
            this.btnimprimir2.Size = new System.Drawing.Size(111, 61);
            this.btnimprimir2.TabIndex = 41;
            this.btnimprimir2.Text = "Imprimir2";
            this.btnimprimir2.UseVisualStyleBackColor = true;
            this.btnimprimir2.Click += new System.EventHandler(this.btnimprimir2_Click);
            // 
            // AltaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 704);
            this.Controls.Add(this.picturePie);
            this.Controls.Add(this.cmbIDCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnimprimir2);
            this.Controls.Add(this.datei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCabecera);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbAtendioID);
            this.Controls.Add(this.cmbAtendio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFalla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIDEquipo);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label7);
            this.Name = "AltaOrden";
            this.Text = "AltaOrden";
            this.Load += new System.EventHandler(this.AltaOrden_Load);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtOrden, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbSerie, 0);
            this.Controls.SetChildIndex(this.cmbIDEquipo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComplemento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtFalla, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbAtendio, 0);
            this.Controls.SetChildIndex(this.cmbAtendioID, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.pictureCabecera, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtEquipo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.datei, 0);
            this.Controls.SetChildIndex(this.btnimprimir2, 0);
            this.Controls.SetChildIndex(this.cmbCliente, 0);
            this.Controls.SetChildIndex(this.cmbIDCliente, 0);
            this.Controls.SetChildIndex(this.picturePie, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuaario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label7;
        private Cliente cliente;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ClienteTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox cmbSerie;
        private Equipo equipo;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private EquipoTableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.ComboBox cmbIDEquipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAtendio;
        private Usuaario2 usuaario2;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private Usuaario2TableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.ComboBox cmbAtendioID;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureCabecera;
        private empleado empleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private empleadoTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datei;
        private usu usu;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private usuTableAdapters.UsuarioTableAdapter usuarioTableAdapter2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private clienteee clienteee;
        private System.Windows.Forms.BindingSource usuarioBindingSource3;
        private clienteeeTableAdapters.UsuarioTableAdapter usuarioTableAdapter3;
        private System.Windows.Forms.ComboBox cmbIDCliente;
        private System.Windows.Forms.PictureBox picturePie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnimprimir2;
    }
}