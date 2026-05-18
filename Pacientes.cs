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
    
    public partial class frmPacientes : Form
    {
        LogicaPaciente logicaPaciente;
        public frmPacientes()
        {
            InitializeComponent();
            object[] objects = { dgvPacientes };
            logicaPaciente = new LogicaPaciente(objects);

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

            //limpiar el DataGridView 
            dgvPacientes.DataSource = null;
            dgvPacientes.Rows.Clear();
            dgvPacientes.Refresh();
        }

        public void InsercionDGV(TblDetallesPaciente paciente)
        {
           /* dgvPacientes.Rows.Clear();
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
           */
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {

        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            logicaPaciente.BuscarString(txtBuscar.Text);

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logicaPaciente._id = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            logicaPaciente.EliminarRegistro();
        }

        

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRegistrarPaciente frmEditar = new frmRegistrarPaciente(this);
                // Obtener los datos de la fila seleccionada
                frmEditar.txtID.Text = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                frmEditar.txtNombre.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
                frmEditar.txtPaterno.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
                frmEditar.txtMaterno.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
                frmEditar.nudEdad.Value = Convert.ToDecimal(dgvPacientes.CurrentRow.Cells[4].Value);
                frmEditar.cboSexo.SelectedItem = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
                frmEditar.txtTelefono.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString();
                frmEditar.txtDireccion.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString();
                frmEditar.txtCorreo.Text = dgvPacientes.CurrentRow.Cells[8].Value.ToString();

                frmEditar.picPaciente.Image = (Image)dgvPacientes.CurrentRow.Cells[9].Value;

                frmEditar.logicaPaciente._id = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                frmEditar.logicaPaciente._accion = "update";
                frmEditar.ShowDialog();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            logicaPaciente.ListarPaciente();
        }
    }
}
