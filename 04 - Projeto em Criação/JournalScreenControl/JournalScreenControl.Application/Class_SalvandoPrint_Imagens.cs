using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalScreenControl.Application
{
   public class Class_SalvandoPrint_Imagens
    {

        //*********  Ronaldo

        Graphics g;
        //define a largura e altura para serem iguais a da tela
        int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
        int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        //*********

        public void ExSalvandoImagens ()
        {

            //  observar esta parte ( possivel salvamentod e arq.)  *****   cod Ronaldo
            //***************************
            //armazena a imagem no bitmap
            Bitmap b = new Bitmap(TelaLargura, TelaAltura);
            //copia  a tela no bitmap
            g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            //atribui a imagem ao picturebox exibindo-a
            picTela.Image = b;
            this.Show();
            //habilita o botão para salvar a tela
            //btnSalvarTela.Enabled = true;
            //encerra o timer
            //tmTela.Stop();

            //*******    *****
            //abre a janela de dialogo SaveDialog para salvar o arquivo gerado na captura
            DialogResult res = svdTela.ShowDialog();
            if (res == DialogResult.OK)
            {
                //obtem a extensão do arquivo salvo
                string ext = System.IO.Path.GetExtension(svdTela.FileName);
                if (ext == ".jpg")
                    picTela.Image.Save(svdTela.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            //************* R


        }
    }
}
