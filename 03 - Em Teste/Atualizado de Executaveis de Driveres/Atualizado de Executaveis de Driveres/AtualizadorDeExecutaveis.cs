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
    public class AtualizadorDeExecutaveis
    {
        public void Atualizando_EX()
        {
            
            try
            {
                var dir = @"D:\Robos";  // Para onde Vai o Arquivo 
                var dirgenerico = @"Y:\Grp_Base_de_Dados\Ronaldo\PORTAL entre as Maquinas\Ronaldo Junior\Atualizador De Drivers\DownloadGeneric.exe"; //  De onde se pega o Arquivo 
                Console.ForegroundColor = ConsoleColor.Yellow;
                var diretorios = new DirectoryInfo(dir).GetDirectories();
                foreach (var item in diretorios)
                {
                    if (item.Name.Contains("Download"))
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Copiando arquivo para" + item.Name);

                        var name = item.FullName + "\\" + item.Name + ".exe";
                        File.Delete(name);
                        File.Copy(dirgenerico, name);
                    }
                }
                }
            catch (Exception Ex_Erros)
            {

                MessageBox.Show("Oi! encontramos os Seguintes Erros na sua   Aplicação:" + '\n'+'\n' + Ex_Erros);
            }
          

            }


    }
}
