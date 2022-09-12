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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo usuario? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaOrden();
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
            Font font = new Font("Century Gotic", 15, FontStyle.Bold);
            e.Graphics.DrawImage(pictureBox1.Image, 2, 5);
            e.Graphics.DrawString("Orden de Servicio", font, Brushes.Black, new Rectangle(350, 200, 1000, 20));
             /*//e.Graphics.DrawString(txtTitulo.Text, font, Brushes.Black, 50, 130);
             Bitmap varbmp = new Bitmap(este.Image);
             Image img = este.Image;
             e.Graphics.DrawImage(img, new Rectangle(20, 30, 185, 50));
             e.Graphics.DrawString("*" + txtCodigo.Text + "*", font, Brushes.Black, new Rectangle(75, 85, 150, 20)); */
        }
    }
}
