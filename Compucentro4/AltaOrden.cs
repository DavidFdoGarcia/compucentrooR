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
    public partial class AltaOrden : Base
    {
        public AltaOrden()
        {
            InitializeComponent();
        }

        private void AltaOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleado.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.empleado.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'usuaario2.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter1.Fill(this.usuaario2.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'equipo._Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.equipo._Equipo);
            // TODO: esta línea de código carga datos en la tabla 'cliente.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.cliente.Usuario);

        }

        //Métodos

        public void InsertaOrden()
        {
            Conexion.Conectar();
            string insertar = "insert into Orden(idEquipo,idUsuario,Complemento,FallaC,Status,idEmpleado) values(@equipo,@usuario,@complemento,@fallaC,@status,@empleado)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@equipo", cmbIDEquipo.Text);
            cmd1.Parameters.AddWithValue("@usuario", cmbIDCliente.Text);
            
            cmd1.Parameters.AddWithValue("@complemento", txtComplemento.Text);
            cmd1.Parameters.AddWithValue("@fallaC", txtFalla.Text);
            cmd1.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd1.Parameters.AddWithValue("@empleado", cmbAtendioID.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("La orden fue agregado con exito");
        }

        public string ConsultaOrdenId()
        {
            Conexion.Conectar();
            string query = "select max (idOrden) as ID from Orden";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo usuario? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaOrden();
                txtOrden.Text = ConsultaOrdenId();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           // visor v = new visor();
            //v.Show();
             PrintDialog pd = new PrintDialog();
             PrintDocument doc = new PrintDocument();
             doc.PrintPage += Imprimir;
             pd.Document = doc;
             if (pd.ShowDialog() == DialogResult.OK)
             {
                 doc.Print();
             } 
          /*  ReportDocument cryRpt = new ReportDocument();

            //cryRpt.Load(@"C:\Users\Gerardo\Desktop\RepositoriosC\Compucentro4\Compucentro4\ORDEN.rpt");
            cryRpt.Load(@"C:\Users\Compucentro\  Compucentro4\ORDEN.rpt");

            cryRpt.SetDatabaseLogon("dttdato", "123456");
            cryRpt.SetParameterValue("@id", txtOrden.Text);
            v.crystalReportViewer1.ReportSource = cryRpt;

            v.crystalReportViewer1.Refresh();*/
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            //                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            e.Graphics.DrawImage(pictureBox1.Image, 2, 5);
            e.Graphics.DrawString("Orden de Servicio", font, Brushes.Black, new Rectangle(360, 120, 1000, 60));

            e.Graphics.DrawString("Fecha de Ingreso:", font, Brushes.Black, new Rectangle(20, 140, 1000, 60));
            e.Graphics.DrawString(datei.Text, font, Brushes.Black, new Rectangle(205, 140, 1000, 60));

            e.Graphics.DrawString("No.Orden:", font, Brushes.Black, new Rectangle(600, 140, 1000, 60));
            e.Graphics.DrawString(txtOrden.Text, font, Brushes.Black, new Rectangle(710, 140, 1000, 60));

            e.Graphics.DrawString("Cliente:", font, Brushes.Black, new Rectangle(20, 180, 1000, 60));
            e.Graphics.DrawString(cmbCliente.Text, font, Brushes.Black, new Rectangle(160, 180, 1000, 60));

            e.Graphics.DrawString("Equipo:", font, Brushes.Black, new Rectangle(600, 180, 1000, 60));
            e.Graphics.DrawString(txtEquipo.Text, font, Brushes.Black, new Rectangle(700, 180, 1000, 60));

            e.Graphics.DrawString("No. Serie:", font, Brushes.Black, new Rectangle(20, 220, 1000, 60));
            e.Graphics.DrawString(cmbSerie.Text, font, Brushes.Black, new Rectangle(120, 220, 1000, 60));

            e.Graphics.DrawString("Modelo:", font, Brushes.Black, new Rectangle(350, 220, 1000, 60));
            e.Graphics.DrawString(cmbSerie.Text, font, Brushes.Black, new Rectangle(450, 220, 1000, 60));

            e.Graphics.DrawString("Accesorios:", font, Brushes.Black, new Rectangle(20, 260, 1000, 60));
            e.Graphics.DrawString(txtComplemento.Text, font, Brushes.Black, new Rectangle(150, 260, 1000, 60));

            e.Graphics.DrawString("Falla:", font, Brushes.Black, new Rectangle(20, 340, 1000, 60));
            e.Graphics.DrawString(txtFalla.Text, font, Brushes.Black, new Rectangle(150, 340, 1000, 60));

            e.Graphics.DrawString("Condiciones generales", font, Brushes.Black, new Rectangle(360, 410, 1000, 60));
            e.Graphics.DrawString("I. Todo equipo nuevo viene con su póliza de garantía en la cual se especifican los términos \n de la misma.", font, Brushes.Black, new Rectangle(20, 450, 900, 60));
            e.Graphics.DrawString("II. Toda revisión de equipos fuera de su garantía genera un cargo, siendo el monto minimo \n de $100.00 + IVA el cual cambiará de acuerdo al modelo del equipo.", font, Brushes.Black, new Rectangle(20, 490, 900, 60));
            e.Graphics.DrawString("III. Toda reparación que requiera cambio de parte, se solicitara el 50% de anticipo.", font, Brushes.Black, new Rectangle(20, 530, 900, 60));
            e.Graphics.DrawString("IV. Toda revisión o reparación en la que no proceda la garantía tendra un costo.", font, Brushes.Black, new Rectangle(20, 570, 900, 60));
            e.Graphics.DrawString("V. La garantía del equipo no cubre problemas de software(programas y aplicaciones) \n únicamente problemas de hardware (daños fisicos).", font, Brushes.Black, new Rectangle(20, 610, 900, 60));
            e.Graphics.DrawString("VI. La garantía del equipo tampoco cubre el servicio de mantenimiento preventivo.", font, Brushes.Black, new Rectangle(20, 650, 900, 60));
            e.Graphics.DrawString("VII. La garantía del servicio es de 30 días naturales.", font, Brushes.Black, new Rectangle(20, 690, 900, 60));
            e.Graphics.DrawString("VIII. En el caso de la información contenida en el disco duro es RESPONSABILIDAD ABSOLUTA DEL CLIENTE.", font, Brushes.Black, new Rectangle(20,730, 900, 60));
            e.Graphics.DrawString("IX. Todo equipo que no se haya recogido después de 8 días de habérse notiicado al cliente, \n tendrá un cargo de almacenamiento de $15.00 por día", font, Brushes.Black, new Rectangle(20, 770, 900, 60));
            e.Graphics.DrawString("X. Transcurridos 30 días naturales después de la notificación, el equipo se pasará al almacén de destrucción \n sin ninguna responsabilidad para Computadoras Centro de Servicio.", font, Brushes.Black, new Rectangle(20, 810, 900, 60));
            e.Graphics.DrawString("XI. El horario para seguimiento de reportes es de 10:00 a 19:00 hrs. de lunes a viernes, \n sábados de 10:00 a 14:00 hrs. a los teléfonos 444-817-5710, 444-128-6760, WhatsApp 444-427-3576.", font, Brushes.Black, new Rectangle(20, 850, 900, 60));

            e.Graphics.DrawString("ACEPTO", font, Brushes.Black, new Rectangle(80, 900, 800, 60));
            e.Graphics.DrawString("NOMBRE Y FIRMA", font, Brushes.Black, new Rectangle(50, 1000, 900, 60));

            e.Graphics.DrawString("RECIBE", font, Brushes.Black, new Rectangle(630, 900, 800, 60));
            e.Graphics.DrawString("CCS", font, Brushes.Black, new Rectangle(600, 1000, 900, 60));
            /*//e.Graphics.DrawString(txtTitulo.Text, font, Brushes.Black, 50, 130);
            Bitmap varbmp = new Bitmap(este.Image);
            Image img = este.Image;
            e.Graphics.DrawImage(img, new Rectangle(20, 30, 185, 50));
            e.Graphics.DrawString("*" + txtCodigo.Text + "*", font, Brushes.Black, new Rectangle(75, 85, 150, 20)); */
        }
    }
}
