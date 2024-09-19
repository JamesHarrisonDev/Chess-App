using ChessApp.Forms.Main_Menu.Play.Gameplay;
using ChessApp.Pieces;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public enum Difficulty // Possible difficulties of the computer opponent (corresponding to the depth searched by the minimax algorithm)
    {
        Easy,
        Medium,
        Hard
    }
    internal class Minimax
    {
        public Difficulty mode;
        public Player player;

        public bool maximising;
        public int startingDepth;
        private List<Move> validMoves = new List<Move>();

        // Piece scores used in evaluation function
        private const int pawnValue = 100;
        private const int knightValue = 320;
        private const int bishopValue = 330;
        private const int rookValue = 500;
        private const int queenValue = 900;
        private const int kingValue = 20000;

        // Piece position scores used in evaluation function (below they show white to move but the arrays are flipped for AI playing as black)
        private static readonly int[,] bestPawnPositions = {
              { 0,  0,  0,  0,  0,  0,  0,  0 },
              { 50, 50, 50, 50, 50, 50, 50, 50 },
              { 10, 10, 20, 30, 30, 20, 10, 10 },
              { 5,  5, 10, 25, 25, 10,  5,  5 },
              { 0,  0,  0, 20, 20,  0,  0,  0 },
              { 5, -5,-10,  0,  0,-10, -5,  5 },
              { 5, 10, 10,-20,-20, 10, 10,  5 },
              { 0,  0,  0,  0,  0,  0,  0,  0 }
        };

        private static readonly int[,] bestKnightPositions = {
              { -50,-40,-30,-30,-30,-30,-40,-50 },
              { -40,-20,  0,  0,  0,  0,-20,-40 },
              { -30,  0, 10, 15, 15, 10,  0,-30 },
              { -30,  5, 15, 20, 20, 15,  5,-30 },
              { -30,  0, 15, 20, 20, 15,  0,-30 },
              { -30,  5, 10, 15, 15, 10,  5,-30 },
              { -40,-20,  0,  5,  5,  0,-20,-40 },
              { -50,-40,-30,-30,-30,-30,-40,-50 }
        };

        private static readonly int[,] bestBishopPositions = {
              { -20,-10,-10,-10,-10,-10,-10,-20 },
              { -10,  0,  0,  0,  0,  0,  0,-10 },
              { -10,  0,  5, 10, 10,  5,  0,-10 },
              { -10,  5,  5, 10, 10,  5,  5,-10 },
              { -10,  0, 10, 10, 10, 10,  0,-10 },
              { -10, 10, 10, 10, 10, 10, 10,-10 },
              { -10,  5,  0,  0,  0,  0,  5,-10 },
              { -20,-10,-10,-10,-10,-10,-10,-20 }
        };

        private static readonly int[,] bestRookPositions = {
              { 0,  0,  0,  0,  0,  0,  0,  0 },
              { 5, 10, 10, 10, 10, 10, 10,  5 },
              { -5,  0,  0,  0,  0,  0,  0, -5 },
              { -5,  0,  0,  0,  0,  0,  0, -5 },
              { -5,  0,  0,  0,  0,  0,  0, -5 },
              { -5,  0,  0,  0,  0,  0,  0, -5 },
              { -5,  0,  0,  0,  0,  0,  0, -5 },
              { 0,  0,  0,  5,  5,  0,  0,  0 }
        };

        private static readonly int[,] bestQueenPositions = {
              { -20,-10,-10, -5, -5,-10,-10,-20 },
              { -10,  0,  0,  0,  0,  0,  0,-10 },
              { -10,  0,  5,  5,  5,  5,  0,-10 },
              { -5,  0,  5,  5,  5,  5,  0, -5 },
              { 0,  0,  5,  5,  5,  5,  0, -5 },
              { -10,  5,  5,  5,  5,  5,  0,-10 },
              { -10,  0,  5,  0,  0,  0,  0,-10 },
              { -20,-10,-10, -5, -5,-10,-10,-20 }
        };

        private static readonly int[,] bestKingPositions = {
              { -30,-40,-40,-50,-50,-40,-40,-30 },
              { -30,-40,-40,-50,-50,-40,-40,-30 },
              { -30,-40,-40,-50,-50,-40,-40,-30 },
              { -30,-40,-40,-50,-50,-40,-40,-30 },
              { -20,-30,-30,-40,-40,-30,-30,-20 },
              { -10,-20,-20,-20,-20,-20,-20,-10 },
              { 20, 20,  0,  0,  0,  0, 20, 20 },
              { 20, 30, 10,  0,  0, 10, 30, 20 }
        };

        private static readonly int[,] bestKingEndGamePositions =
        {
              { -50,-40,-30,-20,-20,-30,-40,-50 },
              { -30,-20,-10,  0,  0,-10,-20,-30 },
              { -30,-10, 20, 30, 30, 20,-10,-30 },
              { -30,-10, 30, 40, 40, 30,-10,-30 },
              { -30,-10, 30, 40, 40, 30,-10,-30 },
              { -30,-10, 20, 30, 30, 20,-10,-30 },
              { -30,-30,  0,  0,  0,  0,-30,-30 },
              { -50,-30,-30,-30,-30,-30,-30,-50 }
        };

        public Minimax(Difficulty difficulty, Player pieceColour)
        {
            mode = difficulty;
            player = pieceColour;

            switch (difficulty) // Defines the depth searched by the algorithm based on the selected difficulty
            {
                case Difficulty.Easy:
                    startingDepth = 1;
                    break;
                case Difficulty.Medium:
                    startingDepth = 2;
                    break;
                case Difficulty.Hard:
                    startingDepth = 3;
                    break;
            }

            switch (pieceColour) // Defines whether the algorithm is maximising the evaluation or minimising it (based on whether it plays white or black)
            {
                case Player.White:
                    maximising = true;
                    break;
                case Player.Black:
                    maximising = false;
                    break;
            }
        }

        public int[,] FlipPositions(int[,] positions) // Flips the piece position score arrays in the scenario that the AI plays as black
        {
            int[,] flippedPositions = new int[Board.boardSize, Board.boardSize];

            for (int i = 0; i < Board.boardSize; i++)
                for (int j = 0; j < Board.boardSize; j++)
                    flippedPositions[i, j] = positions[Board.boardSize - 1 - i, Board.boardSize - 1 - j];

            return flippedPositions;
        }

        public bool IsEndgame(Piece[,] board) // Checks whether the board is in an endgame scenario in order to determine whether or not the king endgame positions board should be used for evaluation
        {
            bool whiteQueen = false;
            bool blackQueen = false;
            bool whiteLowPieces = false;
            bool blackLowPieces = false;
            List<Piece> whitePieces = new List<Piece>();
            List<Piece> blackPieces = new List<Piece>();

            foreach (Piece piece in board)
            {
                if (piece.GetType().Name == "Queen" && piece.player == Player.White)
                {
                    whiteQueen = true;
                    continue;
                }
                else if (piece.GetType().Name == "Queen" && piece.player == Player.Black)
                {
                    blackQueen = true;
                    continue;
                }

                if (piece.player == Player.White)
                    whitePieces.Add(piece);
                else if (piece.player == Player.Black)
                    blackPieces.Add(piece);
            }

            if (!whiteQueen && whitePieces.Count <= 2)
                foreach (Piece piece in whitePieces)
                {
                    if (piece.GetType().Name == "Pawn" || piece.GetType().Name == "Knight" || piece.GetType().Name == "Bishop")
                        whiteLowPieces = true;
                    else
                    {
                        whiteLowPieces = false;
                        break;
                    }
                } 

            if (!blackQueen && blackPieces.Count <= 2)
                foreach (Piece piece in blackPieces)
                {
                    if (piece.GetType().Name == "Pawn" || piece.GetType().Name == "Knight" || piece.GetType().Name == "Bishop")
                        blackLowPieces = true;
                    else
                    {
                        blackLowPieces = false;
                        break;
                    }
                }

            // Endgame scenario defined as when each player either no longer has a queen or each player has a queen but no more than 2 extra low-level pieces (pawn, knight or bishop)
            if ((!whiteQueen && !blackQueen) || (whiteLowPieces && !blackQueen) ||
                (!whiteQueen && blackLowPieces) || (whiteLowPieces && blackLowPieces))
                return true;

            return false;
        }

        public List<Move> GetAllLegalMoves(Piece[,] board, Player turn)
        {
            List<Point> moves = new List<Point>();
            List<Move> legalMoves = new List<Move>();

            // Iterates through each move for every piece of the current player in the current board and adds any valid move to a list of legal moves
            foreach (Piece piece in board)
            {
                if (piece.player == turn)
                {
                    if (Board.IsCheck(board, turn))
                        moves = Board.EscapesCheck(board, piece);
                    else
                        moves = Board.EscapesCheck(board, piece, false);

                    foreach (Point move in moves)
                    {
                        Move fullMove = new Move();
                        fullMove.previousPosition = new Point(piece.row, piece.column);
                        fullMove.newPosition = new Point(move.X, move.Y);
                        legalMoves.Add(fullMove);
                    }
                }
            }

            return legalMoves;
        }

        public int Search(Piece[,] board, int depth, int alpha, int beta, bool maximisingPlayer) // Minimax search algorithm
        {
            // Base case defined as when the algorithm has fully searched the branch for the provided depth or the game is completed for the defined board
            if (depth == 0 || Board.IsStalemate(board, Player.White) || Board.IsStalemate(board, Player.Black) || Board.IsCheckmate(board, Player.White) || Board.IsCheckmate(board, Player.Black))
                return Evaluate(board); // Returns evaluation of the current board

            if (maximisingPlayer) // Current player is using white
            {
                int maxEval = int.MinValue;
                List<Move> possibleMoves = GetAllLegalMoves(board, Player.White);

                foreach (Move currentMove in possibleMoves) // Evaluates the possibilities stemming from each legal move in the current position to the depth defined
                {
                    // Performs each move on a clone board of the current one
                    Piece[,] newBoard = Board.MakeMove(currentMove, board, true);
                    Board.UpdateIndexes(board);

                    int eval = Search(newBoard, depth - 1, alpha, beta, false); // Evaluates the possibilities stemming from the current move being performed

                    maxEval = Math.Max(maxEval, eval);
                    alpha = Math.Max(alpha, eval);

                    if (depth == startingDepth) // Current move in first iteration assigned best evaluation from daughter moves
                    {
                        currentMove.score = eval;
                        validMoves.Add(currentMove);
                    }

                    if (beta <= alpha) // Alpha beta pruning used to prune branches where it can already be shown that no move will be selected
                        break;
                }

                return maxEval; // Best possible evaluation for current player is returned
            }
            else // Current player is using black
            {
                int minEval = int.MaxValue;
                List<Move> possibleMoves = GetAllLegalMoves(board, Player.Black);

                foreach (Move currentMove in possibleMoves) // Evaluates the possibilities stemming from each legal move in the current position to the depth defined
                {
                    // Performs each move on a clone board of the current one
                    Piece[,] newBoard = Board.MakeMove(currentMove, board, true);
                    Board.UpdateIndexes(board);

                    int eval = Search(newBoard, depth - 1, alpha, beta, true); // Evaluates the possibilities stemming from the current move being performed

                    minEval = Math.Min(minEval, eval);
                    beta = Math.Min(beta, eval);

                    if (depth == startingDepth) // Current move in first iteration assigned best evaluation from daughter moves
                    {
                        currentMove.score = eval;
                        validMoves.Add(currentMove);
                    }

                    if (beta <= alpha) // Alpha beta pruning used to prune branches where it can already be shown that no move will be selected
                        break;
                }

                return minEval; // Best possible evaluation for current player is returned
            }
        }

        public Move GetBestMove(bool maximisingPlayer)
        {
            Move bestMove;
            List<Move> bestMoves = new List<Move>();

            // Locates move(s) which correspond to the highest recorded board evaluation during the minimax search
            if (maximisingPlayer)
            {
                bestMove = new Move(int.MinValue);

                foreach (Move move in validMoves)
                {
                    if (move.score > bestMove.score)
                    {
                        bestMove = move;
                        bestMoves.Clear();
                        bestMoves.Add(move);
                    }
                    else if (move.score == bestMove.score)
                        bestMoves.Add(move);
                }
            }
            else
            {
                bestMove = new Move(int.MaxValue);

                foreach (Move move in validMoves)
                {
                    if (move.score < bestMove.score)
                    {
                        bestMove = move;
                        bestMoves.Clear();
                        bestMoves.Add(move);
                    }
                    else if (move.score == bestMove.score)
                        bestMoves.Add(move);
                }
            }

            validMoves.Clear();

            Random rand = new Random();

            if (bestMoves.Count > 0)
                return bestMoves[rand.Next(bestMoves.Count)]; // Randomly selects good move if multiple moves share the best evaluation score
            else
                return new Move(0);
        }

        private int Evaluate(Piece[,] board) // Assigns a score to the board state passed in
        {
            int evaluation = 0;
            bool endgame = IsEndgame(board);

            for (int i = 0; i < Board.boardSize; i++)
            {
                for (int j = 0; j < Board.boardSize; j++)
                {
                    if (board[i, j].player == Player.White) // White pieces increase the evaluation
                    {
                        switch (board[i, j].GetType().Name)
                        {
                            case "Pawn":
                                evaluation += (pawnValue + bestPawnPositions[i, j]);
                                break;
                            case "Bishop":
                                evaluation += (bishopValue + bestBishopPositions[i, j]);
                                break;
                            case "Knight":
                                evaluation += (knightValue + bestKnightPositions[i, j]);
                                break;
                            case "Rook":
                                evaluation += (rookValue + bestRookPositions[i, j]);
                                break;
                            case "Queen":
                                evaluation += (queenValue + bestQueenPositions[i, j]);
                                break;
                            case "King":
                                if (endgame)
                                    evaluation += (kingValue + bestKingEndGamePositions[i, j]);
                                else
                                    evaluation += (kingValue + bestKingPositions[i, j]);
                                break;
                        }
                    }
                    else if (board[i, j].player == Player.Black) // Black pieces decrease the evaluation
                    {
                        switch (board[i, j].GetType().Name)
                        {
                            case "Pawn":
                                evaluation -= (pawnValue + FlipPositions(bestPawnPositions)[i, j]);
                                break;
                            case "Bishop":
                                evaluation -= (bishopValue + FlipPositions(bestBishopPositions)[i, j]);
                                break;
                            case "Knight":
                                evaluation -= (knightValue + FlipPositions(bestKnightPositions)[i, j]);
                                break;
                            case "Rook":
                                evaluation -= (rookValue + FlipPositions(bestRookPositions)[i, j]);
                                break;
                            case "Queen":
                                evaluation -= (queenValue + FlipPositions(bestQueenPositions)[i, j]);
                                break;
                            case "King":
                                if (endgame)
                                    evaluation -= (kingValue + FlipPositions(bestKingEndGamePositions)[i, j]);
                                else
                                    evaluation -= (kingValue + FlipPositions(bestKingPositions)[i, j]);
                                break;
                        }
                    }
                }
            }

            return evaluation;
        }
    }
}
