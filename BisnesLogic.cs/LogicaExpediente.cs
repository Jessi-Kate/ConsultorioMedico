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
    public class LogicaExpediente: AccesoClases
    {
        private List<TextBox> listaTextBoxExpediente;
        private List<Label> listaLabelExpediente;
        PictureBox picIne;
        PictureBox picRadioGrafia;
        PictureBox picEstudiosMedicos;

        public LogicaExpediente(List<TextBox> listaTextBoxExpediente, List<Label> listaLabelExpediente, object[] objects)
        {
            this.listaTextBoxExpediente = listaTextBoxExpediente;
            this.listaLabelExpediente = listaLabelExpediente;
            this.picIne = (PictureBox)objects[0];
            this.picRadioGrafia = (PictureBox)objects[1];
            this.picEstudiosMedicos = (PictureBox)objects[2];
        }

        public void ValidarCampoExpediente()
        {
            if (listaTextBoxExpediente[0].Text == string.Empty)
            {
                listaLabelExpediente[0].Text = "El ID no puede estar vacio";
                listaLabelExpediente[0].ForeColor = Color.Red;
                listaTextBoxExpediente[0].Focus();
            }
            else
            {
                if (listaTextBoxExpediente[1].Text == string.Empty)
                {
                    listaLabelExpediente[1].Text = "El Paciente no puede estar vacio";
                    listaLabelExpediente[1].ForeColor = Color.Red;
                    listaTextBoxExpediente[1].Focus();
                }
                else
                {
                    if (listaTextBoxExpediente[2].Text == string.Empty)
                    {
                        listaLabelExpediente[2].Text = "El Medico no puede estar vacio";
                        listaLabelExpediente[2].ForeColor = Color.Red;
                        listaTextBoxExpediente[2].Focus();
                    }
                    else
                    {
                        if (listaTextBoxExpediente[3].Text == string.Empty)
                        {
                            listaLabelExpediente[3].Text = "La Fecha no puede estar vacia";
                            listaLabelExpediente[3].ForeColor = Color.Red;
                            listaTextBoxExpediente[3].Focus();
                        }
                        else
                        {
                            MessageBox.Show("Datos Validados!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var ImgToByte = subirImagen.ImageAByte(picIne.Image);
                            var ImgToByte2 = subirImagen.ImageAByte(picRadioGrafia.Image);
                            var ImgToByte3 = subirImagen.ImageAByte(picEstudiosMedicos.Image);
                        }
                    }
                }
            }
        }
    }
}
