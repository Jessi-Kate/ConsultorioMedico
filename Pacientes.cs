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

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            logicaPaciente.ListarPaciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la celda correspondiente (ajusta el nombre de la columna)
                string idSeleccionado = dgvPacientes.CurrentRow.Cells["IDPaciente"].Value.ToString();

                // Llamamos al método pasándole el ID
                logicaPaciente.EliminarRegistro(idSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla.");
            }
        }
    }
}
