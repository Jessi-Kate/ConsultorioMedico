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


        }

        private void frmRegistrarMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
