using System;
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

        private void consultaOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarOrden MO = new ModificarOrden();
            MO.Show();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenes or = new ordenes();
            or.Show();
        }

        private void consulaDetallesOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDetallesOrden CDO = new ConsultaDetallesOrden();
            CDO.Show();
        }

        private void consultaOrdenPorFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenFiltros OF = new OrdenFiltros();
            OF.Show();
        }
    }
}
