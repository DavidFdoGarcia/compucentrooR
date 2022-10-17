﻿using System;
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
    public partial class ModificarOrden : Base
    {
        public ModificarOrden()
        {
            InitializeComponent();
        }

        private void ModificarOrden_Load(object sender, EventArgs e)
        {

        }

        public void cargardatagrid()
        {
            Conexion.Conectar();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Orden.idOrden as Orden, Equipo.Tipo as Equio,Usuario.Nombre as Cliente, Orden.FechaI, Orden.FechaS, Orden.Complemento, Orden.FallaC, Orden.Status, Orden.Garantia, Empleado.Nombre as Empleado FROM Orden INNER JOIN Usuario on Usuario.idUsuario = Orden.idUsuario INNER JOIN Equipo on Equipo.idEquipo = Orden.idEquipo INNER JOIN Empleado on Empleado.idEmpleado = Orden.idEmpleado WHERE Orden.idOrden =  '" + txtOrden.Text + "'", Conexion.Conectar());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

        }


        public void MorificarOrden()
        {
            Conexion.Conectar();
            String FechaS = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            string actualizar = "UPDATE Orden SET FechaS=@FECHA,Status=@Status WHERE idOrden=@ORDEN";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@FECHA",FechaS);
            cmd2.Parameters.AddWithValue("@Status", cmbStatus.Text);
            cmd2.Parameters.AddWithValue("@ORDEN", txtOrden.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
        }

        public void Garantia()
        {
            Conexion.Conectar();
            String FechaS = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "Garantia";
            cmd2.Connection = Conexion.Conectar();
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@fecha1", FechaS);
            cmd2.Parameters.AddWithValue("@idOrden", txtOrden.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
             cargardatagrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MorificarOrden();
            Garantia();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
