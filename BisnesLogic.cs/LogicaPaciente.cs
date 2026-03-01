using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BisnesLogic.cs
{
    public class LogicaPaciente
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
                listaLabelPaciente[0].Text = "El Campo Nombre no puede estar vacio";
            }
        }
    }
}
