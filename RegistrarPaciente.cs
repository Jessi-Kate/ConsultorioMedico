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
    public partial class frmRegistrarPaciente : Form
    {
        private frmPacientes frmPacientes;
        LogicaPaciente logicaPaciente;
        public frmRegistrarPaciente(frmPacientes frmPacientes)
        {
            //Guarmados el formulario principal en la varibale global para tener acceso a el desde cualquier parte del formulario de registro de pacientes
            this.frmPacientes = frmPacientes;
            InitializeComponent();

            List<TextBox> listaTextBoxPaciente = new List<TextBox>();
            listaTextBoxPaciente.Add(txtID); //[0]
            listaTextBoxPaciente.Add(txtNombre);//[1]
            listaTextBoxPaciente.Add(txtPaterno);//[2]
            listaTextBoxPaciente.Add(txtMaterno);//[3]
            listaTextBoxPaciente.Add(txtTelefono);//[4]
            listaTextBoxPaciente.Add(txtDireccion);//[5]
            listaTextBoxPaciente.Add(txtCorreo);//[6]

            List<Label> listaLabelPaciente = new List<Label>();
            listaLabelPaciente.Add(lblID); //[0]
            listaLabelPaciente.Add(lblNombre);//[1]
            listaLabelPaciente.Add(lblPaterno);//[2]
            listaLabelPaciente.Add(lblMaterno);//[3]
            listaLabelPaciente.Add(lblEdad);//[4]
            listaLabelPaciente.Add(lblSexo);//[5]
            listaLabelPaciente.Add(lblTelefono);//[6]
            listaLabelPaciente.Add(lblDireccion);//[7]
            listaLabelPaciente.Add(lblCorreo);//[8]

            object[] objects = { picPaciente };

            List<ComboBox> listaComboBoxPaciente = new List<ComboBox>();
            listaComboBoxPaciente.Add(cboSexo);
            List<NumericUpDown> listaNumericPaciente = new List<NumericUpDown>();
            listaNumericPaciente.Add(nudEdad);
            logicaPaciente = new LogicaPaciente(listaTextBoxPaciente, listaLabelPaciente, objects,listaComboBoxPaciente,listaNumericPaciente);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logicaPaciente.subirImagen.CargarFotografia(picPaciente);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion de un objeto paciente para almacenar los datos del paciente que se van a insertar en la base de datos
            /*
             TblDetallesPaciente paciente = new TblDetallesPaciente()
            {
                //Establecemos los valores de las propiedades del objeto paciente con los datos ingresados en los campos de texto del formulario de registro de pacientes
                //IDPaciente = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                ApellidoPaterno = txtPaterno.Text,
                ApellidoMaterno = txtMaterno.Text,
                //Edad = int.Parse(nudEdad.Text),
                Sexo = cboSexo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text

            };
            //Tener acceso a la capa de la logica de negocio

            //Una vez que se han validado los campos del paciente, podemos proceder a insertar los datos en la base de datos utilizando la clase InsercionDatos de la capa de acceso a datos. Esta clase se encargará de ejecutar la consulta SQL para insertar el nuevo registro del paciente en la tabla correspondiente de la base de datos.
            InsercionDatos insercionDatos = new InsercionDatos();
            insercionDatos.InsercionContacto(paciente);
            frmPacientes.InsercionDGV(paciente);*/

                logicaPaciente.ValidarCamposPaciente();
        }

        private void KeyPressID(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.soloNumeros(e);
        }

        private void KeyPressNombre(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressApellidoPaterno(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.SoloLetras(e);
        }

        private void textChangedID(object sender, EventArgs e)
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

        private void frmRegistrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void TextChanged(object sender, EventArgs e)
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

        private void KeyPressMaterno(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressTelefono(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.soloNumeros(e);
        }

        private void KeyPressDireccion(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.SoloLetras(e);
        }

        private void KeyPressCorreo(object sender, KeyPressEventArgs e)
        {
            logicaPaciente.textBoxEvent.validarCorreoElectronico(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPacientes.Show();
            this.Close();
        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {
            if (nudEdad.Value <= 0)
            {
                lblEdad.ForeColor = Color.Red;
            }
            else
            {
                lblEdad.ForeColor = Color.Green;
            }
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == -1)
            {
                lblSexo.ForeColor = Color.Red;
            }
            else
            {
                lblSexo.ForeColor = Color.Green;
            }
        }
    }
}
