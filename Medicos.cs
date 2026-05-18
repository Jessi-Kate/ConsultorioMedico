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
    public partial class frmMedicos : Form
    {
        LogicaMedico logicaMedico;
        public frmMedicos()
        {
            InitializeComponent();
            object[] objects = { dgvMedicos };
            logicaMedico = new LogicaMedico(objects);
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

            //limpiar el DataGridView 
            dgvMedicos.DataSource = null;
            dgvMedicos.Rows.Clear();
            dgvMedicos.Refresh();
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
           /* dgvMedicos.Rows.Clear();
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
           */
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            logicaMedico.BuscarString(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            logicaMedico._id = dgvMedicos.CurrentRow.Cells[0].Value.ToString();
            logicaMedico.EliminarRegistro();
        }

        private void dgvMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                //Instanciamos el formulario de registro de medicos y le pasamos los textbox para llenar los datos del medico seleccionado
                frmRegistrarMedico frmEditar = new frmRegistrarMedico(this);

                //Establecemos los valores de los textbox del formulario de registro de medicos con los valores de la fila seleccionada en el DataGridView
                frmEditar.txtID.Text = dgvMedicos.CurrentRow.Cells[0].Value.ToString();
                frmEditar.txtNombre.Text = dgvMedicos.CurrentRow.Cells[1].Value.ToString();
                frmEditar.txtPaterno.Text = dgvMedicos.CurrentRow.Cells[2].Value.ToString();
                frmEditar.txtMaterno.Text = dgvMedicos.CurrentRow.Cells[3].Value.ToString();
                frmEditar.nudEdad.Value = Convert.ToDecimal(dgvMedicos.CurrentRow.Cells[4].Value);
                frmEditar.cboSexo.Text = dgvMedicos.CurrentRow.Cells[5].Value.ToString();
                frmEditar.txtTelefono.Text = dgvMedicos.CurrentRow.Cells[6].Value.ToString();
                frmEditar.txtCorreo.Text = dgvMedicos.CurrentRow.Cells[7].Value.ToString();
                frmEditar.cboEspecialidad.Text = dgvMedicos.CurrentRow.Cells[8].Value.ToString();
                frmEditar.cboHorario.Text = dgvMedicos.CurrentRow.Cells[9].Value.ToString();

                //Establecer la imagen del medico seleccionado en el picture box del formulario de registro de medicos
                frmEditar.picMedico.Image = (Image)dgvMedicos.CurrentRow.Cells[10].Value;

                //Establecer el ID del medico seleccionado en la variable de la logicaMedico para que se pueda usar en el metodo de actualizacion de datos en la base de datos y establecer la accion a update para que se ejecute el metodo de actualizacion de datos en la base de datos
                frmEditar.logicaMedico._id = dgvMedicos.CurrentRow.Cells[0].Value.ToString();
                frmEditar.logicaMedico._accion = "update";
                frmEditar.ShowDialog();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            logicaMedico.ListarMedicos();
        }
    }
}
