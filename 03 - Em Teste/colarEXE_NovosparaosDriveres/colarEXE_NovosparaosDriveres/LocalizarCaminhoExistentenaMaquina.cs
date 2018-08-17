using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colarEXE_NovosparaosDriveres
{
  public  class LocalizarCaminhoExistentenaMaquina
    {
        public string Receber_Caminho;

        public void VarrerLocalizarCaminho(string CaminhoEnviado)
        {

            // Buscar_Diretorio_Das_Listas  //
            string Este_FOIoCaminho, D1, D2, D3, D4, D5, CaminhoParaUso01, CaminhoParaUso02;
            CaminhoParaUso01 = CaminhoEnviado;   
            CaminhoParaUso02 = "";
            Este_FOIoCaminho = "";
            D1 = @"D:" + CaminhoParaUso01;
            D2 = @"E:" + CaminhoParaUso01;
            try
            {
                if (Directory.Exists(D1))
                {
                    Este_FOIoCaminho = D1;
                }
                if (Directory.Exists(D2))
                {
                    Este_FOIoCaminho = D2;
                }
            }
            catch (Exception)
            {
                return;
            }
            //  ↓↓ Resposta do diretório Existente na Maquina ↓↓
            Receber_Caminho = Este_FOIoCaminho;
            //

        }

    }
}
