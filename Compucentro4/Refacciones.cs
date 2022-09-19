using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compucentro4
{
    public partial class Refacciones : Base
    {
        public Refacciones()
        {
            InitializeComponent();
        }

        private void Refacciones_Load(object sender, EventArgs e)
        {

        }

        public void InsertaRefaccion()
        {
            Conexion.Conectar();
            string insertar = "insert into Refaccion(Nombre,Precio,Cantidad,Importe) values(@Nombre,@Precio,@Cantidad,@Importe)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Nombre", txtRefaccion.Text);
            cmd1.Parameters.AddWithValue("@Precio", txtPrecio.Text);
            cmd1.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
            cmd1.Parameters.AddWithValue("@Importe", txtImporte.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("La Refacción fue agregada con exito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertaRefaccion();
        }
    }
}
