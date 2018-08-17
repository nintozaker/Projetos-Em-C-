using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_SuspeitosDelete
{
    public class Program
    {
        static void Main(string[] args)
        {
            //******************************
            Console.Title = "  Analizador De Suspeitos";

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   Configuração    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            string Separadolinhas, EnviandoCaminho_SerEncontrado_Atualizado, CaminhoQueFoiEncontrado;
            string CaminhoD, TipoDeARquivo_Suspeitos;

            // informando o caminho de indereço de atualização ↓↓↓
            EnviandoCaminho_SerEncontrado_Atualizado = @":\Work\Diarios";
            CaminhoQueFoiEncontrado = "";  // @"D:\Meus App\OpenDrivers\bin\Debug";
            Separadolinhas = "  >>>>>>>>>>  ";
            TipoDeARquivo_Suspeitos = "*.log";
            CaminhoD = @"Y:\Grp_Base_de_Dados\Ronaldo\Programas Do Visual Studio\OpenDrivers\bin\Debug";
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   Caminho Descobrindo  se existe na  Maquina 
            Descobrindo_CaminhodeDiretorio QualCaminhoAtualizar = new Descobrindo_CaminhodeDiretorio();
            QualCaminhoAtualizar.DiretorioDeOndeAtualizar(EnviandoCaminho_SerEncontrado_Atualizado); //Aqui estamos enviando o Caminho 
            CaminhoQueFoiEncontrado = QualCaminhoAtualizar.Este_Foi_Caminho_Encontrado;
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            Limpar_Logs_supeitos EX_apagarArquivos = new Limpar_Logs_supeitos();
            EX_apagarArquivos.ApagarLogsDeSuspeitos(CaminhoQueFoiEncontrado, TipoDeARquivo_Suspeitos,Separadolinhas); //Enviando Descriçoes
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

            //*********************
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Processo foi Executado!" + '\n');


            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" >>> Fianlizado  <<<  ");
            Thread.Sleep(3000);




        }
    }
}
