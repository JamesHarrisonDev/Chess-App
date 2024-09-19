using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Forms.Main_Menu.Play.Gameplay
{
    public class Move
    {
        public Point previousPosition { get; set; }
        public Point newPosition { get; set; }
        public int score { get; set; }

        public Move() { } // Constructor for general move

        public Move(int s) // Constructor to set the initial score of a move for computer opponent
        {
            score = s;
        }
    }
}
