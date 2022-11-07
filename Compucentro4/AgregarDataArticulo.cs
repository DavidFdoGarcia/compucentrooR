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
    public partial class AgregarDataArticulo : Base
    {
        private DataTable dt; //DatasTable para el Grid
        public AgregarDataArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["idAccesorio"] = Convert.ToInt32(cmbAccesorio.SelectedValue);
            row["Accesorio"] = cmbAccesorio.Text;
            row["Serie"] = 1;
            row["Observacion"] = 1;
            row["Orden"] = txtOrden.Text;
            dt.Rows.Add(row);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cmbAccesorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarDataArticulo_Load(object sender, EventArgs e)
        {

            clsOrden ObjOrden = new clsOrden(); //Objeto a la clase orden

            //DataTable para llenar el Grid
            dt = new DataTable();
            dt.Columns.Add("idAccesorio");
            dt.Columns.Add("Accesorio");
            dt.Columns.Add("Serie");
            dt.Columns.Add("Observacion");
            dt.Columns.Add("Orden");

            dataGridView1.DataSource = dt;

            ListarAccesorios();
        }

        private void ListarAccesorios() //Llena combo de accesorios
        {
            clsOrden ObjOrden = new clsOrden();
            cmbAccesorio.DataSource = ObjOrden.ListarAccesorios();
            cmbAccesorio.DisplayMember = "TipoAccesorio";
            cmbAccesorio.ValueMember = "idAccesorio";

            // cargo la lista de items para el autocomplete dle combobox
            cmbAccesorio.AutoCompleteCustomSource = ObjOrden.Autocomplete();
            cmbAccesorio.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbAccesorio.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public void InsertaAccesorio()
        {

            try
            {
                Conexion.Conectar();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "INSERT INTO AccesorioOrden(idAccesorio,idOrden,Serie,Observacion) Values (@Accesorio,@Orden,@Serie,@Observacion)";
                cmd2.Connection = Conexion.Conectar();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@Accesorio", Convert.ToString(row.Cells["idAccesorio"].Value));
                    cmd2.Parameters.AddWithValue("@Orden", Convert.ToString(row.Cells["Orden"].Value));
                    cmd2.Parameters.AddWithValue("@Serie", Convert.ToString(row.Cells["Serie"].Value));
                    cmd2.Parameters.AddWithValue("@Observacion", Convert.ToString(row.Cells["Observacion"].Value));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron actualizados con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al agregar" + ex);
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea dar de alta la orden? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
               
                InsertaAccesorio();
            }
        }
    }
}
