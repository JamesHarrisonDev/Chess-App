using ChessApp.Pieces;
using ChessApp.Forms.Main_Menu.Play;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp.Forms.Main_Menu.Play
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }

        private void buttonQueen_Click(object sender, EventArgs e) // Promotes previous pawn move to queen
        {
            this.Hide();
            Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y] = new Queen(Board.lastMove[1].X, Board.lastMove[1].Y, Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y].player);
            Board.CompletePromotion();
        }

        private void buttonRook_Click(object sender, EventArgs e) // Promotes previous pawn move to rook
        {
            this.Hide();
            Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y] = new Rook(Board.lastMove[1].X, Board.lastMove[1].Y, Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y].player, false);
            Board.CompletePromotion();
        }

        private void buttonKnight_Click(object sender, EventArgs e) // Promotes previous pawn move to knight
        {
            this.Hide();
            Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y] = new Knight(Board.lastMove[1].X, Board.lastMove[1].Y, Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y].player);
            Board.CompletePromotion();
        }

        private void buttonBishop_Click(object sender, EventArgs e) // Promotes previous pawn move to bishop
        {
            this.Hide();
            Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y] = new Bishop(Board.lastMove[1].X, Board.lastMove[1].Y, Board.pieceBoard[Board.lastMove[1].X, Board.lastMove[1].Y].player);
            Board.CompletePromotion();
        }
    }
}
