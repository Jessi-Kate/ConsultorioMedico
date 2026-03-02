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
    public partial class frmCitas : Form
    {
        public frmCitas()
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

        private void KeyPressBuscar(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, letras, espacios y teclas de control (como retroceso)
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarCita frmRegistrarCita = new frmRegistrarCita(this);
            frmRegistrarCita.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
            this.Close();
        }

        public void InsercionDGV(TblDetalleCitas cita)
        {
            dgvCitas.Rows.Clear();
            dgvCitas.Rows.Add(
                cita.IDCita, 
                cita.NombrePaciente, 
                cita.NombreMedico, 
                cita.Fecha, 
                cita.Hora, 
                cita.Motivo);
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
