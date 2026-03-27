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
            logicaCita.ListarCitas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la celda correspondiente (ajusta el nombre de la columna)
                string idSeleccionado = dgvCitas.CurrentRow.Cells["IDCita"].Value.ToString();

                // Llamamos al método pasándole el ID
                logicaCita.EliminarRegistro(idSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de la tabla.");
            }
        }
    }
}
