using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atualizado_de_Executaveis_de_Driveres
{
    public class AbrirDiretorio_OpenDialog
    {
        public void AbrirDiretorio(string voi)
        {
           // return retornar;      // Ativar apenas  quando se quer retornar um  "valor"
            string ReceberODiretorioDePesquisaSelecionado;
            ReceberODiretorioDePesquisaSelecionado = "";
            
            // Instancia a classe.
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    string directorio = dirDialog.SelectedPath;
                    ReceberODiretorioDePesquisaSelecionado = Convert.ToString(dirDialog.SelectedPath);
                    //retornar = ReceberODiretorioDePesquisaSelecionado;
                    voi = ReceberODiretorioDePesquisaSelecionado;
                }
                else
                {
                    // Caso o utilizador tenha cancelado
                    // ...
                }
            }

        }



    }
}
