using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Excel
{
    public partial class FormExcel : Form
    {
		
        private OleDbConnection _olecon;
        private OleDbCommand _oleCmd;

        private static String _Arquivo = @"D:\Empregados.xlsx";
        private String _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
        private String _Consulta;

        public FormExcel()
        {
            InitializeComponent();
        }
        private void FormExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_oleCmd != null)
            {
                _oleCmd.Parameters.Clear();
                _oleCmd.Dispose();
            }

            _oleCmd = null;

            if (_olecon != null)
            {
                if (_olecon.State == ConnectionState.Open)
                    _olecon.Close();

                _olecon.Dispose();
            }

            _olecon = null;
        }
        private void FormExcel_Load(object sender, EventArgs e)
        {
            try
            {
                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _Consulta = "INSERT INTO [Empregados$] ";
            _Consulta += "([CodFunci],[NomeFunci]) ";
            _Consulta += "VALUES ";
            _Consulta += "(@CodFunci,@NomeFunci)";

            _oleCmd.CommandText = _Consulta;
            _oleCmd.Parameters.Add("@CodFunci", OleDbType.Integer).Value = Convert.ToInt32(txtCodigoFunci.Text);
            _oleCmd.Parameters.Add("@NomeFunci", OleDbType.VarChar, 255).Value = txtNomeFunci.Text.Trim();
            _oleCmd.ExecuteNonQuery();

            _oleCmd.Parameters.Clear();

            txtCodigoFunci.ResetText();
            txtNomeFunci.ResetText();

            MessageBox.Show("Dados Incluídos...");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                _Consulta = "UPDATE [Empregados$] ";
                _Consulta += "SET [NomeFunci] = @NomeFunci ";
                _Consulta += "WHERE ";
                _Consulta += "[CodFunci] = @CodFunci";

                _oleCmd.CommandText = _Consulta;
                _oleCmd.Parameters.Add("@NomeFunci", OleDbType.VarChar, 255).Value = txtNomeFunci.Text.Trim();
                _oleCmd.Parameters.Add("@CodFunci", OleDbType.Integer).Value = Convert.ToInt32(txtCodigoFunci.Text);
                _oleCmd.ExecuteNonQuery();

                _oleCmd.Parameters.Clear();

                txtCodigoFunci.ResetText();
                txtNomeFunci.ResetText();

                MessageBox.Show("Dados Atualizados....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                _oleCmd.CommandText = "SELECT CodFunci, NomeFunci FROM [Empregados$] Where CodFunci = " + txtCodigoFunci.Text;

                OleDbDataReader reader = _oleCmd.ExecuteReader();

                while (reader.Read())
                {
                    txtCodigoFunci.Text = reader.GetValue(0).ToString();
                    txtNomeFunci.Text = reader.GetString(1);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}