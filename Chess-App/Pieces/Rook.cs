using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class Rook : Piece
    {
        public Rook(int r, int c, Player p)
        {
            row = r;
            column = c;
            player = p;
            canCastle = true;

            if (player == Player.White)
                image = Resources.whiteRook;
            else
                image = Resources.blackRook;
        }

        public Rook(int r, int c, Player p, bool castle) // Constructor for pawn promoted to rook (rook cannot castle)
        {
            row = r;
            column = c;
            player = p;
            canCastle = castle;

            if (player == Player.White)
                image = Resources.whiteRook;
            else
                image = Resources.blackRook;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            int changeRow = row;
            int changeColumn = column;
            List<Point> validMoves = new List<Point>();

            // Getting all valid left moves
            while (changeColumn >= 0)
            {
                if (changeColumn != column)
                {
                    if (board[row, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(row, changeColumn));
                    }
                    else if (board[row, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(row, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the left direction
                changeColumn--;
            }

            changeColumn = column;
            // Getting all valid right moves
            while (changeColumn < Board.boardSize)
            {
                if (changeColumn != column)
                {
                    if (board[row, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(row, changeColumn));
                    }
                    else if (board[row, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(row, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the right direction
                changeColumn++;
            }

            // Getting all valid top moves
            while (changeRow >= 0)
            {
                if (changeRow != row)
                {
                    if (board[changeRow, column].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, column));
                    }
                    else if (board[changeRow, column].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, column));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the top direction
                changeRow--;
            }

            changeRow = row;
            // Getting all valid bottom moves
            while (changeRow < Board.boardSize)
            {
                if (changeRow != row)
                {
                    if (board[changeRow, column].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, column));
                    }
                    else if (board[changeRow, column].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, column));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the bottom direction
                changeRow++;
            }

            return validMoves;
        }
    }
}
