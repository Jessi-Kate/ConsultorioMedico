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
    public partial class frmRegistrarPaciente : Form
    {
        LogicaPaciente logicaPaciente;
        public frmRegistrarPaciente()
        {
            InitializeComponent();
            List<TextBox> listaTextBoxPaciente = new List<TextBox>();
            listaTextBoxPaciente.Add(txtNombre);
            listaTextBoxPaciente.Add(txtPaterno);
            listaTextBoxPaciente.Add(txtMaterno);
            listaTextBoxPaciente.Add(txtTelefono);
            listaTextBoxPaciente.Add(txtDireccion);
            listaTextBoxPaciente.Add(txtCorreo);

            List<Label> listaLabelPaciente = new List<Label>();
            listaLabelPaciente.Add(lblNombre);
            listaLabelPaciente.Add(lblPaterno);
            listaLabelPaciente.Add(lblMaterno);
            listaLabelPaciente.Add(lblTelefono);
            listaLabelPaciente.Add(lblDireccion);
            listaLabelPaciente.Add(lblCorreo);

            object[] objects = { pictureBox1 };
            logicaPaciente = new LogicaPaciente(listaTextBoxPaciente,listaLabelPaciente, objects);
        }

        private void TextChangedNombres(object sender, EventArgs e)
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

        private void TextChangedApellidoMaterno(object sender, EventArgs e)
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

        private void TextChangedTelefono(object sender, EventArgs e)
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

        private void TextChangedDireccion(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                lblDireccion.ForeColor = Color.Red;
            }
            else
            {
                lblDireccion.ForeColor = Color.Green;
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
    }
}
