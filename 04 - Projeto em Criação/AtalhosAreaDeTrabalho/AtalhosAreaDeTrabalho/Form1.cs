using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtalhosAreaDeTrabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ConfiguraçoesIniciais();
        }
        public void ConfiguraçoesIniciais()
        {//xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx| ↓↓ Configuraçoes de Inícialização do Programa  ↓↓ |xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            this.EscolherUmAnalista();
            this.SeRadioButton_vazioEntao_Oculto();
        }//xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx| ↑↑ Configuraçoes de Inícialização do Programa ↑↑ |xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx 

        Nomear_os_Cadernos_e_Outros_Dados ReNomeando_01 = new Nomear_os_Cadernos_e_Outros_Dados();

        public void EscolherUmAnalista()
        {//xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx| ↓↓ Verificando qual Anlista foi Selecionado ↓↓ |xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            if (rb_Nomedo_Analista_01.Checked)
            {
                ReNomeando_01.NomearCadernos_Ronaldo();
                this.Preencher_Dados_01();
                this.SeRadioButton_vazioEntao_Oculto();
            }
            if (rb_Nomedo_Analista_02.Checked)
            {
                ReNomeando_01.NomearCadernos_Roselaine();
                this.Preencher_Dados_01();
                this.SeRadioButton_vazioEntao_Oculto();
            }
            if (rb_Nomedo_Analista_03.Checked)
            {
                this.Preencher_Dados_01();
                this.SeRadioButton_vazioEntao_Oculto();
            }
        }//xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx| ↑↑ Verificando qual Anlista foi Selecionado ↑↑ |xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        public void Preencher_Dados_01 ()
        {
            //******************* ↓↓ visiabilisar Radiobuton ocultos ↓↓ ********
            radioButton1.Visible = true; radioButton2.Visible = true; radioButton3.Visible = true; radioButton4.Visible = true;
            radioButton5.Visible = true; radioButton6.Visible = true; radioButton7.Visible = true; radioButton8.Visible = true;
            radioButton9.Visible = true; radioButton10.Visible = true; radioButton11.Visible = true; radioButton12.Visible = true;
            radioButton1.Visible = true; radioButton14.Visible = true; radioButton15.Visible = true; radioButton16.Visible = true;
            radioButton17.Visible = true; radioButton18.Visible = true; radioButton19.Visible = true; radioButton18.Visible = true;
            //***************************   ↑ ↑      ***************************

            radioButton1.Text = ReNomeando_01.NomeDoCaderno_01; // ||------------------>>> 01
            radioButton2.Text = ReNomeando_01.NomeDoCaderno_02;
            radioButton3.Text = ReNomeando_01.NomeDoCaderno_03;
            radioButton4.Text = ReNomeando_01.NomeDoCaderno_04;
            radioButton5.Text = ReNomeando_01.NomeDoCaderno_05; // ||------------------>>> 05
            radioButton6.Text = ReNomeando_01.NomeDoCaderno_06;
            radioButton7.Text = ReNomeando_01.NomeDoCaderno_07;
            radioButton8.Text = ReNomeando_01.NomeDoCaderno_08;
            radioButton9.Text = ReNomeando_01.NomeDoCaderno_09;
            radioButton10.Text = ReNomeando_01.NomeDoCaderno_10; // ||------------------>>> 10
            radioButton11.Text = ReNomeando_01.NomeDoCaderno_11;
            radioButton12.Text = ReNomeando_01.NomeDoCaderno_12;
            radioButton13.Text = ReNomeando_01.NomeDoCaderno_13;
            radioButton14.Text = ReNomeando_01.NomeDoCaderno_14;
            radioButton15.Text = ReNomeando_01.NomeDoCaderno_15; // ||------------------>>> 15
            radioButton16.Text = ReNomeando_01.NomeDoCaderno_16;
            radioButton17.Text = ReNomeando_01.NomeDoCaderno_17;
            radioButton18.Text = ReNomeando_01.NomeDoCaderno_18;
            radioButton19.Text = ReNomeando_01.NomeDoCaderno_19;
            radioButton20.Text = ReNomeando_01.NomeDoCaderno_20; // ||------------------>>> 20

        }
        public void SeRadioButton_vazioEntao_Oculto()
        {// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↓ - Ocultar RadioButton que Encontra-se Vazio - ↓ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↓↓↓↓
            if (radioButton1.Text == "")
            {
                radioButton1.Visible = false;
            }//----------------------------------------------------------------------->>> 01
            if (radioButton2.Text == "")
            {
                radioButton2.Visible = false;
            }
            if (radioButton3.Text == "")
            {
                radioButton3.Visible = false;
            }
            if (radioButton4.Text == "")
            {
                radioButton4.Visible = false;
            }
            if (radioButton5.Text == "")
            {
                radioButton5.Visible = false;
            }//----------------------------------------------------------------------->>> 05
            if (radioButton6.Text == "")
            {
                radioButton6.Visible = false;
            }
            if (radioButton7.Text == "")
            {
                radioButton7.Visible = false;
            }
            if (radioButton8.Text == "")
            {
                radioButton8.Visible = false;
            }
            if (radioButton9.Text == "")
            {
                radioButton9.Visible = false;
            }
            if (radioButton10.Text == "")
            {
                radioButton10.Visible = false;
            }//----------------------------------------------------------------------->>> 10
            if (radioButton11.Text == "")
            {
                radioButton11.Visible = false;
            }
            if (radioButton12.Text == "")
            {
                radioButton12.Visible = false;
            }
            if (radioButton13.Text == "")
            {
                radioButton13.Visible = false;
            }
            if (radioButton14.Text == "")
            {
                radioButton14.Visible = false;
            }
            if (radioButton15.Text == "")
            {
                radioButton15.Visible = false;
            }//----------------------------------------------------------------------->>> 15
            if (radioButton16.Text == "")
            {
                radioButton16.Visible = false;
            }
            if (radioButton17.Text == "")
            {
                radioButton17.Visible = false;
            }
            if (radioButton18.Text == "")
            {
                radioButton18.Visible = false;
            }
            if (radioButton19.Text == "")
            {
                radioButton19.Visible = false;
            }
            if (radioButton20.Text == "")
            {
                radioButton20.Visible = false;
            }//----------------------------------------------------------------------->>> 20

        }// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx- Ocultar RadioButton que Encontra-se Vazio -xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↑↑↑↑

        private void rb_Nomedo_Analista_01_CheckedChanged(object sender, EventArgs e)
        {// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↓ ↓ Seleção de radiobuton analistas  ↓ ↓ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            this.EscolherUmAnalista();
        }// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↑ ↑ Seleção de radiobuton analistas  ↑ ↑ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        private void rb_Nomedo_Analista_02_CheckedChanged(object sender, EventArgs e)
        {// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↓ ↓ Seleção de radiobuton analistas  ↓ ↓ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            this.EscolherUmAnalista();
        }// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↑ ↑ Seleção de radiobuton analistas  ↑ ↑ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        private void rb_Nomedo_Analista_03_CheckedChanged(object sender, EventArgs e)
        {// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↓ ↓ Seleção de radiobuton analistas  ↓ ↓ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            this.EscolherUmAnalista();
        }// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx ↑ ↑ Seleção de radiobuton analistas  ↑ ↑ xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
