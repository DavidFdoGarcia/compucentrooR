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
    public partial class OrdenFiltros : Base
    {
        public OrdenFiltros()
        {
            InitializeComponent();
        }

        private void OrdenFiltros_Load(object sender, EventArgs e)
        {

        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            String Fecha1 = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            String Fecha2 = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.FechaI BETWEEN '" + Fecha1 + "' AND '" + Fecha2 + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);


        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells["garantia"].Value.ToString();
        }


        public string Consultagarantia()
        {
            Conexion.Conectar();
            String fecha = dateTimePicker3.Value.Date.Year.ToString() + "/" + dateTimePicker3.Value.Date.Month.ToString() + "/" + dateTimePicker3.Value.Date.Day.ToString();
            string query = "SELECT DATEDIFF( dd , GETDATE() , '"+fecha+"') as garantia";
            SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                return reg["garantia"].ToString();
            }
            else
            {
                return "NULL";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Consultagarantia();
        }
    }
}
