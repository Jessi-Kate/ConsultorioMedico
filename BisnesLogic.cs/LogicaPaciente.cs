using BisnesLogic.cs.Biblioteca;
using DataConexion;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BisnesLogic
{
    public class LogicaPaciente : AccesoClases
    {
        private List<TextBox> listaTextBoxPaciente;
        private List<Label> listaLabelPaciente;
        PictureBox pictureBox;
        private List<ComboBox> listaComboBoxPaciente;
        private List<NumericUpDown> listaNumericPaciente;
        public DataGridView dgvPaciente;
        private ConexionBD conexion = new ConexionBD();
        private String action = "Insert";

        public LogicaPaciente(object[] objects)
        {
            this.dgvPaciente = (DataGridView)objects[0];
        }

        public LogicaPaciente(List<TextBox> listaTextBoxPaciente, List<Label> listaLabelPaciente, object[] objects, List<ComboBox> listaComboBoxPaciente, List<NumericUpDown> listaNumericPaciente)
        {
            this.listaTextBoxPaciente = listaTextBoxPaciente;
            this.listaLabelPaciente = listaLabelPaciente;
            this.pictureBox = (PictureBox)objects[0];
            this.listaComboBoxPaciente = listaComboBoxPaciente;
            this.listaNumericPaciente = listaNumericPaciente;
        }


        public void ValidarCamposPaciente()
        {

            if (listaTextBoxPaciente[0].Text == string.Empty)
            {
                listaLabelPaciente[0].Text = "El ID no puede estar vacio";
                listaLabelPaciente[0].ForeColor = Color.Red;
                listaTextBoxPaciente[0].Focus();
            }
            else
            {
                if (listaTextBoxPaciente[1].Text == string.Empty)
                {
                    listaLabelPaciente[1].Text = "El Nombre no puede estar vacio";
                    listaLabelPaciente[1].ForeColor = Color.Red;
                    listaTextBoxPaciente[1].Focus();
                }
                else
                {
                    if (listaTextBoxPaciente[2].Text == string.Empty)
                    {
                        listaLabelPaciente[2].Text = "El Apellido Paterno no puede estar vacio";
                        listaLabelPaciente[2].ForeColor = Color.Red;
                        listaTextBoxPaciente[2].Focus();
                    }
                    else
                    {
                        if (listaTextBoxPaciente[3].Text == string.Empty)
                        {
                            listaLabelPaciente[3].Text = "El Apellido Materno no puede estar vacio";
                            listaLabelPaciente[3].ForeColor = Color.Red;
                            listaTextBoxPaciente[3].Focus();
                        }
                        else
                        {
                            if (listaNumericPaciente[0].Value == 0)
                            {
                                listaLabelPaciente[4].Text = "La edad no puede estar vacia";
                                listaLabelPaciente[4].ForeColor = Color.Red;
                                listaNumericPaciente[0].Focus();
                            }
                            else
                            {
                                if (listaComboBoxPaciente[0].SelectedIndex == -1)
                                {
                                    listaLabelPaciente[5].Text = "El sexo no puede estar vacio";
                                    listaLabelPaciente[5].ForeColor = Color.Red;
                                    listaComboBoxPaciente[0].Focus();
                                }


                                else
                                {
                                    if (listaTextBoxPaciente[4].Text == string.Empty)
                                    {
                                        listaLabelPaciente[6].Text = "El Telefono no puede estar vacio";
                                        listaLabelPaciente[6].ForeColor = Color.Red;
                                        listaTextBoxPaciente[4].Focus();
                                    }
                                    else
                                    {
                                        if (listaTextBoxPaciente[5].Text == string.Empty)
                                        {
                                            listaLabelPaciente[7].Text = "La Direccion no puede estar vacio";
                                            listaLabelPaciente[7].ForeColor = Color.Red;
                                            listaTextBoxPaciente[5].Focus();
                                        }
                                        else
                                        {
                                            if (listaTextBoxPaciente[6].Text == string.Empty)
                                            {
                                                listaLabelPaciente[8].Text = "El Correo no puede estar vacio";
                                                listaLabelPaciente[8].ForeColor = Color.Red;
                                                listaTextBoxPaciente[6].Focus();
                                            }
                                            else
                                            {

                                                var ImgToByte = subirImagen.ImageAByte(pictureBox.Image);
                                                MessageBox.Show("Datos Validados!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                ConexionBD conexion = new ConexionBD();

                                                conexion.Insert(new TblDetallesPaciente
                                                {
                                                    IDPaciente = listaTextBoxPaciente[0].Text,
                                                    Nombre = listaTextBoxPaciente[1].Text,
                                                    ApellidoPaterno = listaTextBoxPaciente[2].Text,
                                                    ApellidoMaterno = listaTextBoxPaciente[3].Text,
                                                    Edad = int.Parse(listaNumericPaciente[0].Text),
                                                    Sexo = listaComboBoxPaciente[0].Text,
                                                    Telefono = listaTextBoxPaciente[4].Text,
                                                    Direccion = listaTextBoxPaciente[5].Text,
                                                    Correo = listaTextBoxPaciente[6].Text,
                                                    Imagen = ImgToByte
                                                });

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        public void ListarPaciente()
        {
            //instanciar la clase xonexion

            

            var listaPaciente = conexion.GetTable<TblDetallesPaciente>().Select(e => new
            {
                e.IDPaciente,
                e.Nombre,
                e.ApellidoPaterno,
                e.ApellidoMaterno,
                e.Edad,
                e.Sexo,
                e.Telefono,
                e.Direccion,
                e.Correo,
                Image = ArrayToImagen(e.Imagen)
            }).ToList();
            dgvPaciente.DataSource = listaPaciente;
        }

        public Image ArrayToImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null; // O una imagen por defecto

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        //Metodo para eliminar registro
        public void EliminarRegistro(string idPaciente)
        {
            try
            {
                //Buscamos el registro directamente en la BD usando el ID que viene del Grid
                var pacienteRegistrado = conexion.GetTable<TblDetallesPaciente>()
                                        .FirstOrDefault(e => e.IDPaciente == idPaciente);

                if (pacienteRegistrado != null)
                {
                    if (MessageBox.Show($"¿Desea eliminar al paciente con ID: {idPaciente}?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Eliminamos el objeto encontrado
                        conexion.Delete(pacienteRegistrado);

                        MessageBox.Show("Registro eliminado con éxito.");

                        //Actualizamos la tabla con el metodo listarPacientes para reflejar los cambios
                        ListarPaciente();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el registro en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

    }
}
