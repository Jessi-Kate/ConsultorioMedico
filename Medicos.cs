using DataConexion;
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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void TextChangedBuscar(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                lblBuscar.ForeColor = Color.Red;
            } else
            {
                lblBuscar.ForeColor = Color.Green;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarMedico frmRegistrarMedico = new frmRegistrarMedico(this);
            frmRegistrarMedico.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
            this.Close();
        }

        public void InsercionDGGV(TblDetalleMedico medico)
        {
            dgvMedicos.Rows.Clear();
            dgvMedicos.Rows.Add(
                medico.IDMedico,
                medico.Nombre,
                medico.ApellidoPaterno,
                medico.ApellidoMaterno,
                medico.Edad,
                medico.Sexo,
                medico.Telefono,
                medico.Correo,
                medico.Especialidad,
                medico.Horario
                );
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {

        }
    }
}
