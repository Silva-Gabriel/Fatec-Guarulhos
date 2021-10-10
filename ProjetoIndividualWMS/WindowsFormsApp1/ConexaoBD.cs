using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public class ConexaoBD
    {
        public ConexaoBD() { }

        public string StrConexao() 
        {
            return @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BD\BDP2-WMSV2.mdb";
        }

        public OleDbConnection conexaoBD(string StrConexao)
        {
            OleDbConnection conect = new OleDbConnection(StrConexao);
            return conect;
        }
    }
}
