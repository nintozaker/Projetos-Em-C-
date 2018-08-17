using JournalScreenControl.Core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalScreenControl.Data.Utils
{
    public static class FileManipulation
    {
        public static List<Journal> ReadExcelFile()
        {
            var file = @"Y:\Grp_Base_de_Dados\Ronaldo\Programas Do Visual Studio\JournalScreenControl\Diarios_Ataulaizados2.xlsx";
            var oleDbConnection = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", file));

            var list = new List<Journal>();
            var oleDbDataAdapter = new OleDbDataAdapter("select * from[Diarios$]", oleDbConnection);
            DataSet ds = new DataSet();

            try
            {
                oleDbConnection.Open();
                oleDbDataAdapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var result =  new Journal();


                    result.UF = row["UF"].ToString();
                    result.Name = row["NomeDiario"].ToString();
                    result.Sigla = row["Sigla"].ToString();
                    result.Url = row["URL"].ToString();

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
