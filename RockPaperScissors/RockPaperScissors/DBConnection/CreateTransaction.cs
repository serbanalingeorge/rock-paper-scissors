using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RockPaperScissors.DBConnection
{
    
    public class CreateTransaction
    {
        DbConnection dbConnection = new DbConnection();

        private const string QueryAdd = "INSERT INTO dbo.Shapes (shapeID,shape) " +
                                        "VALUES (1,'rock'),(2,'paper'),(3,'scissors')";

        private const string QueryDelete = "DELETE FROM dbo.Shapes";

        [SetUp]
        public void AddValueDB()
        {
            dbConnection.Transaction(QueryAdd);
        }

        [TearDown]
        public void DeleteValueDb()
        {
            dbConnection.Transaction(QueryDelete);
        }
    }
}
