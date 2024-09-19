using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class Blank : Piece
    {
        public Blank(int r, int c)
        {
            row = r;
            column = c;
            player = Player.Null;
            image = null;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            return null; // Blank square has no valid moves
        }
    }
}
