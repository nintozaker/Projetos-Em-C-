using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace colarEXE_NovosparaosDriveres
{
    public class Copiar_e_Atualizar_os_Arquivos
    {
        public string  ResuldadoGeradoX65;

        public void CopiarEAtualizar_XX (string ItemEnviado01,string ItemEnviado02, string ItemEnviado03,string ItemCaminhoDaAtualizacao)
        {
            string ReceberCaminhoDaAtualizacao,ReceberOCaminhoASeratualizado, NomeParaComparacaoDasPastas, TipoDeArquivoSalvo;

            ReceberCaminhoDaAtualizacao = ItemCaminhoDaAtualizacao;
            ReceberOCaminhoASeratualizado = ItemEnviado01;
            NomeParaComparacaoDasPastas = ItemEnviado02;
            TipoDeArquivoSalvo = ItemEnviado03;


            var dir = ReceberOCaminhoASeratualizado;  // Para onde Vai o Arquivo 
            //  ↓↓  De onde se pega o Arquivo  ↓↓
            var dirgenerico = ItemCaminhoDaAtualizacao;
            Console.ForegroundColor = ConsoleColor.Yellow;
            var diretorios = new DirectoryInfo(dir).GetDirectories();
            foreach (var item in diretorios)
            {
                if (item.Name.Contains(NomeParaComparacaoDasPastas))
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Copiando arquivo para : " + " .......................  " + item.Name);

                    var name = item.FullName + "\\" + item.Name + TipoDeArquivoSalvo;
                    File.Delete(name);
                    File.Copy(dirgenerico, name);
                }
            }

        }








    }
}
