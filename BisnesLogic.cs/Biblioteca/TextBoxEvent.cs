using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisnesLogic.cs.Biblioteca
{
    public class TextBoxEvent
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != '\b' && //si es diferente de un backspace
                e.KeyChar != ' ')//si es diferente de un espacio vacío
            {
                e.Handled = true; //Si no es letra, no se podra escribir

            }

        }

        //crearemos un metodo publico, para validar el formato del correo electronico

        public void validarCorreoElectronico(KeyPressEventArgs key)
        {
            //Validacion del text box ID
            if (!char.IsLetterOrDigit(key.KeyChar) &&
                key.KeyChar != '\b' && //si es diferente de un backspace
                key.KeyChar != '@' && //si es diferente de un arroba
                key.KeyChar != '.' && //si es diferente de un punto
                key.KeyChar != '_' && //si es diferente de un guion bajo
                key.KeyChar != '-') //si es diferente de un guion
            {
                key.Handled = true; //Si no es letra, no se podra escribir
            }
        }

        //Crearemos un metodo publico, para recibir solo numeros
        public void soloNumeros(KeyPressEventArgs key)
        {
            //Validacion del text box ID
            if (!char.IsNumber(key.KeyChar) &&
                key.KeyChar != '\b') //si es diferente de un backspace
            {
                key.Handled = true; //Si no es numero, no se podra escribir
            }
        }

        public void ValidarHora(KeyPressEventArgs key)
        {
            //Validacion del text box ID
            if (!char.IsNumber(key.KeyChar) &&
                key.KeyChar != '\b' &&
                key.KeyChar != ':') //si es diferente de un backspace
            {
                key.Handled = true; //Si no es numero, no se podra escribir
            }
        }
    }
}
