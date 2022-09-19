﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compucentro4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void altaDeRangosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaRango AR = new AltaRango();
            AR.Show();
        }

        private void altaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario AS = new AltaUsuario();
            AS.Show();
        }

        private void altaDeEquiiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEquipo AE = new AltaEquipo();
            AE.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaOrden AO = new AltaOrden();
            AO.Show();
        }

        private void altaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado AE = new Empleado();
            AE.Show();
        }

        private void altaDeTécnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tecnico AT = new Tecnico();
            AT.Show();
        }

        private void altaDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.Show();
        }

        private void altaDeRefaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refacciones refa = new Refacciones();
            refa.Show();
        }
    }
}
