using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Database
{
    class Stats
    {
        public string Username { get; set; }
        public int WhiteWins { get; set; }
        public int BlackWins { get; set; }
        public int Draws { get; set; }
        public int WhiteResigns { get; set; }
        public int BlackResigns { get; set; }
        public int WhiteTimeouts { get; set; }
        public int BlackTimeouts { get; set; }
        public int WhiteCheckmates { get; set; }
        public int BlackCheckmates { get; set; }
        public int EasyWins { get; set; }
        public int MediumWins { get; set; }
        public int HardWins { get; set; }
    }

    internal class UserStatistics : ChessDatabase
    {
        public List<Stats> GetStats(string sql)
        {
            List<Stats> userStatistics = new List<Stats>();

            SqlCommand cmd = CreateCommand();
            cmd.CommandText = sql;

            // Getting all user statistics that meet the sql command requirements
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                int whiteWins = reader.GetInt32(1);
                int blackWins = reader.GetInt32(2);
                int draws = reader.GetInt32(3);
                int whiteResigns = reader.GetInt32(4);
                int blackResigns = reader.GetInt32(5);
                int whiteTimeouts = reader.GetInt32(6);
                int blackTimeouts = reader.GetInt32(7);
                int whiteCheckmates = reader.GetInt32(8);
                int blackCheckmates = reader.GetInt32(9);
                int easyWins = reader.GetInt32(10);
                int mediumWins = reader.GetInt32(11);
                int hardWins = reader.GetInt32(12);

                Stats stats = new Stats();
                stats.Username = username;
                stats.WhiteWins = whiteWins;
                stats.BlackWins = blackWins;
                stats.Draws = draws;
                stats.WhiteResigns = whiteResigns;
                stats.BlackResigns = blackResigns;
                stats.WhiteTimeouts = whiteTimeouts;
                stats.BlackTimeouts = blackTimeouts;
                stats.WhiteCheckmates = whiteCheckmates;
                stats.BlackCheckmates = blackCheckmates;
                stats.EasyWins = easyWins;
                stats.MediumWins = mediumWins;
                stats.HardWins = hardWins;
                userStatistics.Add(stats);
            }

            return userStatistics;
        }
    }
}
