using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data.OleDb;
using System.IO;

namespace Gerenciador_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TESTE();

        }


        public void TESTE()
        {
            string valor = string.Empty;
            TextReader fileReader = new StreamReader(@"Y:\Grp_Base_de_Dados\Ronaldo\Programas Do Visual Studio\Versoes Dos APP\Versão.txt");
            for (int i = 0; i < 3; i++)
                valor = fileReader.ReadLine();
            fileReader.Close();
            textBox5.Text = valor;

        }

        // ********************   Relogio *********************
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_RelogoTopo.Text = DateTime.Now.ToLongTimeString();
        }
        //


        private void button1_Click(object sender, EventArgs e)
        {
            string arquivo;
           // arquivo = @"D:TIME_SHEET_Teste.xlsx";
            arquivo = textBox_Proucurar_Plan.Text;

            string strConexao = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"", arquivo);
            OleDbConnection conn = new OleDbConnection(strConexao);
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            //Cria o objeto dataset para receber o conteúdo do arquivo Excel
            DataSet output = new DataSet();
            foreach (DataRow row in dt.Rows)
            {
                // obtem o noma da planilha corrente
                string sheet = row["TABLE_NAME"].ToString();
                // obtem todos as linhas da planilha corrente
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                cmd.CommandType = CommandType.Text;
                // copia os dados da planilha para o datatable
                DataTable outputTable = new DataTable(sheet);
                output.Tables.Add(outputTable);
                new OleDbDataAdapter(cmd).Fill(outputTable);
            }
            dgvGerenciador.DataSource = output.Tables[0];
            dgvGerenciador.AutoGenerateColumns = true;



        }


        private void button_Gravar_Click(object sender, EventArgs e)
        {

            this.configureDVG();

            var wb = new XLWorkbook(@"D:\PESCAR_PLANILHA_VS.xlsx");
            var planilha = wb.Worksheet(1);

            var linha = 1;


            var nome = planilha.Cell("A" + linha.ToString()).Value.ToString();
            textBox5.Text = nome;
            if (string.IsNullOrEmpty(nome)) { MessageBox.Show("hhh"); }

        }

        private void button_Procurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"C:\";
            fdlg.FileName = textBox_Proucurar_Plan.Text;
            fdlg.Filter = "Excel Sheet(*.xls)|*.xlsx|*.xlsm|*.xls|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox_Proucurar_Plan.Text = fdlg.FileName;
                //Import();

                Application.DoEvents();
            }


        }
        private void configureDVG()
        {
            // largura do Datagridviw
            dgvGerenciador.Columns[2].Width = 500;
            dgvGerenciador.Columns[1].Width = 300;

            // deixar  linha invisivel da planilha
            try
            {
                dgvGerenciador.Columns["Não Ver"].Visible = false;
            }
            catch (Exception TipoDeERRO)
            {

                MessageBox.Show("Error : " + '\n' + TipoDeERRO);
            }
            
        }

        private void dgvGerenciador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvGerenciador.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgvGerenciador.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgvGerenciador.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgvGerenciador.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dgvGerenciador.CurrentRow.Cells[4].Value.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
