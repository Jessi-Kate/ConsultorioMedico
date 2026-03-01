using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisnesLogic.cs.Biblioteca
{
    public class SubirImagen
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public void CargarFotografia(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            openFileDialog.Filter = "Imagen|*.jpg;*.GIF;*.bmp;*.png;*.gif";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != string.Empty)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }

        }

        public byte[] ImageAByte(Image image)
        {
            var conversor = new ImageConverter();
            return (byte[])conversor.ConvertTo(image, typeof(byte[]));
        }

    }
}
