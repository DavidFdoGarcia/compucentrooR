using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compucentro4
{
    class clsOrden
    {
        private Conexion Conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarAccesorios()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "ListarAccesorios";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            return Tabla;
        }

        //metodo para cargar la coleccion de datos para el autocomplete (combo Accesorios)
        public AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = ListarAccesorios();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["TipoAccesorio"]));
            }

            return coleccion;
        }

        public DataTable InsertaDiagnostico(int idOrden,string Diagnostico)
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "InsertaDiagnostico";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idOrden", idOrden);
            Comando.Parameters.AddWithValue("@diagnostico", Diagnostico);
            MessageBox.Show("Se agrego el diagnostico");
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            return Tabla;
        }

        public DataTable ListarClientes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "ListarClientes";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            return Tabla;
        }

        public AutoCompleteStringCollection AutocompleteClientes()
        {
            DataTable dt = ListarClientes();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
            }

            return coleccion;
        }
    }
}
