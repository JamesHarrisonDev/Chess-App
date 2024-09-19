using ChessApp.Database;
using ChessApp.Forms.Main_Menu.Play;
using ChessApp.Forms.Main_Menu.Play.Local_Play;
using ChessApp.Forms.Main_Menu.Play.Gameplay;
using ChessApp.Pieces;
using ChessApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ChessApp
{
    internal class Board
    {
        public static int boardSize = 8;
        public static int playerTurn;
        public static int whiteTime;
        public static int blackTime;
        public static int increment;
        public static bool promotion;
        public static bool madeMove;
        public static Play form;
        public static Form owner;
        public static Point[] lastMove;
        public static bool adjournedGame = false;
        public static Player[] player = new Player[] { Player.White, Player.Black };

        public static PictureBox[,] graphicsBoard = new PictureBox[boardSize, boardSize];
        public static Piece[,] pieceBoard = new Piece[boardSize, boardSize];

        public static Minimax computerOpponent = null;

        public Board(Play playWindow, Form playWindowOwner, Char[,] startingBoard, int turn = 0, int wt = 0, int bt = 0, int inc = 0, bool adjourned = false)
        {
            playerTurn = turn;
            promotion = false;
            lastMove = new Point[2];
            owner = playWindowOwner;
            form = playWindow;
            adjournedGame = adjourned;

            if (owner.GetType().Name == "PlayLocalSettings") // Game is either an adjourned game or a normal local game
            {
                if (turn == 1) // Adjourned game where it is black's turn
                    form.labelPlayerTurn.Text = "Turn: Black";

                if (wt > 0) // Adjourned game timer settings
                {
                    whiteTime = wt;
                    blackTime = bt;
                    increment = inc;
                }
                else // Local game timer settings
                {
                    whiteTime = PlayLocalSettings.hScrollBarTimer.Value * 60;
                    blackTime = PlayLocalSettings.hScrollBarTimer.Value * 60;
                    increment = PlayLocalSettings.hScrollBarIncrement.Value;
                }
            }
            else // Game is against a computer opponent
            {
                whiteTime = 0;
                blackTime = 0;
                increment = 0;

                if (form.labelDifficulty.Text == "Easy")
                {
                    if (form.labelAI.Text.EndsWith("White"))
                        computerOpponent = new Minimax(Difficulty.Easy, Player.White); // Easy white comp
                    else
                        computerOpponent = new Minimax(Difficulty.Easy, Player.Black); // Easy black comp
                }
                else if (form.labelDifficulty.Text == "Medium")
                {
                    if (form.labelAI.Text.EndsWith("White"))
                        computerOpponent = new Minimax(Difficulty.Medium, Player.White); // Medium white comp
                    else
                        computerOpponent = new Minimax(Difficulty.Medium, Player.Black); // Medium black comp
                }
                else
                {
                    if (form.labelAI.Text.EndsWith("White"))
                        computerOpponent = new Minimax(Difficulty.Hard, Player.White); // Hard white comp
                    else
                        computerOpponent = new Minimax(Difficulty.Hard, Player.Black); // Hard black comp
                }
            }

            CreateBoard(form, startingBoard); // Establishes the initial display of the board
            EndOfMoveChecks(form); // Displays the check label if it is an adjourned board/puzzle board where the player to move starts in check
            Gameplay(form); // Sets up all the functionality for the chess square panels

            if (owner.GetType().Name == "PlayComputerSettings" && turn == 0)
            {
                if (computerOpponent.maximising)
                {
                    // Performs starting move for computer opponent playing as white
                    computerOpponent.Search(pieceBoard, computerOpponent.startingDepth, int.MinValue, int.MaxValue, computerOpponent.maximising);
                    Move move = computerOpponent.GetBestMove(computerOpponent.maximising);

                    pieceBoard = MakeMove(move, pieceBoard, true);
                    UpdateIndexes(pieceBoard);

                    lastMove[0] = new Point(move.previousPosition.X, move.previousPosition.Y);
                    lastMove[1] = new Point(move.newPosition.X, move.newPosition.Y);

                    playerTurn = 1;
                    DisplayBoard();
                }
            }
        }

        private void CreateBoard(Play form, Char[,] startingBoard)
        {
            int left;
            int top = 2; // inital indentaton for top of board
            int squareSize = (form.panelBoard.Size.Width - 4) / boardSize;
            string[] colourTags = new string[2];
            Color[] colours = new Color[] { Color.White, Color.Gray };

            for (int row = 0; row < boardSize; row++)
            {
                left = 2; // initial indentation for side of board

                if (row % 2 == 0)
                {
                    colours[0] = Color.White;
                    colours[1] = Color.Gray;

                    colourTags[0] = "white";
                    colourTags[1] = "gray";
                }
                else
                {
                    colours[0] = Color.Gray;
                    colours[1] = Color.White;

                    colourTags[0] = "gray";
                    colourTags[1] = "white";
                }

                for (int column = 0; column < boardSize; column++) // Iterating through every square in the board
                {
                    graphicsBoard[row, column] = new PictureBox();
                    graphicsBoard[row, column].BackColor = colours[(column % 2 == 0) ? 0 : 1];
                    graphicsBoard[row, column].Tag = colourTags[(column % 2 == 0) ? 0 : 1];
                    graphicsBoard[row, column].Location = new Point(left, top);
                    graphicsBoard[row, column].Size = new Size(squareSize, squareSize);
                    left += squareSize; // Increasing the side indentation for the next square

                    // Converting FEN notation to object board
                    switch (startingBoard[row, column])
                    {
                        case 'P':
                            pieceBoard[row, column] = new Pawn(row, column, Player.White);
                            break;
                        case 'B':
                            pieceBoard[row, column] = new Bishop(row, column, Player.White);
                            break;
                        case 'N':
                            pieceBoard[row, column] = new Knight(row, column, Player.White);
                            break;
                        case 'R':
                            pieceBoard[row, column] = new Rook(row, column, Player.White);
                            break;
                        case 'Q':
                            pieceBoard[row, column] = new Queen(row, column, Player.White);
                            break;
                        case 'K':
                            pieceBoard[row, column] = new King(row, column, Player.White);
                            break;
                        case 'p':
                            pieceBoard[row, column] = new Pawn(row, column, Player.Black);
                            break;
                        case 'b':
                            pieceBoard[row, column] = new Bishop(row, column, Player.Black);
                            break;
                        case 'n':
                            pieceBoard[row, column] = new Knight(row, column, Player.Black);
                            break;
                        case 'r':
                            pieceBoard[row, column] = new Rook(row, column, Player.Black);
                            break;
                        case 'q':
                            pieceBoard[row, column] = new Queen(row, column, Player.Black);
                            break;
                        case 'k':
                            pieceBoard[row, column] = new King(row, column, Player.Black);
                            break;
                        default:
                            pieceBoard[row, column] = new Blank(row, column);
                            break;
                    }

                    graphicsBoard[row, column].SizeMode = PictureBoxSizeMode.CenterImage;
                    form.panelBoard.Controls.Add(graphicsBoard[row, column]);
                }

                top += squareSize; // Increasing the top indentation for the next row of squares
            }

            if (whiteTime == 0) // Check for timers being off
            {
                form.labelWhiteTimer.Hide();
                form.labelBlackTimer.Hide();
            }
            else // Timers are on
            {
                form.labelWhiteTimer.Text = FormatTime(whiteTime);
                form.labelBlackTimer.Text = FormatTime(blackTime);
            }

            DisplayBoard();
        }

        public static string FormatTime(int time)
        {
            int minutes = time / 60;
            int seconds = time % 60;

            // Formating time from seconds to minutes and seconds
            if (minutes > 9 && seconds > 9)
                return $"{minutes}:{seconds}";
            else if (minutes > 9)
                return $"{minutes}:0{seconds}";
            else if (seconds > 9)
                return $"0{minutes}:{seconds}";
            else
                return $"0{minutes}:0{seconds}";
        }

        public static void CompletePromotion()
        {
            promotion = false;

            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    graphicsBoard[row, column].Image = pieceBoard[row, column].image; // Updating the display of the board
                }
            }

            ChangePlayerTurn(form);
            EndOfMoveChecks(form);

            if (owner.GetType().Name == "PlayComputerSettings" && madeMove && !promotion) // Make move once promotion has been completed
            {
                computerOpponent.Search(pieceBoard, computerOpponent.startingDepth, int.MinValue, int.MaxValue, computerOpponent.maximising);
                Move move = computerOpponent.GetBestMove(computerOpponent.maximising);

                pieceBoard = MakeMove(move, pieceBoard, true);
                UpdateIndexes(pieceBoard);
                DisplayBoard();

                // Updating last move to allow checks for en passant
                lastMove[0] = new Point(move.previousPosition.X, move.previousPosition.Y);
                lastMove[1] = new Point(move.newPosition.X, move.newPosition.Y);

                ChangePlayerTurn(form);
                EndOfMoveChecks(form);
            }
        }

        public static void DisplayBoard()
        {
            // Converting board of objects to display
            for (int row = 0; row < boardSize; row++)
            {
                for (int column = 0; column < boardSize; column++)
                {
                    graphicsBoard[row, column].Image = pieceBoard[row, column].image;
                }
            }
        }

        public void ReturnToInitalColour(PictureBox square)
        {
            string squareTag = (string)square.Tag;

            // Reverting square with changed colour (due to displaying moves graphically) back to original colour
            if (squareTag.Contains("white"))
                square.BackColor = Color.White;
            else if (squareTag.Contains("gray"))
                square.BackColor = Color.Gray;
        }

        private Piece PictureBoxToPiece(PictureBox square)
        {
            Piece piece = null;

            // Obtaining the piece object which corresponds to a square on the graphics board
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (square == graphicsBoard[i, j])
                        piece = pieceBoard[i, j];
                }
            }

            return piece;
        }

        public static bool IsCheckmate(Piece[,] board, Player turn)
        {
            // Returns true if there are no valid moves for any pieces that escape check
            foreach (Piece piece in board)
            {
                if (piece.player == turn)
                    if (EscapesCheck(board, piece).Count != 0)
                        return false;
            }

            return true;
        }

        public static bool IsCheck(Piece[,] board, Player turn)
        {
            int kingRow = 0;
            int kingColumn = 0;

            // Gets the location of the given player's king
            foreach (Piece piece in board)
            {
                if (piece.GetType().Name == "King" && piece.player == turn)
                {
                    kingRow = piece.row;
                    kingColumn = piece.column;
                }
            }

            // Checks whether any of the opponent's moves threaten the king
            foreach (Piece piece in board)
            {
                if (piece.player != turn && piece.player != Player.Null)
                    if (piece.GetValidMoves(board).Contains(new Point(kingRow, kingColumn)))
                        return true;
            }

            return false;
        }

        public static bool IsKingVulnerable(Piece[,] board, Player turn) // Method for verifying puzzle boards
        {
            int kingRow = 0;
            int kingColumn = 0;

            // Gets location of alternate player's king
            if (turn == Player.White)
            {
                foreach (Piece piece in board)
                {
                    if (piece.GetType().Name == "King" && piece.player == Player.Black)
                    {
                        kingRow = piece.row;
                        kingColumn = piece.column;
                    }
                }
            }
            else if (turn == Player.Black)
            {
                foreach (Piece piece in board)
                {
                    if (piece.GetType().Name == "King" && piece.player == Player.White)
                    {
                        kingRow = piece.row;
                        kingColumn = piece.column;
                    }
                }
            }

            // Checks whether any of the opponent's moves threaten the king
            foreach (Piece piece in board)
            {
                if (piece.player == turn)
                    if (piece.GetValidMoves(board).Contains(new Point(kingRow, kingColumn)))
                        return true;
            }

            return false;
        }

        public static bool IsVulnerable(Piece[,] board, Point point)
        {
            // Checks whether a given square is vulnerable
            foreach (Piece piece in board)
            {
                if (piece.player != player[playerTurn] && piece.player != Player.Null) // Checks if piece belongs to opponent
                    if (piece.GetValidMoves(board).Contains(new Point(point.X, point.Y)))
                        return true;
            }

            return false;
        }

        public static Piece[,] CreateCloneBoard(Piece[,] originalBoard)
        {
            // Creates a shallow copy of the board that has been passed in
            Piece[,] cloneBoard = new Piece[boardSize, boardSize];
            Array.Copy(originalBoard, cloneBoard, boardSize * boardSize);

            return cloneBoard;
        }

        public static List<Point> EscapesCheck(Piece[,] board, Piece piece, bool InCheck = true)
        {
            List<Point> moves = piece.GetValidMoves(board);
            List<Point> validMoves = new List<Point>();

            // Performs every valid move for the current position
            foreach (Point move in moves)
            {
                Piece[,] cloneBoard = CreateCloneBoard(board);

                switch (piece.GetType().Name)
                {
                    case "Pawn":
                        if (InCheck)
                        {
                            switch (piece.player)
                            {
                                // Pawn en passant moves which escape check
                                case Player.White:
                                    if (cloneBoard[move.X, move.Y].GetType().Name == "Blank" &&
                                        piece.row != move.X && piece.column != move.Y)
                                    {
                                        cloneBoard[move.X + 1, move.Y] = new Blank(move.X + 1, move.Y);
                                    }
                                    break;
                                case Player.Black:
                                    if (cloneBoard[move.X, move.Y].GetType().Name == "Blank" &&
                                        piece.row != move.X && piece.column != move.Y)
                                    {
                                        cloneBoard[move.X - 1, move.Y] = new Blank(move.X - 1, move.Y);
                                    }
                                    break;
                            }
                        }

                        cloneBoard[move.X, move.Y] = new Pawn(move.X, move.Y, piece.player);
                        break;

                    case "Bishop":
                        cloneBoard[move.X, move.Y] = new Bishop(move.X, move.Y, piece.player);
                        break;

                    case "Knight":
                        cloneBoard[move.X, move.Y] = new Knight(move.X, move.Y, piece.player);
                        break;

                    case "Rook":
                        cloneBoard[move.X, move.Y] = new Rook(move.X, move.Y, piece.player);
                        break;

                    case "Queen":
                        cloneBoard[move.X, move.Y] = new Queen(move.X, move.Y, piece.player);
                        break;

                    case "King":
                        if (move.Y < piece.column - 1 || move.Y > piece.column + 1)
                        {
                            // Castling out of check is not possible so any castling move is immediately discarded
                            if (InCheck)
                                continue;

                            // Checking if castling is possible
                            switch (piece.player)
                            {
                                case Player.White:
                                    if (move.Y < piece.column - 1)
                                        if (IsVulnerable(cloneBoard, new Point(7, 2)) || IsVulnerable(cloneBoard, new Point(7, 3)))
                                            continue;
                                        else
                                            cloneBoard[7, 3] = new Rook(7, 3, piece.player);
                                    else
                                        if (IsVulnerable(cloneBoard, new Point(7, 5)) || IsVulnerable(cloneBoard, new Point(7, 6)))
                                            continue;
                                        else
                                            cloneBoard[7, 5] = new Rook(7, 5, piece.player);
                                    break;

                                case Player.Black:
                                    if (move.Y < piece.column - 1)
                                        if (IsVulnerable(cloneBoard, new Point(0, 2)) || IsVulnerable(cloneBoard, new Point(0, 3)))
                                            continue;
                                        else
                                            cloneBoard[0, 3] = new Rook(0, 3, piece.player);
                                    else
                                        if (IsVulnerable(cloneBoard, new Point(0, 5)) || IsVulnerable(cloneBoard, new Point(0, 6)))
                                            continue;
                                        else
                                            cloneBoard[0, 5] = new Rook(0, 5, piece.player);
                                    break;
                            }
                        }
                        
                        cloneBoard[move.X, move.Y] = new King(move.X, move.Y, piece.player);
                        break;

                    default:
                        cloneBoard[move.X, move.Y] = new Blank(move.X, move.Y);
                        break;
                }

                cloneBoard[piece.row, piece.column] = new Blank(piece.row, piece.column);

                // Checks if move performed does escape check and then adds it as a possible move
                if (!IsCheck(cloneBoard, player[playerTurn]))
                    validMoves.Add(move);
            }

            return validMoves;
        }

        public static void UpdateIndexes(Piece[,] board)
        {
            // Updates the row and column properties of each piece object in the board to match their location in the board
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j].row = i;
                    board[i, j].column = j;
                }
            }
        }

        public static Piece[,] MakeMove(Move move, Piece[,] board, bool AI = false)
        {
            Piece[,] movedBoard = CreateCloneBoard(board);

            if (move == null)
                return movedBoard;

            int previousRow = move.previousPosition.X;
            int previousColumn = move.previousPosition.Y;
            int newRow = move.newPosition.X;
            int newColumn = move.newPosition.Y;
            Piece selectedPiece = movedBoard[previousRow, previousColumn];
            Piece currentPiece = movedBoard[newRow, newColumn];

            if (selectedPiece.GetType().Name == "Rook")
            {
                selectedPiece.canCastle = false; // Rook can no longer castle once it has been moved
            }

            if (selectedPiece.GetType().Name == "King" && selectedPiece.player == Player.White && selectedPiece.canCastle) // White king castle moves
            {
                selectedPiece.canCastle = false; // King can no longer castle once it has been moved

                if (currentPiece.column < selectedPiece.column - 1) // Checks to see if king is castling on the left
                {
                    if (movedBoard[7, 0].GetType().Name == "Rook" && movedBoard[7, 0].player == Player.White && movedBoard[7, 0].canCastle) // Checks to see if castle move is valid
                    {
                        // Performs castle
                        movedBoard[7, 3] = movedBoard[7, 0];
                        movedBoard[7, 3].row = 7;
                        movedBoard[7, 3].column = 3;

                        movedBoard[7, 0] = new Blank(7, 0);
                    }
                }
                else if (currentPiece.column > selectedPiece.column + 1) // Checks to see if king is castling on the right
                {
                    if (movedBoard[7, 7].GetType().Name == "Rook" && movedBoard[7, 7].player == Player.White && movedBoard[7, 7].canCastle) // Checks to see if castle move is valid
                    {
                        // Performs castle
                        movedBoard[7, 5] = movedBoard[7, 7];
                        movedBoard[7, 5].row = 7;
                        movedBoard[7, 5].column = 5;

                        movedBoard[7, 7] = new Blank(7, 7);
                    }
                }
            }

            if (selectedPiece.GetType().Name == "King" && selectedPiece.player == Player.Black && selectedPiece.canCastle) // Black king castle moves
            {
                selectedPiece.canCastle = false; // King can no longer castle once it has been moved

                if (currentPiece.column < selectedPiece.column - 1) // Checks to see if king is castling on the left
                {
                    if (movedBoard[0, 0].GetType().Name == "Rook" && movedBoard[0, 0].player == Player.Black && movedBoard[0, 0].canCastle) // Checks to see if castle move is valid
                    {
                        // Performs castle
                        movedBoard[0, 3] = movedBoard[0, 0];
                        movedBoard[0, 3].row = 0;
                        movedBoard[0, 3].column = 3;

                        movedBoard[0, 0] = new Blank(0, 0);
                    }
                }
                else if (currentPiece.column > selectedPiece.column + 1) // Checks to see if king is castling on the right
                {
                    if (movedBoard[0, 7].GetType().Name == "Rook" && movedBoard[0, 7].player == Player.Black && movedBoard[0, 7].canCastle) // Checks to see if castle move is valid
                    {
                        // Performs castle
                        movedBoard[0, 5] = movedBoard[0, 7];
                        movedBoard[0, 5].row = 0;
                        movedBoard[0, 5].column = 5;

                        movedBoard[0, 7] = new Blank(0, 7);
                    }
                }
            }

            if (selectedPiece.GetType().Name == "Pawn") // Pawn special move checks (en passant, promotion)
            {
                switch (selectedPiece.player)
                {
                    case Player.White: // White pawn checks
                        if (movedBoard[newRow, newColumn].GetType().Name == "Blank" &&
                            previousRow != newRow &&
                            previousColumn != newColumn)
                        {
                            movedBoard[newRow + 1, newColumn] = new Blank(newRow + 1, newColumn); // Performs en passant
                        }
                        else if (newRow == 0) // Pawn has reached end of board
                        {
                            if (AI) // Automatic pawn to queen promotion for computer opponent
                            {
                                currentPiece = new Queen(newRow, newColumn, Player.White);
                                movedBoard[newRow, newColumn] = currentPiece;

                                selectedPiece = new Blank(previousRow, previousColumn);
                                movedBoard[previousRow, previousColumn] = selectedPiece;

                                return movedBoard;
                            }
                            else // Show protomion form for player pawn
                            {
                                Promotion promotionForm = new Promotion();
                                promotionForm.Show();
                                promotion = true;
                            }
                        }
                        break;

                    case Player.Black: // Black pawn checks
                        if (movedBoard[newRow, newColumn].GetType().Name == "Blank" &&
                            previousRow != newRow &&
                            previousColumn != newColumn)
                        {
                            movedBoard[newRow - 1, newColumn] = new Blank(newRow - 1, newColumn); // Performs en passant
                        }
                        else if (newRow == 7) // Pawn has reached end of board
                        {
                            if (AI) // Automatic pawn to queen promotion for computer opponent
                            {
                                currentPiece = new Queen(newRow, newColumn, Player.Black);
                                movedBoard[newRow, newColumn] = currentPiece;

                                selectedPiece = new Blank(previousRow, previousColumn);
                                movedBoard[previousRow, previousColumn] = selectedPiece;

                                return movedBoard;
                            }
                            else // Show protomion form for player pawn
                            {
                                Promotion promotionForm = new Promotion();
                                promotionForm.Show();
                                promotion = true;
                            }
                        }
                        break;
                }

                // Updates objects to match pawn move
                currentPiece = selectedPiece;
                currentPiece.row = newRow;
                currentPiece.column = newColumn;
            }
            else
            {
                // Updates objects to match piece move
                currentPiece = selectedPiece;
                currentPiece.row = newRow;
                currentPiece.column = newColumn;
            }


            // Updating the moved board to reflect performed move
            movedBoard[newRow, newColumn] = currentPiece;

            selectedPiece = new Blank(previousRow, previousColumn);
            movedBoard[previousRow, previousColumn] = selectedPiece;

            return movedBoard;
        }

        public static bool IsStalemate(Piece[,] board, Player turn) // Stalemate occurs when player is not in check but has no valid moves simultaneously
        {
            if (IsCheckmate(board, turn) && !IsCheck(board, turn)) // IsCheckmate checks that no move player makes will make its king no longer vulnerable so if this is the case and the king is not in check, stalemate occurs
                return true;
            else // Alternative check for stalemate, which occurs when both players only have a king left, since checkmate can never occur
            {
                List<Piece> whitePieces = new List<Piece>();
                List<Piece> blackPieces = new List<Piece>();

                foreach (Piece piece in board)
                {
                    if (piece.player == Player.White)
                        whitePieces.Add(piece);
                    else if (piece.player == Player.Black)
                        blackPieces.Add(piece);
                }

                if (whitePieces.Count == 1 && whitePieces[0].GetType().Name == "King" && 
                    blackPieces.Count == 1 && blackPieces[0].GetType().Name == "King")
                    return true;
            }

            return false; // If neither checks return true then the game is not in stalemate
        }

        public static void ChangePlayerTurn(Play form) // Called when a new turn begins to start the timer for the next player's turn
        {
            switch (playerTurn)
            {
                case 0:
                    whiteTime += increment;
                    form.labelWhiteTimer.Text = FormatTime(whiteTime);
                    form.labelPlayerTurn.Text = "Turn: Black";
                    playerTurn++;
                    break;
                case 1:
                    blackTime += increment;
                    form.labelBlackTimer.Text = FormatTime(blackTime);
                    form.labelPlayerTurn.Text = "Turn: White";
                    playerTurn--;
                    break;
            }
        }

        public static void EndOfMoveChecks(Play form) // Called at the end of each move to check whether the game state has changed
        {
            if (IsStalemate(pieceBoard, player[playerTurn])) // If game is a stalemate, ends game and updates related user statistics
            {
                form.labelCheck.Visible = true;
                form.labelCheck.Text = "STALEMATE";
                form.labelCheck.Location = new Point(300, 974);

                form.timer.Enabled = false;
                form.labelPlayerTurn.Text = $"Turn: {player[playerTurn]}";

                List<Stats> userStats;
                UserStatistics statistics = new UserStatistics();
                userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");

                if (owner.GetType().Name == "PlayLocalSettings")
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET Draws = {userStats[0].Draws + 1} WHERE Username = '{Program.GetUsername()}'");

                if (adjournedGame)
                    Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

                MessageBox.Show("The game is a draw by stalemate!");
                form.Hide();

                return;
            }

            if (IsCheck(pieceBoard, player[playerTurn]))
            {
                form.labelCheck.Visible = true;

                if (IsCheckmate(pieceBoard, player[playerTurn])) // If game is checkmate, ends game and updates related user statistics
                {
                    form.labelCheck.Text = "CHECKMATE";
                    form.labelCheck.Location = new Point(300, 974);

                    List<Stats> userStats;
                    UserStatistics statistics = new UserStatistics();
                    userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");

                    form.timer.Enabled = false;

                    if (adjournedGame)
                        Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

                    if (owner.GetType().Name == "PlayLocalSettings")
                    {
                        switch (player[playerTurn])
                        {
                            case Player.White:
                                form.labelPlayerTurn.Text = "Turn: Black";
                                Program.database.ExecuteSql($"UPDATE UserStatistics SET BlackWins = {userStats[0].BlackWins + 1}, BlackCheckmates = {userStats[0].BlackCheckmates + 1} WHERE Username = '{Program.GetUsername()}'");

                                MessageBox.Show("Black wins by checkmate!");
                                form.Hide();
                                break;
                            case Player.Black:
                                form.labelPlayerTurn.Text = "Turn: White";
                                Program.database.ExecuteSql($"UPDATE UserStatistics SET WhiteWins = {userStats[0].WhiteWins + 1}, WhiteCheckmates = {userStats[0].WhiteCheckmates + 1} WHERE Username = '{Program.GetUsername()}'");

                                MessageBox.Show("White wins by checkmate!");
                                form.Hide();
                                break;
                        }
                    }
                    else if (owner.GetType().Name == "PlayComputerSettings")
                    {
                        switch (player[playerTurn])
                        {
                            case Player.White:
                                form.labelPlayerTurn.Text = "Turn: Black";

                                if (computerOpponent.player == Player.White)
                                {
                                    switch (computerOpponent.mode)
                                    {
                                        case Difficulty.Easy:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET EasyWins = {userStats[0].EasyWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                        case Difficulty.Medium:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET MediumWins = {userStats[0].MediumWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                        case Difficulty.Hard:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET HardWins = {userStats[0].HardWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                    }
                                    
                                    MessageBox.Show("Player wins by checkmate!");
                                }
                                else if (computerOpponent.player == Player.Black)
                                    MessageBox.Show("Computer wins by checkmate!");

                                form.Hide();
                                break;
                            case Player.Black:
                                form.labelPlayerTurn.Text = "Turn: White";

                                if (computerOpponent.player == Player.White)
                                    MessageBox.Show("Computer wins by checkmate!");
                                else if (computerOpponent.player == Player.Black)
                                {
                                    switch (computerOpponent.mode)
                                    {
                                        case Difficulty.Easy:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET EasyWins = {userStats[0].EasyWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                        case Difficulty.Medium:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET MediumWins = {userStats[0].MediumWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                        case Difficulty.Hard:
                                            Program.database.ExecuteSql($"UPDATE UserStatistics SET HardWins = {userStats[0].HardWins + 1} WHERE Username = '{Program.GetUsername()}'");
                                            break;
                                    }

                                    MessageBox.Show("Player wins by checkmate!");
                                }

                                form.Hide();
                                break;
                        }
                    }
                    
                }
            }
            else
                form.labelCheck.Visible = false; // Hides special game state text if the game is currently in a normal state
        }
 
        List<Point> currentValidMoves = new List<Point>();

        public void Gameplay(Play form) // Initialises the functionality for clicking any square on the graphics board
        {
            PictureBox selectedSquare = null;
            Piece selectedPiece = null;

            // Iterates through for every single square on the board
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    graphicsBoard[i, j].Click += (sender, e) => // Adds code to the click event for each square on the graphics board
                    {
                        if (!promotion) // Prevents player from performing any moves during a pawn promotion
                        {
                            madeMove = false; // Variable used to show computer opponent that the player is yet to make a move

                            foreach (Piece piece in pieceBoard) // Sets en passant value to false for every piece on the board since en passant is only valid for a single turn
                            {
                                if (piece.GetType().Name == "Pawn")
                                    if (piece.canEnPassant)
                                    {
                                        piece.canEnPassant = false;
                                    }
                            }

                            if (lastMove != null) // Sets en passant value to true for a pawn if the last move allows it to be valid
                                if (pieceBoard[lastMove[1].X, lastMove[1].Y].GetType().Name == "Pawn" &&
                                   (lastMove[0].X + 1 != lastMove[1].X) &&
                                   (lastMove[0].X - 1 != lastMove[1].X))
                                    pieceBoard[lastMove[1].X, lastMove[1].Y].canEnPassant = true;

                            // Gets the current picture box and related object for the square that was clicked on
                            PictureBox currentSquare = sender as PictureBox;
                            Piece currentPiece = PictureBoxToPiece(currentSquare);

                            if (selectedSquare != null) // A square is currently selected (i.e. current square is the position to which the selected piece should move)
                                selectedPiece = PictureBoxToPiece(selectedSquare);

                            int newRow = currentPiece.row;
                            int newColumn = currentPiece.column;

                            if (selectedSquare == currentSquare) // Player clicked on the same square on twice in a row so nothing changes
                            {
                                selectedSquare = currentSquare;
                            }
                            else if (selectedSquare == null && currentSquare.Image != null && currentPiece.player == player[playerTurn]) // Player has clicked on a piece that has their turn, so that piece is selected
                            {
                                selectedSquare = currentSquare;
                            }
                            else if (selectedSquare == null && currentSquare.Image != null && currentPiece.player != player[playerTurn]) // Player has clicked on a piece that does not have their turn, so nothing changes
                            {
                                //pass
                            }
                            else if (selectedSquare == null && currentSquare.Image == null) // Player clicked on a blank square with no square selected, so nothing changes
                            {
                                selectedSquare = null;
                            }
                            else if (selectedPiece.player == player[playerTurn]) // If the selected square belongs to the current player and a current piece has just been selected, then checks for moves can occur
                            {
                                if (currentPiece.GetType().Name != "Blank" && currentPiece.player == selectedPiece.player) // If current square is one of the player's pieces then this piece is selected and its move are shown
                                {
                                    ReturnToInitalColour(selectedSquare); // Selected piece is reverted back to the colour of its square
                                    selectedSquare = currentSquare;

                                    foreach (Point move in currentValidMoves) // Valid moves shown for previously selected piece are reverted back to their initial colour
                                    {
                                        ReturnToInitalColour(graphicsBoard[move.X, move.Y]);
                                    }
                                }
                                else if (currentValidMoves.Contains(new Point(newRow, newColumn))) // Checks for if the current square is a valid move (in which case this move is made for the selected piece)
                                {
                                    int previousRow = selectedPiece.row;
                                    int previousColumn = selectedPiece.column;
                                    promotion = false;

                                    Move playerMove = new Move();
                                    playerMove.previousPosition = new Point(previousRow, previousColumn);
                                    playerMove.newPosition = new Point(newRow, newColumn);

                                    pieceBoard = MakeMove(playerMove, pieceBoard);

                                    ReturnToInitalColour(selectedSquare); // Selected piece is reverted back to the colour of its square
                                    selectedSquare = null;

                                    foreach (Point m in currentValidMoves) // Valid moves shown for previously selected piece are reverted back to their initial colour
                                        ReturnToInitalColour(graphicsBoard[m.X, m.Y]);

                                    if (!promotion) // Updates the player turn if the move is not a pawn promotion (if not player turn is only promoted after the promotion has been completed)
                                        ChangePlayerTurn(form);

                                    // Updates last move to allow checks for en passant on next turn
                                    lastMove[0] = new Point(previousRow, previousColumn);
                                    lastMove[1] = new Point(newRow, newColumn);

                                    madeMove = true; // Updates made move so computer opponent knowns it is their turn to move
                                }
                            }

                            if (selectedSquare != null) // If a square is selected then the square is coloured red and the valid moves for its related moves are displayed in aqua
                            {
                                selectedSquare.BackColor = Color.Red;
                                selectedPiece = PictureBoxToPiece(selectedSquare);

                                if (IsCheck(pieceBoard, player[playerTurn]))
                                    currentValidMoves = EscapesCheck(pieceBoard, selectedPiece); // Gets valid moves which escape check
                                else
                                    currentValidMoves = EscapesCheck(pieceBoard, selectedPiece, false); // Gets any valid moves which don't put king in check/checkmate

                                foreach (Point move in currentValidMoves) // Displays valid moves on graphics board
                                    graphicsBoard[move.X, move.Y].BackColor = Color.Aqua;
                            }

                            DisplayBoard();
                            EndOfMoveChecks(form);

                            if (owner.GetType().Name == "PlayComputerSettings" && madeMove && !promotion) // Checks whether computer opponent exists and can perform move
                            {
                                // Performs minimax algorithm to find the best possible move
                                computerOpponent.Search(pieceBoard, computerOpponent.startingDepth, int.MinValue, int.MaxValue, computerOpponent.maximising);
                                Move move = computerOpponent.GetBestMove(computerOpponent.maximising);

                                // Performs all extra requirements in order to apply the found move to the current board
                                pieceBoard = MakeMove(move, pieceBoard, true);
                                UpdateIndexes(pieceBoard);
                                DisplayBoard();

                                lastMove[0] = new Point(move.previousPosition.X, move.previousPosition.Y);
                                lastMove[1] = new Point(move.newPosition.X, move.newPosition.Y);

                                ChangePlayerTurn(form);
                                EndOfMoveChecks(form);
                            }
                        }
                    };
                }
            }
        }

    }
}
