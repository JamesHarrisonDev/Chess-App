using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Database
{
    public class ChessDatabase
    {
        private const string ConnectionString = "CONNECTION STRING GOES HERE";
        private SqlConnection connection = null;

        public ChessDatabase()
        {
            // Establish database connection
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        public SqlCommand CreateCommand()
        {
            return connection.CreateCommand();
        }

        public void ExecuteSql(string sql)
        {
            SqlCommand cmd = CreateCommand();
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
        }
    }
}
