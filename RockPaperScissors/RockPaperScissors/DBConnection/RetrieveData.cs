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
        private string connectionString = "Server=(localdb)\\v13.0;Database=TestDB1;Integrated Security=True;";
        readonly DataTable result = new DataTable();
        public string RetrieveDbData(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
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
