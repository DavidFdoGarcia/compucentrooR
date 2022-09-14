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
    public partial class Tecnico : Base
    {
        public Tecnico()
        {
            InitializeComponent();
        }

        private void Tecnico_Load(object sender, EventArgs e)
        {

        }

        public void InsertaTecnico()
        {
            Conexion.Conectar();
            string insertar = "insert into Operador(nombre,direccion,telefono) values(@nombre,@direccion,@telefono)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            cmd1.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El Técnico fue agregado con exito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo Técnico? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaTecnico();
            }
        }
    }
}
