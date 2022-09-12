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
    public partial class AltaEquipo : Base
    {
        public AltaEquipo()
        {
            InitializeComponent();
        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {

        }

        //Métodos

        public void InsertaEquipo()
        {
            Conexion.Conectar();
            string insertar = "insert into Equipo(Tipo,Modelo,Serie) values(@tipo,@modelo,@serie)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@tipo", txtTipo.Text);
            cmd1.Parameters.AddWithValue("@modelo", txtModelo.Text);
            cmd1.Parameters.AddWithValue("@serie", txtSerie.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El Equipo fue agregado con exito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo equipo? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaEquipo();
            }
        }
    }
}
