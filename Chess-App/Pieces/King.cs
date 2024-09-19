using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class King : Piece
    {
        public King(int r, int c, Player p)
        {
            row = r;
            column = c;
            player = p;
            canCastle = true;

            if (player == Player.White)
                image = Resources.whiteKing;
            else
                image = Resources.blackKing;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            List<Point> validMoves = new List<Point>();
            
            // Checking for move to the left of the king
            if (column - 1 >= 0)
            {
                if (board[row, column - 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row, column - 1));
                }
                else if (board[row, column - 1].player != this.player)
                {
                    validMoves.Add(new Point(row, column - 1));
                }
            }

            // Checking for move to the right of the king
            if (column + 1 < Board.boardSize)
            {
                if (board[row, column + 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row, column + 1));
                }
                else if (board[row, column + 1].player != this.player)
                {
                    validMoves.Add(new Point(row, column + 1));
                }
            }

            // Checking for move to the top of the king
            if (row - 1 >= 0)
            {
                if (board[row - 1, column].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row - 1, column));
                }
                else if (board[row - 1, column].player != this.player)
                {
                    validMoves.Add(new Point(row - 1, column));
                }
            }

            // Checking for move to the bottom of the king
            if (row + 1 < Board.boardSize)
            {
                if (board[row + 1, column].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row + 1, column));
                }
                else if (board[row + 1, column].player != this.player)
                {
                    validMoves.Add(new Point(row + 1, column));
                }
            }

            // Checking for move to the top left of the king
            if (column - 1 >= 0 && row - 1 >= 0)
            {
                if (board[row - 1, column - 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row - 1, column - 1));
                }
                else if (board[row - 1, column - 1].player != this.player)
                {
                    validMoves.Add(new Point(row - 1, column - 1));
                }
            }

            // Checking for move to the bottom right of the king
            if (column + 1 < Board.boardSize && row + 1 < Board.boardSize)
            {
                if (board[row + 1, column + 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row + 1, column + 1));
                }
                else if (board[row + 1, column + 1].player != this.player)
                {
                    validMoves.Add(new Point(row + 1, column + 1));
                }
            }

            // Checking for move to the top right of the king
            if (column + 1 < Board.boardSize && row - 1 >= 0)
            {
                if (board[row - 1, column + 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row - 1, column + 1));
                }
                else if (board[row - 1, column + 1].player != this.player)
                {
                    validMoves.Add(new Point(row - 1, column + 1));
                }
            }

            // Checking for move to the bottom left of the king
            if (column - 1 >= 0 && row + 1 < Board.boardSize)
            {
                if (board[row + 1, column - 1].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(row + 1, column - 1));
                }
                else if (board[row + 1, column - 1].player != this.player)
                {
                    validMoves.Add(new Point(row + 1, column - 1));
                }
            }
            
            if (this.player == Player.White && this.canCastle)
            {
                // Checking for validity of white castling king side
                if (board[7, 7].GetType().Name == "Rook" &&
                    board[7, 7].canCastle &&
                    board[7, 6].GetType().Name == "Blank" &&
                    board[7, 5].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(7, 6));
                }

                // Checking for validity of white castling queen side
                if (board[7, 0].GetType().Name == "Rook" &&
                    board[7, 0].canCastle &&
                    board[7, 1].GetType().Name == "Blank" &&
                    board[7, 2].GetType().Name == "Blank" &&
                    board[7, 3].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(7, 2));
                }
            }

            if (this.player == Player.Black && this.canCastle)
            {
                // Checking for validity of black castling king side
                if (board[0, 7].GetType().Name == "Rook" &&
                    board[0, 7].canCastle &&
                    board[0, 6].GetType().Name == "Blank" &&
                    board[0, 5].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(0, 6));
                }

                // Checking for validity of black castling queen side
                if (board[0, 0].GetType().Name == "Rook" &&
                    board[0, 0].canCastle &&
                    board[0, 1].GetType().Name == "Blank" &&
                    board[0, 2].GetType().Name == "Blank" &&
                    board[0, 3].GetType().Name == "Blank")
                {
                    validMoves.Add(new Point(0, 2));
                }
            }
            
            return validMoves;
        }
    }
}

