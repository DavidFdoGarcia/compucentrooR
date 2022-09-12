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
    public partial class AltaUsuario : Base
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rango._Rango' Puede moverla o quitarla según sea necesario.
            this.rangoTableAdapter.Fill(this.rango._Rango);

        }

        //Métodos

        public void InsertaUsuario()
        {
            Conexion.Conectar();
            string insertar = "insert into Usuario(idRango,Nombre,Direccion,Telefono,Celular) values(@rango,@nombre,@direccion,@telefono,@celular)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@rango", cmbIDCargo.Text);
            cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            cmd1.Parameters.AddWithValue("@telefono", txtTelefono.Text);
            cmd1.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("El usuario fue agregado con exito");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Insertar un nuevo usuario? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                InsertaUsuario();
            }
        }
    }
}
