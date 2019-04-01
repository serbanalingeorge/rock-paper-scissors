using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors.Helper;

namespace RockPaperScissors.DBConnection
{
    
    public abstract class CreateTransaction
    {
        public readonly DbConnection DbConnection = new DbConnection();

        [SetUp]
        public void AddValueDb()
        {
            DbConnection.Transaction(SqlQuery.Add());
        }

        [TearDown]
        public void DeleteValueDb()
        {
            DbConnection.Transaction(SqlQuery.Delete());
        }
    }
}
