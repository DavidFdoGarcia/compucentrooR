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
    public partial class Reportes : Base
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataTecnico.Operador' Puede moverla o quitarla según sea necesario.
            this.operadorTableAdapter.Fill(this.dataTecnico.Operador);

        }
    }
}
