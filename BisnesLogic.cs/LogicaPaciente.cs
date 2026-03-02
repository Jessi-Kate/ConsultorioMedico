using BisnesLogic.cs.Biblioteca;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BisnesLogic
{
    public class LogicaPaciente : AccesoClases
    {
        private List<TextBox> listaTextBoxPaciente;
        private List<Label> listaLabelPaciente;
        PictureBox pictureBox;

        public LogicaPaciente(List<TextBox> listaTextBoxPaciente, List<Label> listaLabelPaciente, object[] objects)
        {
            this.listaTextBoxPaciente = listaTextBoxPaciente;
            this.listaLabelPaciente = listaLabelPaciente;
            this.pictureBox = (PictureBox)objects[0];
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
                                listaLabelPaciente[3].Text = "El Apellido Paterno no puede estar vacio";
                                listaLabelPaciente[3].ForeColor = Color.Red;
                                listaTextBoxPaciente[3].Focus();
                            }
                            else
                            {
                                if (listaTextBoxPaciente[4].Text == string.Empty)
                                {
                                    listaLabelPaciente[4].Text = "El Telefono no puede estar vacio";
                                    listaLabelPaciente[4].ForeColor = Color.Red;
                                    listaTextBoxPaciente[4].Focus();
                                }
                                else
                                {
                                    if (listaTextBoxPaciente[5].Text == string.Empty)
                                    {
                                        listaLabelPaciente[5].Text = "La Direccion no puede estar vacio";
                                        listaLabelPaciente[5].ForeColor = Color.Red;
                                        listaTextBoxPaciente[5].Focus();
                                    }
                                    else
                                    {
                                        if (listaTextBoxPaciente[6].Text == string.Empty)
                                        {
                                            listaLabelPaciente[6].Text = "El Correo no puede estar vacio";
                                            listaLabelPaciente[6].ForeColor = Color.Red;
                                            listaTextBoxPaciente[6].Focus();
                                        }
                                        else
                                        {
                                        
                                            var ImgToByte = subirImagen.ImageAByte(pictureBox.Image);
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
