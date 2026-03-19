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
    public partial class frmRegistrarMedico : Form
    {
        frmMedicos frmMedicos;
        LogicaMedico logicaMedico;
        public frmRegistrarMedico(frmMedicos frmMedicos)
        {
            //Guarmados el formulario principal en la varibale global para tener acceso a el desde cualquier parte del formulario de registro de pacientes
            this.frmMedicos = frmMedicos;
            InitializeComponent();


            //Lista de textBox para mandar a la logicaMedico y tener acceso a todos los textBox desde la logicaMedico
            List<TextBox> listaTexBoxMedico = new List<TextBox>();
            listaTexBoxMedico.Add(txtID);//[0]
            listaTexBoxMedico.Add(txtNombre);//[1]
            listaTexBoxMedico.Add(txtPaterno);//[2]
            listaTexBoxMedico.Add(txtMaterno);//[3]
            listaTexBoxMedico.Add(txtTelefono);//[4]
            listaTexBoxMedico.Add(txtCorreo);//[5]

            //Lista de label para mandar a la logicaMedico y tener acceso a todos los label desde la logicaMedico
            List<Label> listaLabelMedico = new List<Label>();
            listaLabelMedico.Add(lblID);//[0]
            listaLabelMedico.Add(lblNombre);//[1]
            listaLabelMedico.Add(lblPaterno);//[2]
            listaLabelMedico.Add(lblMaterno);//[3]
            listaLabelMedico.Add(lblEdad);//[4]
            listaLabelMedico.Add(lblSexo);//[5]
            listaLabelMedico.Add(lblTelefono);//[6]
            listaLabelMedico.Add(lblCorreo);//[7]
            listaLabelMedico.Add(lblEspecialidad);//[8]
            listaLabelMedico.Add(lblHorario);//[9]
            

            //Objeto para mandar a la logicaMedico y tener acceso a el desde la logicaMedico
            object[] objects = { picMedico };

            List<ComboBox> listaComboBoxMedico = new List<ComboBox>();
            listaComboBoxMedico.Add(cboSexo); //[0]
            listaComboBoxMedico.Add(cboEspecialidad);//[1]
            listaComboBoxMedico.Add(cboHorario);//[2]

            List<NumericUpDown> listaNumericMedico = new List<NumericUpDown>();
            listaNumericMedico.Add(nudEdad);//[0]


            logicaMedico = new LogicaMedico(listaTexBoxMedico, listaLabelMedico, objects, listaComboBoxMedico, listaNumericMedico);


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
            // Ejecutar logica de validación 
            logicaMedico.ValidarDatosMedico();


            TblDetalleMedico medicos = new TblDetalleMedico() 
            { 
                //IDMedico = int.Parse(txtID.Text), 
                Nombre = txtNombre.Text, 
                ApellidoPaterno = txtPaterno.Text, 
                ApellidoMaterno = txtMaterno.Text, 
               // Edad = int.Parse(nudEdad.Text), 
                Sexo = cboSexo.Text, 
                Telefono = txtTelefono.Text, 
                Correo = txtCorreo.Text, 
                Especialidad = cboEspecialidad.Text,
                Horario = cboHorario.Text 
            };

            InsercionDatos insercionDatos = new InsercionDatos();
            insercionDatos.InsercionMedico(medicos);
            frmMedicos.InsercionDGGV(medicos);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            frmMedicos.Show();
            this.Close();
        }
    }
}
