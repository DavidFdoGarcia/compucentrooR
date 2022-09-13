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
            string Alta = dateI.Value.ToShortDateString();
            string insertar = "insert into Orden(idEquipo,idUsuario,FechaI,Complemento,FallaC) values(@equipo,@usuario,@fechaI,@complemento,@fallaC)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@equipo", cmbIDEquipo.Text);
            cmd1.Parameters.AddWithValue("@usuario", cmbIDCliente.Text);
            cmd1.Parameters.AddWithValue("@fechaI", Alta);
            cmd1.Parameters.AddWithValue("@complemento", txtComplemento.Text);
            cmd1.Parameters.AddWithValue("@fallaC", txtFalla.Text);
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
           /* PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Imprimir;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            } */
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font font = new Font("Century Gotic", 15, FontStyle.Bold);
            e.Graphics.DrawImage(pictureBox1.Image, 2, 5);
            e.Graphics.DrawString("Orden de Servicio", font, Brushes.Black, new Rectangle(360, 200, 1000, 20));

            e.Graphics.DrawString("Fecha de Ingreso:", font, Brushes.Black, new Rectangle(20, 230, 1000, 30));
            e.Graphics.DrawString(dateI.Text, font, Brushes.Black, new Rectangle(200, 230, 1000, 30));

            e.Graphics.DrawString("No.Orden:", font, Brushes.Black, new Rectangle(600, 230, 1000, 40));
            e.Graphics.DrawString(txtOrden.Text, font, Brushes.Black, new Rectangle(710, 230, 1000, 40));

            e.Graphics.DrawString("Cliente:", font, Brushes.Black, new Rectangle(20, 280, 1000, 40));
            e.Graphics.DrawString(cmbCliente.Text, font, Brushes.Black, new Rectangle(120, 280, 1000, 40));

            e.Graphics.DrawString("No. Serie:", font, Brushes.Black, new Rectangle(20, 340, 1000, 40));
            e.Graphics.DrawString(cmbSerie.Text, font, Brushes.Black, new Rectangle(120, 340, 1000, 40));

            e.Graphics.DrawString("Modelo:", font, Brushes.Black, new Rectangle(350, 340, 1000, 40));
            e.Graphics.DrawString(cmbSerie.Text, font, Brushes.Black, new Rectangle(450, 340, 1000, 40));

            e.Graphics.DrawString("Equipo:", font, Brushes.Black, new Rectangle(500, 280, 1000, 40));
            e.Graphics.DrawString(txtEquipo.Text, font, Brushes.Black, new Rectangle(600, 280, 1000, 40));

            e.Graphics.DrawString("Accesorios:", font, Brushes.Black, new Rectangle(20, 400, 1000, 40));
            e.Graphics.DrawString(txtComplemento.Text, font, Brushes.Black, new Rectangle(150, 400, 1000, 40));

            e.Graphics.DrawString("Falla:", font, Brushes.Black, new Rectangle(20, 440, 1000, 40));
            e.Graphics.DrawString(txtFalla.Text, font, Brushes.Black, new Rectangle(150, 440, 1000, 40));
            /*//e.Graphics.DrawString(txtTitulo.Text, font, Brushes.Black, 50, 130);
            Bitmap varbmp = new Bitmap(este.Image);
            Image img = este.Image;
            e.Graphics.DrawImage(img, new Rectangle(20, 30, 185, 50));
            e.Graphics.DrawString("*" + txtCodigo.Text + "*", font, Brushes.Black, new Rectangle(75, 85, 150, 20)); */
        }
    }
}
