using System;
using System.Data.OleDb;

namespace ProjetoIntegradoArmazem
{
    class ExeQuery
    {
        public ExeQuery(string SQL)
        {
            ConexaoBD conect = new ConexaoBD();
            using (OleDbConnection connection = new OleDbConnection(conect.StrConexao()))
            {

                OleDbCommand command = new OleDbCommand(SQL);

                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
