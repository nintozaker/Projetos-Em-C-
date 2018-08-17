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
    public class FazerProucuraDosNomesDasPastasDiretorios
    {

        //******************************************    xx   ***************************************************************
        public string NamecaminhoTeste { get; set; }
    

        public void Teste2()
        {
             
        string Caminho_atulaizar, caminhoDoarquivoNovo;
            Caminho_atulaizar = @"D:\Apagar";
            caminhoDoarquivoNovo = @"D:\Apagar\Arquivo EXE.txt";
            try
            {
                var dir = Caminho_atulaizar;  // Para onde Vai o Arquivo 
                var dirgenerico = caminhoDoarquivoNovo; //  De onde se pega o Arquivo 
                //Console.ForegroundColor = ConsoleColor.Yellow;
                var diretorios = new DirectoryInfo(dir).GetDirectories();
                foreach (var item in diretorios)
                {
                    if (item.Name.Contains("Nova pasta"))
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Copiando arquivo para" + item.Name);

                        var name = item.FullName + "\\" + item.Name + ".exe";
                        //File.Delete(name);
                        //File.Copy(dirgenerico, name);
                         
                    
                    }
                }
            }
            catch (Exception Ex_Erros)
            {
                // Crinado O corpo da Menssagem abaixo ↓
                string tituloMessg02, DescricaoMesg02 ;
                tituloMessg02 = "** Erros encontrados **";
                DescricaoMesg02  = "Oi!encontramos os Seguintes Erros na sua Aplicação:";

                MessageBox.Show( DescricaoMesg02 + '\n' + '\n' + Ex_Erros,tituloMessg02,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }

    }
}
