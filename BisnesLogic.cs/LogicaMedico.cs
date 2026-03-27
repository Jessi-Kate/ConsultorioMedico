using BisnesLogic.cs.Biblioteca;
using DataConexion;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisnesLogic.cs
{
    public class LogicaMedico : AccesoClases
    {
        private List<TextBox> listaTexBoxMedico;
        private List<Label> listaLabelMedico;
        PictureBox pictureBox;
        private List<ComboBox> listaComboBoxMedico;
        private List<NumericUpDown> listaNumericMedico;
        DataGridView dgvMedico;
        private ConexionBD conexion = new ConexionBD();

        public LogicaMedico(object[] objects)
        {
           this.dgvMedico = (DataGridView)objects[0];
        }

        public LogicaMedico(List<TextBox> listaTexBoxMedico, List<Label> listaLabelMedico, object[] objects, List<ComboBox> listaComboBoxMedico, List<NumericUpDown> listaNumericMedico)
        {
            this.listaTexBoxMedico = listaTexBoxMedico;
            this.listaLabelMedico = listaLabelMedico;
            this.pictureBox = (PictureBox)objects[0];
            this.listaComboBoxMedico = listaComboBoxMedico;
            this.listaNumericMedico = listaNumericMedico;
        }

        public void ValidarDatosMedico()
        {
            if (listaTexBoxMedico[0].Text == string.Empty)
            {
                listaLabelMedico[0].Text = "El ID no puede estar vacio";
                listaLabelMedico[0].ForeColor = Color.Red;
                listaTexBoxMedico[0].Focus();
            }
            else
            {
                if (listaTexBoxMedico[1].Text == string.Empty)
                {
                    listaLabelMedico[1].Text = "El Nombre no puede estar vacio";
                    listaLabelMedico[1].ForeColor = Color.Red;
                    listaTexBoxMedico[1].Focus();
                }
                else
                {
                    if (listaTexBoxMedico[2].Text == string.Empty)
                    {
                        listaLabelMedico[2].Text = "El Apellido Paterno no puede estar vacio";
                        listaLabelMedico[2].ForeColor = Color.Red;
                        listaTexBoxMedico[2].Focus();
                    }
                    else
                    {
                        if (listaTexBoxMedico[3].Text == string.Empty)
                        {
                            listaLabelMedico[3].Text = "El Apellido Materno no puede estar vacio";
                            listaLabelMedico[3].ForeColor = Color.Red;
                            listaTexBoxMedico[3].Focus();
                        }
                        else
                        {
                            if (listaNumericMedico[0].Value == 0)
                            {
                                listaLabelMedico[4].Text = "La edad no puede estar vacia";
                                listaLabelMedico[4].ForeColor = Color.Red;
                                listaNumericMedico[0].Focus();
                            }
                            else
                            {
                                if (listaComboBoxMedico[0].SelectedIndex == -1)
                                {
                                    listaLabelMedico[5].Text = "El sexo no puede estar vacio";
                                    listaLabelMedico[5].ForeColor = Color.Red;
                                    listaComboBoxMedico[0].Focus();
                                }
                                else
                                {
                                    if (listaTexBoxMedico[4].Text == string.Empty)
                                    {
                                        listaLabelMedico[6].Text = "El Telefono no puede estar vacio";
                                        listaLabelMedico[6].ForeColor = Color.Red;
                                        listaTexBoxMedico[4].Focus();
                                    }
                                    else
                                    {
                                        if (listaTexBoxMedico[5].Text == string.Empty)
                                        {
                                            listaLabelMedico[7].Text = "El Correo no puede estar vacio";
                                            listaLabelMedico[7].ForeColor = Color.Red;
                                            listaTexBoxMedico[5].Focus();
                                        }
                                        else
                                        {
                                            if (listaComboBoxMedico[1].SelectedIndex == -1)
                                            {
                                                listaLabelMedico[8].Text = "La especialidad no puede estar vacia";
                                                listaLabelMedico[8].ForeColor = Color.Red;
                                                listaComboBoxMedico[1].Focus();
                                            }
                                            else
                                            {
                                                // 10. Validar Horario (ComboBox 2)
                                                if (listaComboBoxMedico[2].SelectedIndex == -1)
                                                {
                                                    listaLabelMedico[9].Text = "El Horario no puede estar vacio";
                                                    listaLabelMedico[9].ForeColor = Color.Red;
                                                    listaComboBoxMedico[2].Focus();
                                                }

                                                else
                                                {
                                                    var ImgToByte = subirImagen.ImageAByte(pictureBox.Image);

                                                    ConexionBD conexion = new ConexionBD();

                                                    conexion.Insert(new TblDetalleMedico
                                                    {
                                                        IDMedico = listaTexBoxMedico[0].Text,
                                                        Nombre = listaTexBoxMedico[1].Text,
                                                        ApellidoPaterno = listaTexBoxMedico[2].Text,
                                                        ApellidoMaterno = listaTexBoxMedico[3].Text,
                                                        Edad = int.Parse(listaNumericMedico[0].Text),
                                                        Sexo = listaComboBoxMedico[0].Text,
                                                        Telefono = listaTexBoxMedico[4].Text,
                                                        Correo = listaTexBoxMedico[5].Text,
                                                        Especialidad = listaComboBoxMedico[1].Text,
                                                        Horario = listaComboBoxMedico[2].Text,
                                                        Imagen = ImgToByte
                                                    });

                                                    MessageBox.Show("Datos Validados!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    

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
        }

        public void ListarMedicos()
        {
           

            var listaMedicos = conexion.GetTable<TblDetalleMedico>().Select(e => new
            {
                e.IDMedico,
                e.Nombre,
                e.ApellidoPaterno,
                e.ApellidoMaterno,
                e.Edad,
                e.Sexo,
                e.Telefono,
                e.Correo,
                e.Especialidad,
                e.Horario,
                Image = ArrayToImagen(e.Imagen)
            }).ToList();
            dgvMedico.DataSource = listaMedicos;
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
        public void EliminarRegistro(string idMedico)
        {
            try
            {
                //Buscamos el registro directamente en la BD usando el ID que viene del Grid
                var MedicoRegistrado = conexion.GetTable<TblDetalleMedico>()
                                        .FirstOrDefault(e => e.IDMedico == idMedico);

                if (MedicoRegistrado != null)
                {
                    if (MessageBox.Show($"¿Desea eliminar el Medico con ID: {idMedico}?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Eliminamos el objeto encontrado
                        conexion.Delete(MedicoRegistrado);

                        MessageBox.Show("Registro eliminado con éxito.");

                        //Actualizamos la tabla con el metodo listarMedicos para reflejar los cambios
                        ListarMedicos();
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

