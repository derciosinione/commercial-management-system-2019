using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace SGF_SQL
{
    class cssConvFoto
    {
        #region Metodos

        public static void TakeFoto(PictureBox picturebox)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "SGF | Selecionar Imagem";

            abrir.Filter = "Imagens (*.jpg)|*.jpg|imagem(*.png)|*.png|todos|*.*|imagem(*.ico)|*.ico";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = Image.FromFile(abrir.FileName);
            }
        }
        // converter Foto para byte

        public static byte[] CvFotoToByte(Image foto)
        {
            byte[] fotoC = null;
            MemoryStream memoria = new MemoryStream();
            try
            {
                foto.Save(memoria, ImageFormat.Png);
                fotoC = new byte[memoria.Length];
                memoria.Position = 0;
                memoria.Read(fotoC, 0, fotoC.Length);
                return fotoC;
            }
            catch (Exception)
            {
                fotoC = null;
            }
            return fotoC;
            
        }
        public static Image CvByteParaImage(byte[] fotoByte)
        {
            Image fotoConvertida = null;
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(fotoByte);
                fotoConvertida = Image.FromStream(ms);
                return fotoConvertida;
            }
            catch (Exception)
            {
                fotoConvertida = null;
                return fotoConvertida;
            }
        }
        
        //public static byte[] CvFotoToByte(Image foto)
        //{
        //    byte[] fotoC = null;
        //    MemoryStream memoria = new MemoryStream();
        //    foto.Save(memoria, ImageFormat.Png);
        //    fotoC = new byte[memoria.Length];
        //    memoria.Position = 0;
        //    memoria.Read(fotoC, 0, fotoC.Length);
        //    return fotoC;
        //}
        //// converter byte  para imagem
        //public static Image CvByteParaImage(byte[] fotoByte)
        //{
        //    Image fotoConvertida = null;
        //    System.IO.MemoryStream ms = new System.IO.MemoryStream(fotoByte);
        //    fotoConvertida = Image.FromStream(ms);
        //    return fotoConvertida;
        //}

        #endregion
    }
}
