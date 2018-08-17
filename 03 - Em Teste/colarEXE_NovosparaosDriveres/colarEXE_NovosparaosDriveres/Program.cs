using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace colarEXE_NovosparaosDriveres
{
    class Program
    {
        static void Main(string[] args)
        {
            //*******************************
            //  ***    configuração  *****
            string CaminhoDaAtualizacao, CaminhoQueSeraatualizado, NomeParaComparacaoDasPastas, TipoDeArquivoSalvo, teste;
            CaminhoDaAtualizacao = @"Y:\Grp_Base_de_Dados\Ronaldo\PORTAL entre as Maquinas\Ronaldo Junior\Atualizador De Drivers\DownloadGeneric.exe";
            CaminhoQueSeraatualizado = @"\Robos"; //......obs colocar o atalho sem a letra do diretório e os dois pontos(:)
            NomeParaComparacaoDasPastas = "DownloadTRT";
            TipoDeArquivoSalvo = ".exe";
            //******************************
            //***
            // Buscar_Diretorio_Das_Listas  //
            LocalizarCaminhoExistentenaMaquina LocalizarCaminho_XX = new LocalizarCaminhoExistentenaMaquina();
            LocalizarCaminho_XX.VarrerLocalizarCaminho(CaminhoQueSeraatualizado);
            //  ↓↓ Resposta do diretório Existente na Maquina ↓↓
            CaminhoQueSeraatualizado = LocalizarCaminho_XX.Receber_Caminho;
            // Buscar_Diretorio_Das_Listas  //
            //
            //******
            //
            //*********************************
            //
            string X_Nomedoprograma, X_setor, X_Saldacao;
            X_Nomedoprograma = "Atualizador de Executavéis de Robôs";
            X_Saldacao = "Vamos lá!..";
            X_setor = "Analistas De conteúdo" + '\n';
            //
            Console.WriteLine('\n' + "********************  ******************* " + '\n' + X_Saldacao + '\n' + '\n' + X_Nomedoprograma + '\n' + '\n' + X_setor);
            Thread.Sleep(2000);
            //
            Console.ForegroundColor = ConsoleColor.White; //cor
            Console.BackgroundColor = ConsoleColor.Blue; //Cor de Fundo Faixa no texto
            Console.WriteLine("      *****   Iniciando a  atualização dos Drivers   ****** " + '\n');
            Console.ResetColor();//Resetar Cor
            Thread.Sleep(1500);
            Console.WriteLine("Fazer Atualização do : ↓  ");
            Console.ForegroundColor = ConsoleColor.Red; //cor
            Console.WriteLine('\n' + CaminhoDaAtualizacao);
            Console.ResetColor();//Resetar Cor
            Thread.Sleep(1500);
            Console.WriteLine('\n' + "Para o:↓  ");
            Console.ForegroundColor = ConsoleColor.Red; //cor
            Console.WriteLine('\n' + CaminhoQueSeraatualizado);
            Console.ResetColor(); //Resetar Cor
            Thread.Sleep(1500);
            Console.WriteLine('\n' + "     Separando  as Pastas com iníciais : " + NomeParaComparacaoDasPastas + '\n');
            Thread.Sleep(2000);
            Console.Write('\n' + " >>> Processando ");
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("..");
            Thread.Sleep(1000);
            Console.Write("...");
            Thread.Sleep(1000);
            Console.Write(".....");
            Thread.Sleep(1000);
            Console.Write("...................");
            Thread.Sleep(1000);
            Console.Write("............................");
            Console.WriteLine('\n');
            //
            //*****************************************
            // ..............   Copiar_e_Atualizar_os_Arquivos  ......................
            Copiar_e_Atualizar_os_Arquivos Copiando_Atualizando = new Copiar_e_Atualizar_os_Arquivos();
            Copiando_Atualizando.CopiarEAtualizar_XX(CaminhoQueSeraatualizado, NomeParaComparacaoDasPastas, TipoDeArquivoSalvo, CaminhoDaAtualizacao);


            //
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            Console.WriteLine('\n' + "* Tudo Pronto seu(s) proceso(s)  Foi Finalizado Com sucesso! " + '\n');
            Thread.Sleep(3000);
            Console.WriteLine(" O execultavel Vai Fechar automaticamente. " + '\n' + '\n' + "Obrigado, tenha um ótimo Dia   o/");
            Thread.Sleep(3000);

            //
            //   ..............   contador
            //Class1 a = new Class1();
          //  a.TT();




            Console.WriteLine("Fim.....");
        }
        



    }
}
