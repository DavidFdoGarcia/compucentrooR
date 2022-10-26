using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compucentro4
{
    public partial class ordenes : Base
    {
        private DataTable dt; //DatasTable para el Grid
        public ordenes()
        {
            InitializeComponent();

            clsOrden ObjOrden = new clsOrden(); //Objeto a la clase orden

            //DataTable para llenar el Grid
            dt = new DataTable();
            dt.Columns.Add("idAccesorio");
            dt.Columns.Add("Accesorio");
            dt.Columns.Add("Serie");
            dt.Columns.Add("Observacion");
            dt.Columns.Add("Orden");

            dataGridView1.DataSource = dt;
        }

        private void ordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleado.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.empleado.Empleado);
            txtOrden.Text = ConsultaOrdenId();

           // txtComplemento.AutoSize = false;
           // txtComplemento.Size = new Size(200, 150);
           // txtComplemento.Multiline = true;

            txtFalla.AutoSize = false;
            txtFalla.Size = new Size(200, 150);
            txtFalla.Multiline = true;

            txtObs.AutoSize = false;
            txtObs.Size = new Size(200, 80);
            txtObs.Multiline = true;

            cmbStatus.SelectedIndex = 0;

            ListarAccesorios(); //Método que llena el combo de accesorios
        }
        public DataTable llenar_gridConsulta()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "select Accesorio.TipoAccesorio as Accesorio, AccesorioOrden.Serie, AccesorioOrden.Observacion from Accesorio inner join AccesorioOrden on Accesorio.idAccesorio = AccesorioOrden.idAccesorio where idOrden ='" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);


        }

        private void ListarAccesorios() //Llena combo de accesorios
        {
            clsOrden ObjOrden = new clsOrden();
            cmbAccesorio.DataSource = ObjOrden.ListarAccesorios();
            cmbAccesorio.DisplayMember = "TipoAccesorio";
            cmbAccesorio.ValueMember = "idAccesorio";

            // cargo la lista de items para el autocomplete dle combobox
            cmbAccesorio.AutoCompleteCustomSource = ObjOrden.Autocomplete();
            cmbAccesorio.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbAccesorio.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public string ConsultaOrdenId()
        {
            Conexion.Conectar();
            string query = "select max (idOrden)+1 as ID from Orden";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["ID"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public void InsertaUsuario()
        {
            Conexion.Conectar();
            string insertar = "insert into Usuario(Nombre,Celular) values(@nombre,@celular)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@nombre", txtCliente.Text);
            cmd1.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El usuario fue agregado con exito");
        }

        public string ConsultaUsuarioId()
        {
            Conexion.Conectar();
            string query = "select idUsuario as ID from Usuario WHERE Nombre = '" + txtCliente.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["ID"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public void InsertaEquipo()
        {
            Conexion.Conectar();
            string insertar = "insert into Equipo(Tipo,Modelo,Serie) values(@tipo,@modelo,@serie)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@tipo", txtEquipo.Text);
            cmd1.Parameters.AddWithValue("@modelo", txtModelo.Text);
            cmd1.Parameters.AddWithValue("@serie", txtSerie.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El Equipo fue agregado con exito");
        }

        public string ConsultaEquipoId()
        {
            Conexion.Conectar();
            string query = "select idEquipo as ID from Equipo WHERE Serie = '" + txtSerie.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["ID"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public void InsertaOrden()
        {
            Conexion.Conectar();
            string insertar = "insert into Orden(idEquipo,idUsuario,FallaC,Status,idEmpleado) values(@equipo,@usuario,@fallaC,@status,@empleado)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@equipo", txtSerieID.Text);
            cmd1.Parameters.AddWithValue("@usuario", txtClienteID.Text);

           // cmd1.Parameters.AddWithValue("@complemento", txtComplemento.Text);
            cmd1.Parameters.AddWithValue("@fallaC", txtFalla.Text);
            cmd1.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd1.Parameters.AddWithValue("@empleado", cmbAtendioID.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("La orden fue agregado con exito");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea dar de alta la orden? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaUsuario();
                txtClienteID.Text = ConsultaUsuarioId();
                InsertaEquipo();
                txtSerieID.Text = ConsultaEquipoID();
                InsertaOrden();
                InsertaAccesorio();
            }

            
            
        }

       

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Imprimir;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font font2 = new Font("Arial", 8, FontStyle.Bold);
            // 
            int y = 20;
            e.Graphics.DrawImage(pictureCabecera.Image, new Rectangle(5, 5, 850, 80));
            e.Graphics.DrawString("Orden de Servicio", font, Brushes.Black, new Rectangle(360, y += 60, 1000, 60));

            e.Graphics.DrawString("No.Orden: " + txtOrden.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Fecha de Ingreso: " + datei.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Equipo: " + txtEquipo.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Cliente: " + txtCliente.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Modelo: " + txtModelo.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Celular: " + txtCelular.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Serie: " + txtSerie.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));

            e.Graphics.DrawString("Falla: " + txtFalla.Text, font, Brushes.Black, new Rectangle(20, y += 60, 1000, 60));

            e.Graphics.DrawString("Accesorio", font, Brushes.Black, new Rectangle(20 , y += 60, 1000, 60));
            e.Graphics.DrawString("Serie", font, Brushes.Black, new Rectangle(150, y + 0, 1000, 60));
            e.Graphics.DrawString("Observacion", font, Brushes.Black, new Rectangle(230, y + 0, 1000, 60));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Accesorio"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +



               row["Serie"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +

                row["Observacion"].ToString() + " " + " " + " " + " " + " " 


                   , font2, Brushes.Black, new Rectangle(20, y += 25, 1000, 60));
            }
                e.Graphics.DrawImage(picturePie.Image, new Rectangle(5, y += 25, 850, 50));

            e.Graphics.DrawString("Condiciones generales", font2, Brushes.Black, new Rectangle(360, 600, 1000, 60));
            e.Graphics.DrawString("I. Todo equipo nuevo viene con su póliza de garantía en la cual se especifican los términos de la misma.", font2, Brushes.Black, new Rectangle(20, 620, 900, 60));
            e.Graphics.DrawString("II. Toda revisión de equipos fuera de su garantía genera un cargo, siendo el monto minimo de $100.00 + IVA \n el cual cambiará de acuerdo al modelo del equipo.", font2, Brushes.Black, new Rectangle(20, 650, 900, 60));
            e.Graphics.DrawString("III. Toda reparación que requiera cambio de parte, se solicitara el 50% de anticipo.", font2, Brushes.Black, new Rectangle(20, 680, 900, 60));
            e.Graphics.DrawString("IV. Toda revisión o reparación en la que no proceda la garantía tendra un costo.", font2, Brushes.Black, new Rectangle(20, 700, 900, 60));
            e.Graphics.DrawString("V. La garantía del equipo no cubre problemas de software(programas y aplicaciones) únicamente problemas de hardware (daños fisicos).", font2, Brushes.Black, new Rectangle(20, 720, 900, 60));
            e.Graphics.DrawString("VI. La garantía del equipo tampoco cubre el servicio de mantenimiento preventivo.", font2, Brushes.Black, new Rectangle(20, 740, 900, 60));
            e.Graphics.DrawString("VII. La garantía del servicio es de 30 días naturales.", font2, Brushes.Black, new Rectangle(20, 760, 900, 60));
            e.Graphics.DrawString("VIII. En el caso de la información contenida en el disco duro es RESPONSABILIDAD ABSOLUTA DEL CLIENTE.", font2, Brushes.Black, new Rectangle(20, 780, 900, 60));
            e.Graphics.DrawString("IX. Todo equipo que no se haya recogido después de 8 días de habérse notiicado al cliente, tendrá un cargo de almacenamiento de $15.00 por día", font2, Brushes.Black, new Rectangle(20, 800, 900, 60));
            e.Graphics.DrawString("X. Transcurridos 30 días naturales después de la notificación, el equipo se pasará al almacén de destrucción sin ninguna  responsabilidad para \n Computadoras Centro de Servicio.", font2, Brushes.Black, new Rectangle(20, 820, 900, 60));
            e.Graphics.DrawString("XI. El horario para seguimiento de reportes es de 10:00 a 19:00 hrs. de lunes a viernes, sábados de 10:00 a 14:00 hrs. \n a los teléfonos 444-817-5710, 444-128-6760, WhatsApp 444-427-3576.", font2, Brushes.Black, new Rectangle(20, 850, 900, 60));

            e.Graphics.DrawString("ACEPTO", font2, Brushes.Black, new Rectangle(80, 880, 800, 60));
            e.Graphics.DrawString("NOMBRE Y FIRMA", font2, Brushes.Black, new Rectangle(50, 980, 900, 60));

            e.Graphics.DrawString("RECIBE", font2, Brushes.Black, new Rectangle(630, 880, 880, 60));
            e.Graphics.DrawString(cmbAtendio.Text, font2, Brushes.Black, new Rectangle(600, 980, 900, 60));
            /*//e.Graphics.DrawString(txtTitulo.Text, font, Brushes.Black, 50, 130);
            Bitmap varbmp = new Bitmap(este.Image);
            Image img = este.Image;
            e.Graphics.DrawImage(img, new Rectangle(20, 30, 185, 50));
            e.Graphics.DrawString("*" + txtCodigo.Text + "*", font, Brushes.Black, new Rectangle(75, 85, 150, 20)); */

        }

        private void btnimprimir2_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Imprimir2;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Imprimir2(object sender, PrintPageEventArgs e)
        {
            //Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font font2 = new Font("Arial", 8, FontStyle.Bold);
            //  
            int y = 20;
            e.Graphics.DrawImage(pictureCabecera.Image, new Rectangle(5, y += 600, 850, 80));
            e.Graphics.DrawString("Orden de Servicio", font, Brushes.Black, new Rectangle(360, y += 70, 1000, 60));

            e.Graphics.DrawString("No.Orden: " + txtOrden.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Fecha de Ingreso: " + datei.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Equipo: " + txtEquipo.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Cliente: " + txtCliente.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Modelo: " + txtModelo.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));
            e.Graphics.DrawString("Celular: " + txtCelular.Text, font, Brushes.Black, new Rectangle(20, y += 30, 1000, 60));

            e.Graphics.DrawString("Serie: " + txtSerie.Text, font, Brushes.Black, new Rectangle(500, y + 30, 1000, 60));

          //  e.Graphics.DrawString("Accesorios: " + txtComplemento.Text, font, Brushes.Black, new Rectangle(20, y += 60, 1000, 60));

            e.Graphics.DrawString("Falla: " + txtFalla.Text, font, Brushes.Black, new Rectangle(20, y += 60, 1000, 60));

            e.Graphics.DrawString("Accesorio", font, Brushes.Black, new Rectangle(20, y += 60, 1000, 60));
            e.Graphics.DrawString("Serie", font, Brushes.Black, new Rectangle(150, y + 0, 1000, 60));
            e.Graphics.DrawString("Observacion", font, Brushes.Black, new Rectangle(230, y + 0, 1000, 60));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Accesorio"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +



               row["Serie"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +

                row["Observacion"].ToString() + " " + " " + " " + " " + " "


                   , font2, Brushes.Black, new Rectangle(20, y += 25, 1000, 60));
            }

            e.Graphics.DrawImage(picturePie.Image, new Rectangle(5, y += 25, 850, 50));

            e.Graphics.DrawString("Condiciones generales", font2, Brushes.Black, new Rectangle(360, 120, 1000, 60));
            e.Graphics.DrawString("I. Todo equipo nuevo viene con su póliza de garantía en la cual se especifican los términos de la misma.", font2, Brushes.Black, new Rectangle(20, 140, 900, 60));
            e.Graphics.DrawString("II. Toda revisión de equipos fuera de su garantía genera un cargo, siendo el monto minimo de $100.00 + IVA \n el cual cambiará de acuerdo al modelo del equipo.", font2, Brushes.Black, new Rectangle(20, 160, 900, 60));
            e.Graphics.DrawString("III. Toda reparación que requiera cambio de parte, se solicitara el 50% de anticipo.", font2, Brushes.Black, new Rectangle(20, 190, 900, 60));
            e.Graphics.DrawString("IV. Toda revisión o reparación en la que no proceda la garantía tendra un costo.", font2, Brushes.Black, new Rectangle(20, 210, 900, 60));
            e.Graphics.DrawString("V. La garantía del equipo no cubre problemas de software(programas y aplicaciones) únicamente problemas de hardware (daños fisicos).", font2, Brushes.Black, new Rectangle(20, 230, 900, 60));
            e.Graphics.DrawString("VI. La garantía del equipo tampoco cubre el servicio de mantenimiento preventivo.", font2, Brushes.Black, new Rectangle(20, 250, 900, 60));
            e.Graphics.DrawString("VII. La garantía del servicio es de 30 días naturales.", font2, Brushes.Black, new Rectangle(20, 270, 900, 60));
            e.Graphics.DrawString("VIII. En el caso de la información contenida en el disco duro es RESPONSABILIDAD ABSOLUTA DEL CLIENTE.", font2, Brushes.Black, new Rectangle(20, 290, 900, 60));
            e.Graphics.DrawString("IX. Todo equipo que no se haya recogido después de 8 días de habérse notificado al cliente, tendrá un cargo de almacenamiento de $15.00 por día", font2, Brushes.Black, new Rectangle(20, 310, 900, 60));
            e.Graphics.DrawString("X. Transcurridos 30 días naturales después de la notificación, el equipo se pasará al almacén de destrucción sin ninguna  responsabilidad para \n Computadoras Centro de Servicio.", font2, Brushes.Black, new Rectangle(20, 330, 900, 60));
            e.Graphics.DrawString("XI. El horario para seguimiento de reportes es de 10:00 a 19:00 hrs. de lunes a viernes, sábados de 10:00 a 14:00 hrs. \n a los teléfonos 444-817-5710, 444-128-6760, WhatsApp 444-427-3576.", font2, Brushes.Black, new Rectangle(20, 360, 900, 60));

            e.Graphics.DrawString("ACEPTO", font2, Brushes.Black, new Rectangle(80, 390, 800, 60));
            e.Graphics.DrawString("NOMBRE Y FIRMA", font2, Brushes.Black, new Rectangle(50, 410, 900, 60));

            e.Graphics.DrawString("RECIBE", font2, Brushes.Black, new Rectangle(630, 390, 880, 60));
            e.Graphics.DrawString(cmbAtendio.Text, font2, Brushes.Black, new Rectangle(600, 410, 900, 60));
            /*//e.Graphics.DrawString(txtTitulo.Text, font, Brushes.Black, 50, 130);
            Bitmap varbmp = new Bitmap(este.Image);
            Image img = este.Image;
            e.Graphics.DrawImage(img, new Rectangle(20, 30, 185, 50));
            e.Graphics.DrawString("*" + txtCodigo.Text + "*", font, Brushes.Black, new Rectangle(75, 85, 150, 20)); */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea agregar una nueva orden? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                txtCliente.Text = "";
                txtCelular.Text = "";
                txtEquipo.Text = "";
                txtModelo.Text = "";
                txtSerie.Text = "";
                txtFalla.Text = "";
              //  txtComplemento.Text = "";
                txtOrden.Text = ConsultaOrdenId();
            }

        }

        private void txtReimprimir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_gridConsulta();
            txtEquipo.Text = ConsultaEquipoTipoR();
            txtModelo.Text = ConsultaEquipoModeloR();
            txtSerie.Text = ConsultaEquipoSerieR();
            txtCliente.Text = ConsultaUsuarioNombreR();
            txtCelular.Text = ConsultaUsuarioCelularR();
            datei.Text = ConsultaOrdenFechaR();
            cmbAtendio.Text = ConsultaEmpleadoNombreR();
            cmbStatus.Text = ConsultaOrdenStatusR();
            txtFalla.Text = ConsultaOrdenFallaR();
           // txtComplemento.Text = ConsultaOrdenComplementoR();
        }

        //Mmétodos para la reimpresion



        public string ConsultaEquipoTipoR()
        {
            Conexion.Conectar();
            string query = "select Equipo.Tipo as tipo from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["tipo"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaEquipoModeloR()
        {
            Conexion.Conectar();
            string query = "select Equipo.Modelo as modelo from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["modelo"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaEquipoSerieR()
        {
            Conexion.Conectar();
            string query = "select Equipo.Serie as Serie from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["Serie"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaUsuarioNombreR()
        {
            Conexion.Conectar();
            string query = "select Usuario.Nombre as Cliente from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["Cliente"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaUsuarioCelularR()
        {
            Conexion.Conectar();
            string query = "select Usuario.Celular as celular from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["celular"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaOrdenFechaR()
        {
            Conexion.Conectar();
            string query = "select Orden.FechaI as fecha from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["fecha"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaEmpleadoNombreR()
        {
            Conexion.Conectar();
            string query = "select Empleado.nombre as empleado from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["empleado"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaOrdenStatusR()
        {
            Conexion.Conectar();
            string query = "select Orden.Status as status from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["status"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaOrdenFallaR()
        {
            Conexion.Conectar();
            string query = "select Orden.FallaC as falla from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["falla"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaOrdenComplementoR()
        {
            Conexion.Conectar();
            string query = "select Orden.Complemento as complemento from Orden INNER JOIN Usuario on Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo on Orden.idEquipo = Equipo.idEquipo INNER JOIN Empleado on Orden.idEmpleado = Empleado.idEmpleado where Orden.idOrden= '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["complemento"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["idAccesorio"] = Convert.ToInt32(cmbAccesorio.SelectedValue);
            row["Accesorio"] = cmbAccesorio.Text;
            row["Serie"] = 1;
            row["Observacion"] = 1;
            row["Orden"] = txtOrden.Text;
            dt.Rows.Add(row);

           /* InsertaSoloUsuario();
            txtClienteID.Text = ConsultaUsuId();
            InsertaAccesorio();
            ModificarUsuario();*/
        }


      /*  public void InsertaAccesorio()
        {
            Conexion.Conectar();
            string insertar = "insert into Accesorio(idUsuario,Accesorio,Serie,Observacion) values(@usuario,@Accesorio,@Serie,@Observacion)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@usuario", txtClienteID.Text);
            cmd1.Parameters.AddWithValue("@Accesorio", txtAccesorio.Text);
            cmd1.Parameters.AddWithValue("@Serie", txtxSe.Text);
            cmd1.Parameters.AddWithValue("@Observacion", txtObs.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El Accesorio fue agregado con exito");
        }*/

        public void ModificarUsuario()
        {
            Conexion.Conectar();
            string insertar = "UPDATE Usuario SET Celular=@Celular WHERE idUsuario=@id";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Celular", txtCelular.Text);;
            cmd1.Parameters.AddWithValue("@id", txtClienteID.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El usuario fue modificado con exito");
        }

        public void InsertaSoloUsuario()
        {
            Conexion.Conectar();
            string insertar = "insert into Usuario(Nombre) values(@Nombre)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Nombre", txtCliente.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El Usuario fue agregado con exito");
        }

        public string ConsultaUsuId()
        {
            Conexion.Conectar();
            string query = "select max (idUsuario) as ID from Usuario";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["ID"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public string ConsultaEquipoID()
        {
            Conexion.Conectar();
            string query = "select max (idEquipo) as ID from Equipo";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["ID"].ToString();
            }
            else
            {
                return "NULL";
            }
        }
        
        public void InsertaAccesorio()
        {

            try
            {
                Conexion.Conectar();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "INSERT INTO AccesorioOrden(idAccesorio,idOrden,Serie,Observacion) Values (@Accesorio,@Orden,@Serie,@Observacion)";
                cmd2.Connection = Conexion.Conectar();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@Accesorio", Convert.ToString(row.Cells["idAccesorio"].Value));
                    cmd2.Parameters.AddWithValue("@Orden", Convert.ToString(row.Cells["Orden"].Value));
                    cmd2.Parameters.AddWithValue("@Serie", Convert.ToString(row.Cells["Serie"].Value));
                    cmd2.Parameters.AddWithValue("@Observacion", Convert.ToString(row.Cells["Observacion"].Value));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron actualizados con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al agregar" + ex);
            }
           
           
        }

    }
}
