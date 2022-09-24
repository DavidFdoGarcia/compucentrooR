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
    public partial class ConsultaOrden : Base
    {
        public ConsultaOrden()
        {
            InitializeComponent();
        }

        private void ConsultaOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clienteee.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.clienteee.Usuario);
            
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = " select Usuario.Nombre,Orden.FechaI,Reporte.idReporte, Refaccion.Nombre from Usuario inner join Orden on Orden.idUsuario = Usuario.idUsuario inner join Reporte on Orden.idOrden = Reporte.idOrden inner join Refaccion on Orden.idOrden = Refaccion.idOrden where Usuario.Nombre='" + cmbCliente.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
