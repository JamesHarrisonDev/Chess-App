using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Database
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    internal class Users : ChessDatabase
    {
        public List<User> GetUsers(string sql)
        {
            List<User> users = new List<User>();

            SqlCommand cmd = CreateCommand();
            cmd.CommandText = sql;

            // Getting all users that meet the sql command requirements
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                string password = reader.GetString(1);

                User user = new User();
                user.Username = username;
                user.Password = password;
                users.Add(user);
            }

            return users;
        }
    }
}
