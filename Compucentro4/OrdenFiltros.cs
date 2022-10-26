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

            clsOrden ObjOrden = new clsOrden();
        }

        private void OrdenFiltros_Load(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            ListarClientes();
            dgv.Formato(dataGridView1, 1);

            cmbStatus.SelectedIndex = 0;
        }

        public void ModificarOrdenStatus()
        {
            Conexion.Conectar();
            string actualizar = " update Orden set Status = @Status where idOrden = @Orden";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@Status", cmbStatus.Text);
            cmd2.Parameters.AddWithValue("@Orden", txtOrden.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
        }

        private void ListarClientes() //Llena combo con los Nombres
        {
            clsOrden ObjOrden = new clsOrden();
            cmbNombre.DataSource = ObjOrden.ListarClientes();
            cmbNombre.DisplayMember = "Nombre";
            cmbNombre.ValueMember = "idUsuario";

            // cargo la lista de items para el autocomplete dle combobox
            cmbNombre.AutoCompleteCustomSource = ObjOrden.AutocompleteClientes();
            cmbNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public DataTable llenar_gridNombre()
        {
            Conexion.Conectar();
            String Fecha1 = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            String Fecha2 = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia,DATEDIFF( dd , GETDATE() , Garantia) as dias from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Usuario.Nombre='" + cmbNombre.Text+"'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);


        }

        public DataTable llenar_gridTodos()
        {
            Conexion.Conectar();
            String Fecha1 = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            String Fecha2 = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia,DATEDIFF( dd , GETDATE() , Garantia) as dias from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.FechaI BETWEEN '" + Fecha1 + "' AND '" + Fecha2 + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);


        }

        public DataTable llenar_gridEntregado()
        {
            Conexion.Conectar();
            String Fecha1 = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            String Fecha2 = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia,DATEDIFF( dd , GETDATE() , Garantia) as dias from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.FechaI BETWEEN '" + Fecha1 + "' AND '" + Fecha2 + "' and Status ='Entregado'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);
        }

        public DataTable llenar_gridOrden()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia,DATEDIFF( dd , GETDATE() , Garantia) as dias from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.IdOrden =  '" + txtOrden.Text + "'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);
        }

        public DataTable llenar_gridPendiente()
        {
            Conexion.Conectar();
            String Fecha1 = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            String Fecha2 = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            DataTable dt = new DataTable();
            string consulta = "select Orden.idOrden as Orden, Equipo.Tipo as Equipo, Orden.FallaC as Falla,Usuario.Nombre as Cliente,Orden.FechaI as Ingreso,Orden.Status,Orden.ImporteTotal as Importe, Orden.garantia,DATEDIFF( dd , GETDATE() , Garantia) as dias from Orden INNER JOIN Usuario ON Orden.idUsuario = Usuario.idUsuario INNER JOIN Equipo ON Equipo.idEquipo = Orden.idEquipo where Orden.FechaI BETWEEN '" + Fecha1 + "' AND '" + Fecha2 + "' and Status ='Activo'";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return (dt);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
            {
                dataGridView1.DataSource = llenar_gridTodos();
            }

            if (rdbEntregado.Checked)
            {
                dataGridView1.DataSource = llenar_gridEntregado();
            }

            if (rdbPendiente.Checked)
            {
                dataGridView1.DataSource = llenar_gridPendiente();
            }

            if (rdbNombre.Checked)
            {
                dataGridView1.DataSource = llenar_gridNombre();
            }
            if (rdbOrden.Checked)
            {
                dataGridView1.DataSource = llenar_gridOrden();
            }
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

    

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            cmbNombre.Enabled = true;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            cmbNombre.Enabled = false;
        }

        private void rdbEntregado_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            cmbNombre.Enabled = false;
        }

        private void rdbPendiente_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            cmbNombre.Enabled = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "dias")
                {
                    if (Convert.ToInt32(e.Value) <= 30)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Green;
                    }

                    if (Convert.ToInt32(e.Value) <= 10)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModificarOrdenStatus();
            dataGridView1.DataSource = llenar_gridOrden();
        }
    }
}

