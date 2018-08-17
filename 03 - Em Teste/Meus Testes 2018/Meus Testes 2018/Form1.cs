using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Meus_Testes_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = FileManipulation.ReadExcelFile();

            var listUF = new List<string>();
            foreach (var item in lista)
            {
                var exist = listUF.Where(x => x.ToString() == item.UF).FirstOrDefault();

                if (exist  == null)
                {
                    listUF.Add(item.UF);
                }



            }

            foreach (var item in listUF)
            {
                comboBox1.Items.Add(item);
            }
            //{
            //    string caminho, TipoArq;
            //    caminho = "";
            //    TipoArq = "";
            //    {
            //        var lista = new DirectoryInfo("D:\\TESTE").GetFiles("*.txt", SearchOption.AllDirectories);

            //        textBox1.Text = Convert.ToString(lista);

            //        MessageBox.Show("conclúido", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            dataGridView1.DataSource = lista;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var text = comboBox1.SelectedText;


        }
    }
}
