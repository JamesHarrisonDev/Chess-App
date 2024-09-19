using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    internal class Bishop : Piece
    {
        public Bishop(int r, int c, Player p)
        {
            row = r;
            column = c;
            player = p;

            if (player == Player.White)
                image = Resources.whiteBishop;
            else
                image = Resources.blackBishop;
        }

        public override List<Point> GetValidMoves(Piece[,] board)
        {
            int changeRow = row;
            int changeColumn = column;
            List<Point> validMoves = new List<Point>();

            // Getting all valid top left diagonal moves
            while (changeColumn >= 0 && changeRow >= 0)
            {
                if (changeColumn != column)
                {
                    if (board[changeRow, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                    }
                    else if (board[changeRow, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the top left direction
                changeRow--;
                changeColumn--;
            }

            changeRow = row;
            changeColumn = column;
            // Getting all valid bottom right diagonal moves
            while (changeColumn < Board.boardSize && changeRow < Board.boardSize)
            {
                if (changeColumn != column)
                {
                    if (board[changeRow, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                    }
                    else if (board[changeRow, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if there is a piece of the same colour blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the bottom right direction
                changeRow++;
                changeColumn++;
            }

            changeRow = row;
            changeColumn = column;
            // Getting all valid top right diagonal moves
            while (changeColumn < Board.boardSize && changeRow >= 0)
            {
                if (changeColumn != column)
                {
                    if (board[changeRow, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                    }
                    else if (board[changeRow, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if a player piece is blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the top right direction
                changeRow--;
                changeColumn++;
            }

            changeRow = row;
            changeColumn = column;
            // Getting all valid bottom left diagonal moves
            while (changeColumn >= 0 && changeRow < Board.boardSize)
            {
                if (changeColumn != column)
                {
                    if (board[changeRow, changeColumn].GetType().Name == "Blank")
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                    }
                    else if (board[changeRow, changeColumn].player != this.player)
                    {
                        validMoves.Add(new Point(changeRow, changeColumn));
                        break; // if there is a capture move, no further moves in this direction are valid
                    }
                    else
                    {
                        break; // if a player piece is blocking, no further moves in this direction are valid
                    }
                }

                // changing to next square in the bottom left direction
                changeRow++;
                changeColumn--;
            }

            return validMoves;
        }
    }
}

