using BisnesLogic.cs.Biblioteca;
using DataConexion;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisnesLogic.cs
{
    public class LogicaCita : AccesoClases
    {
        private List<TextBox> listaTextBoxCita;
        private List<Label> listaLabelCita;

        public LogicaCita(List<TextBox> listaTextBoxCita, List<Label> listaLabelCita)
        {
            this.listaTextBoxCita = listaTextBoxCita;
            this.listaLabelCita = listaLabelCita;
        }

        public void ValidarDatosCita()
        {
            if (listaTextBoxCita[0].Text == string.Empty)
            {
                MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaLabelCita[0].Text = "El ID no puede estar vacio";
                listaLabelCita[0].ForeColor = Color.Red;
                listaTextBoxCita[0].Focus();
            }
            else
            {
                if (listaTextBoxCita[1].Text == string.Empty)
                {
                    MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listaLabelCita[1].Text = "El Paciente no puede estar vacio";
                    listaLabelCita[1].ForeColor = Color.Red;
                    listaTextBoxCita[1].Focus();
                }
                else
                {
                    if (listaTextBoxCita[2].Text == string.Empty)
                    {
                        MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        listaLabelCita[2].Text = "El Medico no puede estar vacio";
                        listaLabelCita[2].ForeColor = Color.Red;
                        listaTextBoxCita[2].Focus();
                    }
                    else
                    {
                        if (listaTextBoxCita[3].Text == string.Empty)
                        {
                            MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            listaLabelCita[3].Text = "La Fecha no puede estar vacia";
                            listaLabelCita[3].ForeColor = Color.Red;
                            listaTextBoxCita[3].Focus();
                        }
                        else
                        {
                            if (listaTextBoxCita[4].Text == string.Empty)
                            {
                                MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                listaLabelCita[4].Text = "La Hora no puede estar vacia";
                                listaLabelCita[4].ForeColor = Color.Red;
                                listaTextBoxCita[4].Focus();
                            }
                            else
                            {
                                if (listaTextBoxCita[5].Text == string.Empty)
                                {
                                    MessageBox.Show("Caja de texto vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    listaLabelCita[5].Text = "El Motivo no puede estar vacio";
                                    listaLabelCita[5].ForeColor = Color.Red;
                                    listaTextBoxCita[5].Focus();
                                }else
                                {

                                    ConexionBD conexion = new ConexionBD();

                                    conexion.Insert(new TblDetalleCitas
                                    {
                                        IDCita = int.Parse(listaTextBoxCita[0].Text),
                                        NombrePaciente = listaTextBoxCita[1].Text,
                                        NombreMedico = listaTextBoxCita[2].Text,
                                        Fecha = listaTextBoxCita[3].Text,
                                        Hora = listaTextBoxCita[4].Text,
                                        Motivo = listaTextBoxCita[5].Text
                                    });
                                    MessageBox.Show("Cita registrada con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
