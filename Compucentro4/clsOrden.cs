using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
