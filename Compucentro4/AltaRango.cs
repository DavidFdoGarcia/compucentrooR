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
    public partial class AltaRango : Base
    {
        public AltaRango()
        {
            InitializeComponent();
        }

        private void AltaRango_Load(object sender, EventArgs e)
        {

        }

        //Métodos

        public void InsertaCargo()
        {
            Conexion.Conectar();
            string insertar = "insert into Rango(cargo) values(@cargo)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cargo", txtCargo.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El cargo fue agregado con exito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo cargo? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaCargo();
            }
        }
    }
}
