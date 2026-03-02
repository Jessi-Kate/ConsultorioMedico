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
            listaTexBoxMedico.Add(txtID);
            listaTexBoxMedico.Add(txtNombre);
            listaTexBoxMedico.Add(txtPaterno);
            listaTexBoxMedico.Add(txtMaterno);
            listaTexBoxMedico.Add(txtTelefono);
            listaTexBoxMedico.Add(txtCorreo);

            //Lista de label para mandar a la logicaMedico y tener acceso a todos los label desde la logicaMedico
            List<Label> listaLabelMedico = new List<Label>();
            listaLabelMedico.Add(lblID);
            listaLabelMedico.Add(lblNombre);
            listaLabelMedico.Add(lblPaterno);
            listaLabelMedico.Add(lblMaterno);
            listaLabelMedico.Add(lblTelefono);
            listaLabelMedico.Add(lblCorreo);

            //Objeto para mandar a la logicaMedico y tener acceso a el desde la logicaMedico
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
            // Ejecutar validación (aunque sea void)
            logicaMedico.ValidarDatosMedico();


            TblDetalleMedico medicos = new TblDetalleMedico() 
            { 
                IDMedico = Convert.ToInt32(txtID.Text), 
                Nombre = txtNombre.Text, 
                ApellidoPaterno = txtPaterno.Text, 
                ApellidoMaterno = txtMaterno.Text, 
                Edad = (int)nudEdad.Value, 
                Sexo = cboSexo.SelectedItem.ToString(), 
                Telefono = txtTelefono.Text, 
                Correo = txtCorreo.Text, 
                Especialidad = cboEspecialidad.SelectedItem.ToString(),
                Horario = cboHorario.SelectedItem.ToString() 
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
