using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_SuspeitosDelete
{
    class Limpar_Logs_supeitos
    {

        string O_Caminho_XX, selecionarTipodeArquivo_XX,SeparadorRecebendo;

        public void ApagarLogsDeSuspeitos(string RecebendoItem_01, string RecebendoItem_02,string Receber_SeparadorDeLinhas)
        {
            //xxxxxxxxxxxxxxxxxxxxxxx
            O_Caminho_XX = RecebendoItem_01;
            selecionarTipodeArquivo_XX = RecebendoItem_02;
            SeparadorRecebendo = Receber_SeparadorDeLinhas;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine('\n' + "         ***  Analizando Arquivos Arquivos Suspeitos ou Erros  *** " + '\n' + '\n' + " _ No Diretório: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                  >>>  " + RecebendoItem_01 + '\n');
                Directory.GetFiles(O_Caminho_XX, selecionarTipodeArquivo_XX);
                string[] ArquivosList = Directory.GetFiles(O_Caminho_XX, selecionarTipodeArquivo_XX, SearchOption.AllDirectories);  //  fazer uma varredura completa em todas as sub pastas 
                Console.ForegroundColor = ConsoleColor.White;
                // Descrever a quatidade de  arquivos encontrados no diretorio ↓↓
                Console.WriteLine(SeparadorRecebendo + "Arquivos encontrados : >>>     {0}." + '\n', ArquivosList.Length );
                foreach (string ArquivosTratados in ArquivosList)
                {
                    if (!string.IsNullOrEmpty(ArquivosTratados.Trim()))          // Verificação se é nulo
                    {
                        var NovoDiretorio1 = new DirectoryInfo(ArquivosTratados.Trim());
                    }
                    var directory = new DirectoryInfo(ArquivosTratados.Trim());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Excluíndo (" +selecionarTipodeArquivo_XX + ") encontrado:"  + SeparadorRecebendo + directory.Name);
                    Thread.Sleep(100);
                    File.Delete(ArquivosTratados);
                }

            }

            catch (Exception EX)
            {
                Console.WriteLine("Temos algum problema na execução:" + '\n' + '\n' + EX);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  >>>       Etapa de exclução concluída " + '\n' + '\n');
            Thread.Sleep(1500);
        }

    }
}
