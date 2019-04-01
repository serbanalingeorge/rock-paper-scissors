using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.DBConnection
{
    public class DbConnection
    {
        private const string ConnectionString = "Server=(localdb)\\v13.0;Database=TestDB1;Integrated Security=True;";
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        private void OpenConnection()
        {
           conn = new SqlConnection(ConnectionString);
           conn.Open();
        }

        private void CloseConnection()
        {
           conn.Close();
        }

        private void ExecuteQueries(string query)
        {
           cmd = new SqlCommand(query,conn);
        }

        private void ExecuteReader()
        {
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{1}, {0}", reader.GetString(0), reader.GetString(1));
            }
        }

        private void EndExecuteReader()
        {
            reader.Close();
        }

        private static void GetSearchResults()
        {
            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        public void Transaction(string input)
        {
            OpenConnection();
            ExecuteQueries(input);
            ExecuteReader();
            EndExecuteReader();
            CloseConnection();
            GetSearchResults();
        }


    }
}
