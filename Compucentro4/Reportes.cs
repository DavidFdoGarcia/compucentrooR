using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Reportes : Base
    {
        private DataTable dt;
        public Reportes()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Importe");

            dgvver.DataSource = dt;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioModificado.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter2.Fill(this.usuarioModificado.Usuario);

            // TODO: esta línea de código carga datos en la tabla 'equipo._Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.equipo._Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dataTecnico.Operador' Puede moverla o quitarla según sea necesario.
            this.operadorTableAdapter.Fill(this.dataTecnico.Operador);
           /* dgvver.Columns.Add("Cantidad", "Cantidad");
            dgvver.Columns.Add("Descripcion", "Descripcion");
            dgvver.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvver.Columns.Add("Importe", "Importe");*/

        }

        public void cargardatagrid()
        {
            Conexion.Conectar();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Nombre,Cantidad,Precio,Importe from Refaccion where idOrden = '" + txtOrden.Text + "'", Conexion.Conectar());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvver.DataSource = dtbl;

        }

        public string ConsultaFecha()
        {
            Conexion.Conectar();
            string query = "SELECT FechaS FROM Orden WHERE idOrden = '"+txtOrden.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["FechaS"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public void InsertaRefaccion()
        {
            double imp = double.Parse(txtPrecio.Text) * double.Parse(txtCantidad.Text);
            Conexion.Conectar();
            string insertar = "insert into Refaccion(idOrden,Nombre,Precio,Cantidad,Importe) values(@idOrden,@Nombre,@Precio,@Cantidad,@Importe)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@idOrden", txtOrden.Text);
            cmd1.Parameters.AddWithValue("@Nombre", txtPieza.Text);
            cmd1.Parameters.AddWithValue("@Precio", txtPrecio.Text);
            cmd1.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
            cmd1.Parameters.AddWithValue("@Importe", imp);
            cmd1.ExecuteNonQuery();
           // MessageBox.Show("La Refacción fue agregada con exito");
        }

        public void InsertaReporte()
        {
            Conexion.Conectar();
            string insertar = "insert into Reporte(idOrden,idOperador,DescripcionFalla) values(@idOrden,@idOperador,@DescripcionFalla)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@idOrden", txtOrden.Text);
            cmd1.Parameters.AddWithValue("@idOperador", cmbReparoID.Text);
            cmd1.Parameters.AddWithValue("@DescripcionFalla", txtReporte.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El reporte fue agregado con exito");
        }

        public void cargardatagridEditar() //todas las facturas
        {

            //variable de tipo Sqlconnection
            SqlConnection con = new SqlConnection("Data Source=192.168.1.151;Initial Catalog=compucentro4;User ID=dttdato;Password=123456");
            //variable de tipo Sqlcommand
            SqlCommand comando = new SqlCommand("Data Source=192.168.1.151;Initial Catalog=compucentro4;User ID=dttdato;Password=123456");
            //variable SqlDataReader para leer los datos
            SqlDataReader dr;

            //declaramos el comando para realizar la busqueda
            comando.CommandText = "SELECT Nombre,Cantidad,Precio,Importe from Refaccion where idOrden = '" + txtOrden.Text + "'";
            //especificamos que es de tipo Text
            comando.CommandType = CommandType.Text;
            //se abre la conexion
            Conexion.Conectar();
            //limpiamos los renglones de la datagridview
            dgvver.Rows.Clear();
            //a la variable DataReader asignamos  el la variable de tipo SqlCommand
            dr = comando.ExecuteReader();
            //el ciclo while se ejecutará mientras lea registros en la tabla
            while (dr.Read())
            {
                //variable de tipo entero para ir enumerando los la filas del datagridview
                int renglon = dgvver.Rows.Add();
                // especificamos en que fila se mostrará cada registro
                // nombredeldatagrid.filas[numerodefila].celdas[nombredelacelda].valor=
                // dr.tipodedatosalmacenado(dr.getordinal(nombredelcampo_en_la_base_de_datos)conviertelo_a_string_sino_es_del_tipo_string);
                dgvver.Rows[renglon].Cells["Nombre"].Value = dr.GetValue(dr.GetOrdinal("Nombre")).ToString();
                dgvver.Rows[renglon].Cells["Cantidad"].Value = dr.GetValue(dr.GetOrdinal("Cantidad"));
                dgvver.Rows[renglon].Cells["Precio"].Value = dr.GetValue(dr.GetOrdinal("Precio"));
                dgvver.Rows[renglon].Cells["Importe"].Value = dr.GetValue(dr.GetOrdinal("Importe"));


            }
            //cierra la conexión
            con.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            InsertaRefaccion();
            /*int indice_fila = dgvver.Rows.Add();
            DataGridViewRow row = dgvver.Rows[indice_fila];

            row.Cells["Cantidad"].Value = txtCantidad.Text;
            row.Cells["Descripcion"].Value = txtPieza.Text;
            row.Cells["PrecioUnitario"].Value = txtPrecio.Text;
            row.Cells["Importe"].Value = decimal.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);*/

            DataRow row = dt.NewRow();

            row["Cantidad"] = txtCantidad.Text;
            row["Descripcion"] = txtPieza.Text;
            row["Precio"] = txtPrecio.Text;
            row["Importe"] = decimal.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);

            dt.Rows.Add(row);
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
            /* PrintDocument doc = new PrintDocument();
             //doc.DefaultPageSettings.Landscape = true;
             doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

             PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
             ((Form)ppd).WindowState = FormWindowState.Maximized;

             doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
             {
                 const int DGV_ALTO = 35;
                 int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                 foreach (DataGridViewColumn col in dgvver.Columns)
                 {
                     ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                     left += col.Width * 2; //col.Width

                     if (col.Index < dgvver.ColumnCount - 1)
                         ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvver.RowCount - 1) * DGV_ALTO);
                 }
                 left = ep.MarginBounds.Left;
                 ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                 top += 43;

                 foreach (DataGridViewRow row in dgvver.Rows)
                 {
                     if (row.Index == dgvver.RowCount - 1) break;
                     left = ep.MarginBounds.Left;

                     foreach (DataGridViewCell cell in row.Cells)
                     {
                         ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 10), Brushes.Black, left, top + 4);
                         left += cell.OwningColumn.Width * 2;
                     }
                     top += DGV_ALTO;
                     ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                 }
             };
             ppd.ShowDialog();
         }*/

            /*SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.index.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMERO", txtOrden.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", cmbCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@REPARO", cmbReparo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EQUIPO", cmbEquipo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MODELO", txtModelo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SERIE", txtSerie.Text);

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvver.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                     iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                     img.ScaleToFit(60, 60);
                     img.Alignment = iTextSharp.text.Image.UNDERLYING;

                     //img.SetAbsolutePosition(10,100);
                     img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                     pdfDoc.Add(img);
                     

                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }*/
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            int ancho = 1000;
            int y = 20;
            //Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font font2 = new Font("Arial", 8, FontStyle.Bold);
            //  
            e.Graphics.DrawImage(pictureCabecera.Image, new Rectangle(5, 5, 850, 80)); 
            e.Graphics.DrawString("Reporte de Orde No.: " + txtOrden.Text, font, Brushes.Black, new Rectangle(360, y+=50, ancho, 60));
            e.Graphics.DrawString("Entregado: " + txtFecha.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("Cliente: " + cmbCliente.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("Modelo: " + txtModelo.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("Equipo: " + cmbEquipo.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("Reparó: " + cmbReparo.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("No. Serie: " + txtSerie.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));
            e.Graphics.DrawString("Reporte: " + txtReporte.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("No. Refacciones", font, Brushes.Black, new Rectangle(270, y += 50, ancho, 60));

            e.Graphics.DrawString("Cant.", font, Brushes.Black, new Rectangle(50, y + 20, ancho, 60));
            e.Graphics.DrawString("Descripción", font, Brushes.Black, new Rectangle(120, y + 20, ancho, 60));
            e.Graphics.DrawString("Precio", font, Brushes.Black, new Rectangle(230, y + 20, ancho, 60));
            e.Graphics.DrawString("Importe", font, Brushes.Black, new Rectangle(290, y + 20, ancho, 60));




         
    foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Cantidad"].ToString() + " " + " " + " " + " " + " " +" " + " " + " " + " " + " " + " " + " " +" " + " " + " " +



               row["Descripcion"].ToString() +  " " + " " + " " + " " + " "+ " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " "+ " " + " " + " " + " " + " " + " " + " " + " " + " " + " "  +" " + " " + " " + " " + " " +

                row["Precio"].ToString() + " " + " " + " " + " " + " " +

                row["Importe"].ToString()

                   , font2, Brushes.Black, new Rectangle(50, y += 40, 1000, 60));

                
            }
            e.Graphics.DrawString("Monto a pagar: " + txtMonto.Text, font, Brushes.Black, new Rectangle(50, y += 50, 1000, 60));
            e.Graphics.DrawString("Firma de conformidad", font, Brushes.Black, new Rectangle(50, y += 40, ancho, 60));
            e.Graphics.DrawImage(pictureBox2.Image, new Rectangle(5, y += 80, 850, 50));


            e.Graphics.DrawImage(pictureCabecera.Image, new Rectangle(5, y=580, 850, 80));
            e.Graphics.DrawString("Reporte de Orden No.: " + txtOrden.Text, font, Brushes.Black, new Rectangle(360, y += 70, ancho, 60));
            e.Graphics.DrawString("Entregado: " + txtFecha.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("Cliente: " + cmbCliente.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("Modelo: " + txtModelo.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("Equipo: " + cmbEquipo.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("Reparó: " + cmbReparo.Text, font, Brushes.Black, new Rectangle(450, y + 30, ancho, 60));
            e.Graphics.DrawString("No. Serie: " + txtSerie.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));
            e.Graphics.DrawString("Reporte: " + txtReporte.Text, font, Brushes.Black, new Rectangle(50, y += 30, ancho, 60));

            e.Graphics.DrawString("No. Refacciones", font, Brushes.Black, new Rectangle(270, y += 50, ancho, 60));

            e.Graphics.DrawString("Cant.", font, Brushes.Black, new Rectangle(50, y + 20, ancho, 60));
            e.Graphics.DrawString("Descripción", font, Brushes.Black, new Rectangle(120, y + 20, ancho, 60));
            e.Graphics.DrawString("Precio", font, Brushes.Black, new Rectangle(230, y + 20, ancho, 60));
            e.Graphics.DrawString("Importe", font, Brushes.Black, new Rectangle(290, y + 20, ancho, 60));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Cantidad"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +



               row["Descripcion"].ToString() + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " +

                row["Precio"].ToString() + " " + " " + " " + " " + " " +

                row["Importe"].ToString()

                   , font2, Brushes.Black, new Rectangle(50, y += 40, 1000, 60));


            }
            e.Graphics.DrawString("Monto a pagar: " + txtMonto.Text, font, Brushes.Black, new Rectangle(50, y += 50, 1000, 60));
            e.Graphics.DrawString("Firma de conformidad", font, Brushes.Black, new Rectangle(50, y += 40, ancho, 60));
            e.Graphics.DrawImage(pictureBox2.Image, new Rectangle(5, y += 80, 850, 50));
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = ConsultaFecha();
            InsertaReporte();


        }

        private void pictureCabecera_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmbCliente.Text = NombreCliente();
            cmbEquipo.Text = NombreEquipo();
         }

        public string NombreCliente()
        {
            Conexion.Conectar();
            string query = "select Usuario.Nombre as Cliente from Orden inner join Usuario on Usuario.idUsuario = Orden.idUsuario where idOrden = '"+txtOrden.Text+"'";
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


        public string NombreEquipo()
        {
            Conexion.Conectar();
            string query = "select Equipo.Tipo as Equipo from Orden inner join Equipo on Equipo.idEquipo = Orden.idEquipo where idOrden = '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["Equipo"].ToString();
            }
            else
            {
                return "NULL";
            }
        }
    }
    }
