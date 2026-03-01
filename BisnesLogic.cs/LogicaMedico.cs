using BisnesLogic.cs.Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public LogicaMedico(List<TextBox> listaTexBoxMedico, List<Label> listaLabelMedico, object[] objects)
        {
            this.listaTexBoxMedico = listaTexBoxMedico;
            this.listaLabelMedico = listaLabelMedico;
            this.pictureBox = (PictureBox)objects[0];
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
                            if (listaTexBoxMedico[4].Text == string.Empty)
                            {
                                listaLabelMedico[4].Text = "El Telefono no puede estar vacio";
                                listaLabelMedico[4].ForeColor = Color.Red;
                                listaTexBoxMedico[4].Focus();
                            }
                            else
                            {
                                if (listaTexBoxMedico[5].Text == string.Empty)
                                {
                                    listaLabelMedico[5].Text = "El Correo no puede estar vacio";
                                    listaLabelMedico[5].ForeColor = Color.Red;
                                    listaTexBoxMedico[5].Focus();
                                }
                                else
                                {
                                    var ImgToByte = subirImagen.ImageAByte(pictureBox.Image);

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

