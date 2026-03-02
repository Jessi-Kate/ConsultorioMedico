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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.Show();
            this.Hide();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCitas frmCitas = new frmCitas();
            frmCitas.Show();
            this.Hide();
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            frmExpedientes frmExpedientes = new frmExpedientes();
            frmExpedientes.Show();
            this.Hide();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos frmMedicos= new frmMedicos();
            frmMedicos.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
