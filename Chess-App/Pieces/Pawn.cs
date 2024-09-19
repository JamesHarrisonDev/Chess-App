using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(int r, int c, Player p)
        {
            row = r;
            column = c;
            player = p;
            canEnPassant = false;

            if (player == Player.White)
                image = Resources.whitePawn;
            else
                image = Resources.blackPawn;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            List<Point> validMoves = new List<Point>();

            switch (this.player)
            {
                case Player.White:
                    if (row != 0) // Check for no pawn promotion
                    {
                        if (board[row - 1, column].GetType().Name == "Blank")
                        {
                            validMoves.Add(new Point(row - 1, column));

                            if (row == 6 && board[row - 2, column].GetType().Name == "Blank") // Check for double jump validity
                                validMoves.Add(new Point(row - 2, column));
                        }

                        if (column != Board.boardSize - 1)
                        {
                            if (board[row - 1, column + 1].GetType().Name != "Blank") // Check for pawn capture move to the right
                                if (board[row - 1, column + 1].player == Player.Black)
                                    validMoves.Add(new Point(row - 1, column + 1));

                            if (board[row, column + 1].canEnPassant) // Check for en passant move to the right
                                validMoves.Add(new Point(row - 1, column + 1));
                        }

                        if (column != 0)
                        {
                            if (board[row - 1, column - 1].GetType().Name != "Blank") // Check for pawn capture move to the left
                                if (board[row - 1, column - 1].player == Player.Black)
                                    validMoves.Add(new Point(row - 1, column - 1));

                            if (board[row, column - 1].canEnPassant) // Check for en passant move to the left
                                validMoves.Add(new Point(row - 1, column - 1));
                        }
                    }
                    
                    break;

                case Player.Black:
                    if (row != 7) // Check for no pawn promotion
                    {
                        if (board[row + 1, column].GetType().Name == "Blank")
                        {
                            validMoves.Add(new Point(row + 1, column));

                            if (row == 1 && board[row + 2, column].GetType().Name == "Blank") // Check for double jump validity
                                validMoves.Add(new Point(row + 2, column));
                        }

                        if (column != Board.boardSize - 1)
                        {
                            if (board[row + 1, column + 1].GetType().Name != "Blank") // Check for pawn capture move to the right
                                if (board[row + 1, column + 1].player == Player.White)
                                    validMoves.Add(new Point(row + 1, column + 1));

                            if (board[row, column + 1].canEnPassant) // Check for en passant move to the right
                                validMoves.Add(new Point(row + 1, column + 1));
                        }

                        if (column != 0)
                        {
                            if (board[row + 1, column - 1].GetType().Name != "Blank") // Check for pawn capture move to the left
                                if (board[row + 1, column - 1].player == Player.White)
                                    validMoves.Add(new Point(row + 1, column - 1));

                            if (board[row, column - 1].canEnPassant) // Check for en passant move to the left
                                validMoves.Add(new Point(row + 1, column - 1));
                        }
                    }

                    break;
            }

            return validMoves;
        }
    }
}
