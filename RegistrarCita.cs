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
    public partial class frmRegistrarCita : Form
    {
        frmCitas frmCitas;
        LogicaCita logicaCita;
        public frmRegistrarCita(frmCitas frmCitas)
        {
            //creamos el formulario de registro de citas y le mandamos el formulario de citas para tener acceso a el desde el formulario de registro de citas y poder insertar los datos en el datagridview del formulario de citas
            this.frmCitas = frmCitas;
            InitializeComponent();
            List<TextBox> listaTextBoxCita = new List<TextBox>();
            listaTextBoxCita.Add(txtID);
            listaTextBoxCita.Add(txtPaciente);
            listaTextBoxCita.Add(txtMedico);
            listaTextBoxCita.Add(txtFecha);
            listaTextBoxCita.Add(txtHora);
            listaTextBoxCita.Add(txtMotivo);

            List<Label> listaLabelCita = new List<Label>();
            listaLabelCita.Add(lblidCita);
            listaLabelCita.Add(lblPaciente);
            listaLabelCita.Add(lblMedico);
            listaLabelCita.Add(lblFecha);
            listaLabelCita.Add(lblHora);
            listaLabelCita.Add(lblMotivo);

            logicaCita = new LogicaCita(listaTextBoxCita, listaLabelCita);
        }


        private void TextChangedID(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                lblidCita.ForeColor = Color.Red;
            }
            else
            {
                lblidCita.ForeColor = Color.Green;
            }
        }

        private void TextChangedPaciente(object sender, EventArgs e)
        {
            if (txtPaciente.Text.Equals(""))
            {
                lblPaciente.ForeColor = Color.Red;
            }
            else
            {
                lblPaciente.ForeColor = Color.Green;
            }
        }

        private void TextChangedMedico(object sender, EventArgs e)
        {
            if (txtMedico.Text.Equals(""))
            {
                lblMedico.ForeColor = Color.Red;
            }
            else
            {
                lblMedico.ForeColor = Color.Green;
            }
        }

        private void TextChangedFecha(object sender, EventArgs e)
        {
            if (txtFecha.Text.Equals(""))
            {
                lblFecha.ForeColor = Color.Red;
            }
            else
            {
                lblFecha.ForeColor = Color.Green;
            }
        }

        private void TextChangedHora(object sender, EventArgs e)
        {
            if (txtHora.Text.Equals(""))
            {
                lblHora.ForeColor = Color.Red;
            }
            else
            {
                lblHora.ForeColor = Color.Green;
            }
        }

        private void TextChangedMotivo(object sender, EventArgs e)
        {
            if (txtMotivo.Text.Equals(""))
            {
                lblMotivo.ForeColor = Color.Red;
            }
            else
            {
                lblMotivo.ForeColor = Color.Green;
            }
        }

        private void KeyPressID(object sender, KeyPressEventArgs e)
        {
            logicaCita.textBoxEvent.soloNumeros(e);
        }

        private void KeyPressPaciente(object sender, KeyPressEventArgs e)
        {
            logicaCita.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressMedico(object sender, KeyPressEventArgs e)
        {
            logicaCita.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressHora(object sender, KeyPressEventArgs e)
        {
            logicaCita.textBoxEvent.ValidarHora(e);
        }

        private void KeyPressMotivo(object sender, KeyPressEventArgs e)
        {
            logicaCita.textBoxEvent.SoloLetras(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TblDetalleCitas cita = new TblDetalleCitas()
            {
                IDCita = txtID.Text,
                NombrePaciente = txtPaciente.Text,
                NombreMedico = txtMedico.Text,
                Fecha = txtFecha.Text,
                Hora = txtHora.Text,
                Motivo = txtMotivo.Text
            };

            InsercionDatos insercionDatos = new InsercionDatos();
            insercionDatos.InsercionCitas(cita);
            frmCitas.InsercionDGV(cita);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
            frmCitas.Show();
            this.Close();
        }

        private void frmRegistrarCita_Load(object sender, EventArgs e)
        {

        }
    }
}
