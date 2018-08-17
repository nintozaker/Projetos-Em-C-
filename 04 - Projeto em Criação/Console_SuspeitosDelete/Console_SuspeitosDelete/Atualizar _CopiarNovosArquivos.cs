using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_SuspeitosDelete
{
    public class Atualizar__CopiarNovosArquivos
    {
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  Configuração xxxxxxxxxxxxxxxxxxxxxxxxxxx
        string CaminhoDiretorio, TipoDeArquivo, OCaminhoOndeSeraAtualizado,Separar_Palavras_Linhas;
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public void AtualizarCopiar(string RecebendoDados01, string RecebendoDados02, string RecebendoDados03,string ReceberSeparadorDeLinhas)
        {
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            CaminhoDiretorio = RecebendoDados01;
            TipoDeArquivo = RecebendoDados02;
            OCaminhoOndeSeraAtualizado = RecebendoDados03;
            Separar_Palavras_Linhas = ReceberSeparadorDeLinhas;
          //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


            //   xxxxxxxxxxxxx      Início    xxxxxxxxxxxxxxxxxxxxxxxxxxx ↓↓↓
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Inicializando Processo de Atualização... " + '\n' + '\n');
            Thread.Sleep(1500);

            Console.WriteLine("Atualizando o Programa...." + '\n');
            Directory.GetFiles(CaminhoDiretorio, TipoDeArquivo);

            string[] ArquivosList = Directory.GetFiles(CaminhoDiretorio, TipoDeArquivo, SearchOption.AllDirectories);  //  fazer uma varredura completa em todas as sub pastas 
            foreach (string ArquivosTratados in ArquivosList)

            {
                if (!string.IsNullOrEmpty(ArquivosTratados.Trim()))          // Verificação se é nulo
                {
                    var NovoDiretorio1 = new DirectoryInfo(ArquivosTratados.Trim());
                }
                var directory = new DirectoryInfo(ArquivosTratados.Trim());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Copiando Arquivo : " + Separar_Palavras_Linhas + directory.Name);
                Thread.Sleep(1000);
                File.Copy(ArquivosTratados, OCaminhoOndeSeraAtualizado + "\\" + directory.Name, true);
            }
        }
    }
}
