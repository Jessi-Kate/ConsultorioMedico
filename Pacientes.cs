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
    
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();

        }

        private void TextChangedBuscar(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                lblBuscar.ForeColor = Color.Red;
            }else
            {
                lblBuscar.ForeColor = Color.Green;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente frmRPaciente = new frmRegistrarPaciente(this);
            frmRPaciente.Show();
            this.Hide();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu= new FrmMenu();
            frmMenu.Show();
            this.Close();
        }

        public void InsercionDGV(TblDetallesPaciente paciente)
        {
            dgvPacientes.Rows.Clear();
            dgvPacientes.Rows.Add(
                paciente.IDPaciente,
                paciente.Nombre,
                paciente.ApellidoPaterno,
                paciente.ApellidoMaterno,
                paciente.Edad,
                paciente.Sexo,
                paciente.Telefono,
                paciente.Direccion,
                paciente.Correo
                );
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
