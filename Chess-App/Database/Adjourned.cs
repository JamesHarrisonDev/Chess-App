using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Database
{
    class StoredBoard
    {
        public string Username { get; set; }
        public string BoardState { get; set; }
        public int Difficulty { get; set; }
        public int WhiteTime { get; set; }
        public int BlackTime { get; set; }
        public int Increment { get; set; }
        public int Turn { get; set; }
    }

    internal class Adjourned : ChessDatabase
    {
        public List<StoredBoard> GetStoredBoard(string sql)
        {
            List<StoredBoard> adjourned = new List<StoredBoard>();

            SqlCommand cmd = CreateCommand();
            cmd.CommandText = sql;

            // Getting all adjourned boards that meet the sql command requirements
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                string boardState = reader.GetString(1);
                int difficulty = reader.GetInt32(2);
                int whiteTime = reader.GetInt32(3);
                int blackTime = reader.GetInt32(4);
                int increment = reader.GetInt32(5);
                int turn = reader.GetInt32(6);

                StoredBoard storedBoard = new StoredBoard();
                storedBoard.Username = username;
                storedBoard.BoardState = boardState;
                storedBoard.Difficulty = difficulty;
                storedBoard.WhiteTime = whiteTime;
                storedBoard.BlackTime = blackTime;
                storedBoard.Increment = increment;
                storedBoard.Turn = turn;
                adjourned.Add(storedBoard);
            }

            return adjourned;
        }
    }
}
