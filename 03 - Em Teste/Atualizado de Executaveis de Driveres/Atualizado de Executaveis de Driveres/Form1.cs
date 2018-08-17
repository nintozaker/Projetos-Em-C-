using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atualizado_de_Executaveis_de_Driveres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public string DiretorioDeAtualização, LocalOndeSeAtualiza;

        private void BT_AtualizarTRT_Click(object sender, EventArgs e)
        {
            // **** ↓↓  vou usar este código apenas no intuíto de atualização provisória dos Drivers TRTs apenas. ↓↓ ****
            AtualizarEx_ApenasOsTRTS AT_TRTs = new AtualizarEx_ApenasOsTRTS();
            string ReceberDeTextbox1, ReceberDoTexbox2;
            ReceberDeTextbox1 = textBox1.Text;
            ReceberDoTexbox2 = textBox2.Text;
            // ****** ↓↓  Comando  chamar  classe e  tmb   temos o  para  conseguir enviar Texto para uma  classe  Determinada ↓↓  Ex. "(Dentro)".  ******
            AT_TRTs.AtualizandoTRTs(ReceberDeTextbox1,ReceberDoTexbox2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EnviarTexto;
            AbrirDiretorio_OpenDialog AbrirDgl = new AbrirDiretorio_OpenDialog();
          EnviarTexto = textBox1.Text ;
            // ****** ↓↓  Comando  chamar  classe e  tmb   temos o  para  conseguir enviar Texto para uma  classe  Determinada ↓↓  Ex. "(Dentro)".  ******
            AbrirDgl.AbrirDiretorio(EnviarTexto);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FazerProucuraDosNomesDasPastasDiretorios f = new FazerProucuraDosNomesDasPastasDiretorios();
            
            f.Teste2();
            
        }
    }
}
