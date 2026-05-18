using BisnesLogic;
using BisnesLogic.cs;
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
        LogicaCita logicaCita;
        public frmCitas()
        {
            InitializeComponent();
            object[] objects = { dgvCitas };
            logicaCita = new LogicaCita(objects);
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

            //limpiar el DataGridView 
            dgvCitas.DataSource = null;
            dgvCitas.Rows.Clear();
            dgvCitas.Refresh();
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
           /* dgvCitas.Rows.Clear();
            dgvCitas.Rows.Add(
                cita.IDCita, 
                cita.NombrePaciente, 
                cita.NombreMedico, 
                cita.Fecha, 
                cita.Hora, 
                cita.Motivo);
           */
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            logicaCita._id = dgvCitas.CurrentRow.Cells[0].Value.ToString();
            logicaCita.BuscarID(txtBuscar.Text); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logicaCita._id = dgvCitas.CurrentRow.Cells[0].Value.ToString();
            logicaCita.EliminarRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            logicaCita.ListarCitas();
        }

        private void dgvCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRegistrarCita frmEditar = new frmRegistrarCita(this);

                
                frmEditar.txtID.Text = dgvCitas.CurrentRow.Cells[0].Value.ToString();
                frmEditar.txtPaciente.Text = dgvCitas.CurrentRow.Cells[1].Value.ToString();
                frmEditar.txtMedico.Text = dgvCitas.CurrentRow.Cells[2].Value.ToString();
                frmEditar.txtFecha.Text = dgvCitas.CurrentRow.Cells[3].Value.ToString();
                frmEditar.txtHora.Text = dgvCitas.CurrentRow.Cells[4].Value.ToString();
                frmEditar.txtMotivo.Text = dgvCitas.CurrentRow.Cells[5].Value.ToString();

                frmEditar.logicaCita._id =dgvCitas.CurrentRow.Cells[0].Value.ToString();

                frmEditar.logicaCita._accion = "update";

                frmEditar.ShowDialog();
            }
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            /*Haremos una validacion para verificar que no este vacio
            if (dgvCitas.CurrentRow != null && dgvCitas.CurrentRow.Index >= 0)
            {
                //Haremos el llamado al metodo en LogicaEstudiante

                logicaCita.obtenerSeleccionCitas();
            }
            */
        }
    }
}
