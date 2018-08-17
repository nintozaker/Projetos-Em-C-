using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_SuspeitosDelete
{
    public class Descobrindo_CaminhodeDiretorio
    {
        public string Este_Foi_Caminho_Encontrado, D1, D2, D3, D4, D5, CaminhoParaUso01;

        public void DiretorioDeOndeAtualizar(string Recebendo_Caminho)
        {
            // Buscar_Diretorio_Das_Listas  //
            CaminhoParaUso01 = Recebendo_Caminho;

            Este_Foi_Caminho_Encontrado = "Escolha um caminho de busca Aqui...!!!";
            D1 = @"Y" + CaminhoParaUso01;
            D2 = @"C" + CaminhoParaUso01;
            D3 = @"F" + CaminhoParaUso01;
            D4 = @"E" + CaminhoParaUso01;
            D5 = @"D" + CaminhoParaUso01;

            try
            {
                if (Directory.Exists(D1))
                {
                    Este_Foi_Caminho_Encontrado = D1;
                }
                if (Directory.Exists(D2))
                {
                    Este_Foi_Caminho_Encontrado = D2;
                }
                if (Directory.Exists(D3))
                {
                    Este_Foi_Caminho_Encontrado = D3;
                }
                if (Directory.Exists(D4))
                {
                    Este_Foi_Caminho_Encontrado = D4;
                }
                if (Directory.Exists(D5))
                {
                    Este_Foi_Caminho_Encontrado = D5;
                }

            }
            catch (Exception)
            {
                throw;
            }



        }
        // fim......

    }
}
