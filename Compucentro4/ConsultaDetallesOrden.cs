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
    public partial class ConsultaDetallesOrden : Base
    {
        public ConsultaDetallesOrden()
        {
            InitializeComponent();
        }

        private void ConsultaDetallesOrden_Load(object sender, EventArgs e)
        {

        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.idOrden='" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);


        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
