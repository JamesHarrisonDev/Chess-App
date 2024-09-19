using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class Knight : Piece
    {
        public Knight(int r, int c, Player p)
        {
            row = r;
            column = c;
            player = p;

            if (player == Player.White)
                image = Resources.whiteKnight;
            else
                image = Resources.blackKnight;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            List<Point> validMoves = new List<Point>();

            if (column - 1 >= 0)
            {
                // Checking for knight left 1 up 2 move
                if (row - 2 >= 0)
                {
                    if (board[row - 2, column - 1].GetType().Name == "Blank")
                        validMoves.Add(new Point(row - 2, column - 1));
                    else if (board[row - 2, column - 1].player != this.player)
                        validMoves.Add(new Point(row - 2, column - 1));
                }
                // Checking for knight left 1 down 2 move
                if (row + 2 < Board.boardSize)
                {
                    if (board[row + 2, column - 1].GetType().Name == "Blank")
                        validMoves.Add(new Point(row + 2, column - 1));
                    else if (board[row + 2, column - 1].player != this.player)
                        validMoves.Add(new Point(row + 2, column - 1));
                }
            }

            if (column + 1 < Board.boardSize)
            {
                // Checking for knight right 1 up 2 move
                if (row - 2 >= 0)
                {
                    if (board[row - 2, column + 1].GetType().Name == "Blank")
                        validMoves.Add(new Point(row - 2, column + 1));
                    else if (board[row - 2, column + 1].player != this.player)
                        validMoves.Add(new Point(row - 2, column + 1));
                }
                // Checking for knight right 1 down 2 move
                if (row + 2 < Board.boardSize)
                {
                    if (board[row + 2, column + 1].GetType().Name == "Blank")
                        validMoves.Add(new Point(row + 2, column + 1));
                    else if (board[row + 2, column + 1].player != this.player)
                        validMoves.Add(new Point(row + 2, column + 1));
                }
            }

            if (column - 2 >= 0)
            {
                // Checking for knight left 2 up 1 move
                if (row - 1 >= 0)
                {
                    if (board[row - 1, column - 2].GetType().Name == "Blank")
                        validMoves.Add(new Point(row - 1, column - 2));
                    else if (board[row - 1, column - 2].player != this.player)
                        validMoves.Add(new Point(row - 1, column - 2));
                }
                // Checking for knight left 2 down 1 move
                if (row + 1 < Board.boardSize)
                {
                    if (board[row + 1, column - 2].GetType().Name == "Blank")
                        validMoves.Add(new Point(row + 1, column - 2));
                    else if (board[row + 1, column - 2].player != this.player)
                        validMoves.Add(new Point(row + 1, column - 2));
                }
            }

            if (column + 2 < Board.boardSize)
            {
                // Checking for knight right 2 up 1 move
                if (row - 1 >= 0)
                {
                    if (board[row - 1, column + 2].GetType().Name == "Blank")
                        validMoves.Add(new Point(row - 1, column + 2));
                    else if (board[row - 1, column + 2].player != this.player)
                        validMoves.Add(new Point(row - 1, column + 2));
                }
                // Checking for knight right 2 down 1 move
                if (row + 1 < Board.boardSize)
                {
                    if (board[row + 1, column + 2].GetType().Name == "Blank")
                        validMoves.Add(new Point(row + 1, column + 2));
                    else if (board[row + 1, column + 2].player != this.player)
                        validMoves.Add(new Point(row + 1, column + 2));
                }
            }

            return validMoves;
        }
    }
}

