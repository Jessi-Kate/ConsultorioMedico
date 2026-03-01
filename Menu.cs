using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCitas frmCitas = new frmCitas();
            frmCitas.Show();
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            frmExpedientes frmExpedientes = new frmExpedientes();
            frmExpedientes.Show();
        }
    }
}
