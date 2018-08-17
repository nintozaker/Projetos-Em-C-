using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atualizado_de_Executaveis_de_Driveres
{
    public class AtualizarEx_ApenasOsTRTS
    {
        public void AtualizandoTRTs(string RecDadosTextBox1 ,string RecDadosTextBox2)
        {
            string Caminho_atulaizar, caminhoDoarquivoNovo;

            // ******    ↓↓↓  String Recebendo dados das Textbox  reprecentadas no ("")  acima ↓↓. *******
            caminhoDoarquivoNovo = RecDadosTextBox1;
            Caminho_atulaizar = RecDadosTextBox2;

            // ************ ↓↓ Opcional  caso o comando acima seja desativado ↓↓ *************
            //Caminho_atulaizar = @"D:\Robos";
            //caminhoDoarquivoNovo = @"Y:\Grp_Base_de_Dados\Ronaldo\PORTAL entre as Maquinas\Ronaldo Junior\Atualizador De Drivers\DownloadGeneric.exe";
            try
            {
                var dir = Caminho_atulaizar;  // Para onde Vai o Arquivo 
                var dirgenerico = caminhoDoarquivoNovo; //  De onde se pega o Arquivo 
                var diretorios = new DirectoryInfo(dir).GetDirectories();
                foreach (var item in diretorios)
                {
                    if (item.Name.Contains("DownloadTRT"))
                    {
                        Thread.Sleep(1000);

                        var name = item.FullName + "\\" + item.Name + ".exe";
                          File.Delete(name);
                          File.Copy(dirgenerico, name);
                    }
                }
            }
            catch (Exception Ex_Erros)
            {
                //  ***** ↓↓  Crinado O corpo da Menssagem abaixo ↓ *****
                string tituloMessg02, DescricaoMesg02;
                tituloMessg02 = "** Erros encontrados **";
                DescricaoMesg02 = "Oi!encontramos os Seguintes Erros na sua Aplicação:";

                MessageBox.Show(DescricaoMesg02 + '\n' + '\n' + Ex_Erros, tituloMessg02, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
