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
    public partial class frmRegistrarMedico : Form
    {
        LogicaMedico logicaMedico;
        public frmRegistrarMedico()
        {
            InitializeComponent();
            List<TextBox> listaTexBoxMedico = new List<TextBox>();
            listaTexBoxMedico.Add(txtNombre);
            listaTexBoxMedico.Add(txtPaterno);
            listaTexBoxMedico.Add(txtMaterno);
            listaTexBoxMedico.Add(txtTelefono);
            listaTexBoxMedico.Add(txtCorreo);

            List<Label> listaLabelMedico = new List<Label>();
            listaLabelMedico.Add(lblNombre);
            listaLabelMedico.Add(lblPaterno);
            listaLabelMedico.Add(lblMaterno);
            listaLabelMedico.Add(lblTelefono);
            listaLabelMedico.Add(lblCorreo);

            object[] objects = { picMedico };
            logicaMedico = new LogicaMedico(listaTexBoxMedico, listaLabelMedico, objects);


        }

        private void frmRegistrarMedico_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logicaMedico.subirImagen.CargarFotografia(picMedico);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            logicaMedico.ValidarDatosMedico();
        }

        private void TextChangedID(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                lblID.ForeColor = Color.Red;
            }
            else
            {
                lblID.ForeColor = Color.Green;
            }
        }

        private void KeyPressID(object sender, KeyPressEventArgs e)
        {
            logicaMedico.textBoxEvent.soloNumeros(e);
        }

        private void TextChangedNombre(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Green;
            }
        }

        private void TextChangedApellidoPaterno(object sender, EventArgs e)
        {
            if (txtPaterno.Text.Equals(""))
            {
                lblPaterno.ForeColor = Color.Red;
            }
            else
            {
                lblPaterno.ForeColor = Color.Green;
            }
        }

        private void TextChangedMaterno(object sender, EventArgs e)
        {
            if (txtMaterno.Text.Equals(""))
            {
                lblMaterno.ForeColor = Color.Red;
            }
            else
            {
                lblMaterno.ForeColor = Color.Green;
            }
        }

        private void TextChangedTelefoono(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                lblTelefono.ForeColor = Color.Red;
            }
            else
            {
                lblTelefono.ForeColor = Color.Green;
            }
        }

        private void TextChangedCorreo(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                lblCorreo.ForeColor = Color.Red;
            }
            else
            {
                lblCorreo.ForeColor = Color.Green;
            }
        }

        private void KeyPressNombres(object sender, KeyPressEventArgs e)
        {
            logicaMedico.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressMaterno(object sender, KeyPressEventArgs e)
        {
            logicaMedico.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressTelefono(object sender, KeyPressEventArgs e)
        {
            logicaMedico.textBoxEvent.soloNumeros(e);
        }

        private void KeyPressCorreo(object sender, KeyPressEventArgs e)
        {
            logicaMedico.textBoxEvent.validarCorreoElectronico(e);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
