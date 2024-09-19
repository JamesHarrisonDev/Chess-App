using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    public enum Player
    {
        White,
        Black,
        Null // Player type for blank pieces
    }

    public abstract class Piece
    {
        public int row, column;
        public Player player;
        public Image image;
        public bool canCastle, canEnPassant; // For king/rook and pawn special moves

        // Method to get all possible moves for a piece (not considering check/checkmate)
        public abstract List<Point> GetValidMoves(Piece[,] board);
    }
}
