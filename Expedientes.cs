using BisnesLogic.cs;
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
    public partial class frmExpedientes : Form
    {
        LogicaExpediente logicaExpediente;
        public frmExpedientes()
        {
            InitializeComponent();
            List<TextBox> listaTextBoxExpediente = new List<TextBox>();
            listaTextBoxExpediente.Add(txtidExpediente);
            listaTextBoxExpediente.Add(txtPaciente);
            listaTextBoxExpediente.Add(txtMedico);
            listaTextBoxExpediente.Add(txtFecha);

            List<Label> listaLabelExpediente = new List<Label>();
            listaLabelExpediente.Add(lblID);
            listaLabelExpediente.Add(lblPaciente);
            listaLabelExpediente.Add(lblMedico);
            listaLabelExpediente.Add(lblFecha);

            object[] objects = { picIne, picRadioGrafia, picEstudiosMedicos };
            logicaExpediente = new LogicaExpediente(listaTextBoxExpediente, listaLabelExpediente, objects);


        }

        private void frmExpedientes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logicaExpediente.subirImagen.CargarFotografia(picIne);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            logicaExpediente.subirImagen.CargarFotografia(picRadioGrafia);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            logicaExpediente.subirImagen.CargarFotografia(picEstudiosMedicos);
        }

        private void TextCangedID(object sender, EventArgs e)
        {
            if (txtidExpediente.Text.Equals(""))
            {
                lblID.ForeColor = Color.Red;
            }else
            {
                lblID.ForeColor = Color.Green;
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

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaExpediente.textBoxEvent.soloNumeros(e);
        }

        private void KeyPressPaciente(object sender, KeyPressEventArgs e)
        {
            logicaExpediente.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressMedico(object sender, KeyPressEventArgs e)
        {
            logicaExpediente.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressFecha(object sender, KeyPressEventArgs e)
        {
            logicaExpediente.textBoxEvent.soloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            logicaExpediente.ValidarCampoExpediente();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
            this.Close();
        }
    }
}
