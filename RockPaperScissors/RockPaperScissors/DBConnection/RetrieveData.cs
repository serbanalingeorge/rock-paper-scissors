using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.GameRules;

namespace RockPaperScissors.DBConnection
{
    public class RetrieveData
    {
        private const string ConnectionString = "Server=(localdb)\\v13.0;Database=TestDB1;Integrated Security=True;";
        private readonly DataTable result = new DataTable();
        public string RetrieveDbData(string query)
        {

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        result.Load(reader);
                        var text = Convert.ToString(result.Rows[0]["shape"]);
                        Console.WriteLine(text);
                        return text;
                    }
                }
            }

        }
    }
}
