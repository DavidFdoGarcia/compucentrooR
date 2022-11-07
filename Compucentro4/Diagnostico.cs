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
    public partial class Diagnostico : Base
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            txtDiagnostico.AutoSize = false;
            txtDiagnostico.Size = new Size(200, 200);
            txtDiagnostico.Multiline = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea dar de alta la orden? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                clsOrden or = new clsOrden();
                or.InsertaDiagnostico(Convert.ToInt32(txtOrden.Text), txtDiagnostico.Text);
            }
        }
    }
}
