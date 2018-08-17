using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_Testes_2018
{
    public class FileManipulation
    {
        public static List<Excel> ReadExcelFile()
        {
            var file = @"D:\PESCAR_PLANILHA_VS.xlsx";
            var oleDbConnection = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", file));

            var list = new List<Excel>();
            var oleDbDataAdapter = new OleDbDataAdapter("select * from[2018$]", oleDbConnection);
            DataSet ds = new DataSet();

            try
            {
                oleDbConnection.Open();
                oleDbDataAdapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var result = new Excel();

 
                        result.UF = row["DATA"].ToString();
                        result.Nome = row["Nome"].ToString();
                        result.Sigla = row["OPERAÇÃO SUPORTE"].ToString();

                        list.Add(result);
                }
            }
            finally
            {
                oleDbConnection.Close();
                oleDbConnection.Dispose();
            }
            return list;
        }

    }
}
