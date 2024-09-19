using ChessApp.Database;
using ChessApp.Forms.Main_Menu.Play.Computer_Play;
using ChessApp.Forms.Main_Menu.Play.Local_Play;
using ChessApp.Pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChessApp
{
    public partial class Play : Form
    {
        public string puzzleBoard = null;
        public string compressedStringBoard = null;
        public int difficulty = -1;
        public int whiteTime = -1;
        public int blackTime = -1;
        public int increment = -1;
        public int turn = -1;
        public bool adjournedGame = false;

        public Play()
        {
            InitializeComponent();
        }

        public Play(string pb, int t) // Constructor for puzzle board
        {
            puzzleBoard = pb;
            turn = t;

            InitializeComponent();
        }

        public Play(string csb, int d, int wt, int bt, int inc, int t, bool adjourned = false) // Constructor for normal or adjourned boards
        {
            compressedStringBoard = csb;
            difficulty = d;
            whiteTime = wt;
            blackTime = bt;
            increment = inc;
            turn = t;
            adjournedGame = adjourned;

            InitializeComponent();
        }

        private void PlayLocal_Load(object sender, EventArgs e)
        {
            if (compressedStringBoard == null && puzzleBoard == null) // Check for whether the game is normal
            {
                Char[,] defaultStartingBoard = new Char[,]
                {
                    { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' },
                    { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                    { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }
                };

                if (this.Owner.GetType().Name == "PlayLocalSettings") // Check for whether the game is normal local play
                {
                    // Enables the timer if it has been set
                    if (PlayLocalSettings.hScrollBarTimer.Value != 0)
                    {
                        timer.Enabled = true;
                        timer.Interval = 1000;
                    }

                    labelDifficulty.Visible = false;
                    labelUser.Visible = false;
                    labelAI.Visible = false;
                }
                else // Occurs if the game is normal computer play
                {
                    timer.Enabled = false;
                    buttonDraw.Visible = false;
                    labelPlayerTurn.Visible = false;
                    buttonAdjourn.Location = new Point(983, 406);
                    buttonResign.Location = new Point(983, 506);

                    // Sets the computer difficulty based on the previously selected value
                    if (PlayComputerSettings.hScrollBarDifficulty.Value == 0)
                    {
                        labelDifficulty.Text = "Easy";
                        labelDifficulty.ForeColor = Color.LightGreen;
                    }
                    else if (PlayComputerSettings.hScrollBarDifficulty.Value == 1)
                    {
                        labelDifficulty.Text = "Medium";
                        labelDifficulty.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        labelDifficulty.Text = "Hard";
                        labelDifficulty.ForeColor = Color.Red;
                    }

                    // Sets the starting player based on the previously selected value
                    if (PlayComputerSettings.checkBoxWhite.Checked)
                    {
                        labelUser.Text = "User: White";
                        labelAI.Text = "AI: Black";
                    }
                    else if (PlayComputerSettings.checkBoxBlack.Checked)
                    {
                        labelUser.Text = "User: Black";
                        labelAI.Text = "AI: White";
                    }
                    else
                    {
                        Random rand = new Random();

                        switch (rand.Next(0, 2))
                        {
                            case 0:
                                labelUser.Text = "User: White";
                                labelAI.Text = "AI: Black";
                                break;
                            case 1:
                                labelUser.Text = "User: Black";
                                labelAI.Text = "AI: White";
                                break;
                        }
                    }
                }

                Board chessBoard = new Board(this, this.Owner, defaultStartingBoard); // Creates the board defined
            }
            else
            {
                string stringBoard = "";

                if (puzzleBoard == null) // Checks if adjourned board is being used
                {
                    // Converts compressed adjourned board back to normal from run length encoding
                    for (int i = 0; i < compressedStringBoard.Length; i++)
                    {
                        if (Char.IsDigit(compressedStringBoard[i]) && (i == 0 || !Char.IsDigit(compressedStringBoard[i - 1])))
                        {
                            if (Char.IsDigit(compressedStringBoard[i + 1]))
                            {
                                string stringDigits = $"{compressedStringBoard[i]}{compressedStringBoard[i + 1]}";
                                int digit = int.Parse(stringDigits);

                                for (int j = 0; j < digit; j++)
                                    stringBoard += compressedStringBoard[i + 2];
                            }
                            else
                            {
                                int digit = compressedStringBoard[i] - '0';

                                for (int j = 0; j < digit; j++)
                                    stringBoard += compressedStringBoard[i + 1];
                            }
                        }
                    }
                }
                else
                    stringBoard = puzzleBoard;
                    

                Char[,] startingBoard = new Char[,] // Defines the starting board for a puzzle or adjourned game
                {
                    { stringBoard[0], stringBoard[1], stringBoard[2], stringBoard[3], stringBoard[4], stringBoard[5], stringBoard[6], stringBoard[7] },
                    { stringBoard[8], stringBoard[9], stringBoard[10], stringBoard[11], stringBoard[12], stringBoard[13], stringBoard[14], stringBoard[15] },
                    { stringBoard[16], stringBoard[17], stringBoard[18], stringBoard[19], stringBoard[20], stringBoard[21], stringBoard[22], stringBoard[23] },
                    { stringBoard[24], stringBoard[25], stringBoard[26], stringBoard[27], stringBoard[28], stringBoard[29], stringBoard[30], stringBoard[31] },
                    { stringBoard[32], stringBoard[33], stringBoard[34], stringBoard[35], stringBoard[36], stringBoard[37], stringBoard[38], stringBoard[39] },
                    { stringBoard[40], stringBoard[41], stringBoard[42], stringBoard[43], stringBoard[44], stringBoard[45], stringBoard[46], stringBoard[47] },
                    { stringBoard[48], stringBoard[49], stringBoard[50], stringBoard[51], stringBoard[52], stringBoard[53], stringBoard[54], stringBoard[55] },
                    { stringBoard[56], stringBoard[57], stringBoard[58], stringBoard[59], stringBoard[60], stringBoard[61], stringBoard[62], stringBoard[63] },
                };

                if (this.Owner.GetType().Name == "PlayLocalSettings") // Check whether the game is local play
                {
                    // Enables the timer if it has been set
                    if (whiteTime != 0)
                    {
                        timer.Enabled = true;
                        timer.Interval = 1000;
                    }

                    labelDifficulty.Visible = false;
                    labelUser.Visible = false;
                    labelAI.Visible = false;
                }
                else // Occurs when the game is versus a computer
                {
                    timer.Enabled = false;
                    buttonDraw.Visible = false;
                    labelPlayerTurn.Visible = false;
                    buttonAdjourn.Location = new Point(983, 406);
                    buttonResign.Location = new Point(983, 506);

                    // Sets the computer difficulty based on the previously selected value
                    if (difficulty == 0)
                    {
                        labelDifficulty.Text = "Easy";
                        labelDifficulty.ForeColor = Color.LightGreen;
                    }
                    else if (difficulty == 1)
                    {
                        labelDifficulty.Text = "Medium";
                        labelDifficulty.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        labelDifficulty.Text = "Hard";
                        labelDifficulty.ForeColor = Color.Red;
                    }

                    // Sets the starting player based on the previously selected value
                    if (turn == 0)
                    {
                        labelUser.Text = "User: White";
                        labelAI.Text = "AI: Black";
                    }
                    else if (turn == 1)
                    {
                        labelUser.Text = "User: Black";
                        labelAI.Text = "AI: White";
                    }
                }

                Board chessBoard;
                if (puzzleBoard == null) // Creates board for adjourned game
                    chessBoard = new Board(this, this.Owner, startingBoard, turn, whiteTime, blackTime, increment, adjournedGame);
                else // Creates board for puzzle game
                    chessBoard = new Board(this, this.Owner, startingBoard, turn);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Updates timer text after each tick
            labelWhiteTimer.Text = Board.FormatTime(Board.whiteTime);
            labelBlackTimer.Text = Board.FormatTime(Board.blackTime);
            labelPlayerTurn.Text = $"Turn: {Board.player[Board.playerTurn]}";
            
            if (Board.player[Board.playerTurn] == Player.White)
            {
                // Decrements white time during their turn
                Board.whiteTime--;
                labelWhiteTimer.Text = Board.FormatTime(Board.whiteTime);

                if (Board.whiteTime == 0) // Checks for game over by timeout and updates relevant stats
                {
                    timer.Enabled = false;

                    List<Stats> userStats;
                    UserStatistics statistics = new UserStatistics();
                    userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET BlackWins = {userStats[0].BlackWins + 1}, BlackTimeouts = {userStats[0].BlackWins + 1} WHERE Username = '{Program.GetUsername()}'");

                    MessageBox.Show("Black wins by timeout!");
                    this.Hide();
                }
            }
            else
            {
                // Decrements black time during their turn
                Board.blackTime--;
                labelBlackTimer.Text = Board.FormatTime(Board.blackTime);

                if (Board.blackTime == 0)  // Checks for game over by timeout and updates relevant stats
                {
                    timer.Enabled = false;

                    List<Stats> userStats;
                    UserStatistics statistics = new UserStatistics();
                    userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET WhiteWins = {userStats[0].WhiteWins + 1}, WhiteTimeouts = {userStats[0].WhiteTimeouts + 1} WHERE Username = '{Program.GetUsername()}'");

                    MessageBox.Show("White wins by timeout!");
                    this.Hide();
                }
            }
        }

        private void buttonAdjourn_Click(object sender, EventArgs e)
        {
            timer.Enabled = false; // Stops timer during confirmation for adjourning the game

            DialogResult result = MessageBox.Show("Are you sure you would like to adjourn this game? Any game that is already adjourned will be replaced with this game.", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string stringBoard = "";
                string compressedStringBoard = "";

                // Converts current object board into a string board using FEN Notation 
                foreach (Piece piece in Board.pieceBoard)
                {
                    switch (piece.GetType().Name)
                    {
                        case "Pawn":
                            if (piece.player == Player.White)
                                stringBoard += "P";
                            else
                                stringBoard += "p";
                            break;
                        case "Bishop":
                            if (piece.player == Player.White)
                                stringBoard += "B";
                            else
                                stringBoard += "b";
                            break;
                        case "Knight":
                            if (piece.player == Player.White)
                                stringBoard += "N";
                            else
                                stringBoard += "n";
                            break;
                        case "Rook":
                            if (piece.player == Player.White)
                                stringBoard += "R";
                            else
                                stringBoard += "r";
                            break;
                        case "Queen":
                            if (piece.player == Player.White)
                                stringBoard += "Q";
                            else
                                stringBoard += "q";
                            break;
                        case "King":
                            if (piece.player == Player.White)
                                stringBoard += "K";
                            else
                                stringBoard += "k";
                            break;
                        default:
                            stringBoard += " ";
                            break;
                    }
                }

                // Converts string board to a compressed string board using run length encoding
                int count = 1;
                for (int i = 0; i < stringBoard.Length; i++)
                {
                    if (i == stringBoard.Length - 1)
                    {
                        if (stringBoard[i] == stringBoard[i - 1])
                            compressedStringBoard += $"{count + 1}{stringBoard[i - 1]}";
                        else
                        {
                            compressedStringBoard += $"{count}{stringBoard[i - 1]}";
                            compressedStringBoard += $"1{stringBoard[i]}";
                        }
                    }
                    else if (i != 0)
                    {
                        if (stringBoard[i] == stringBoard[i - 1])
                            count++;
                        else
                        {
                            compressedStringBoard += $"{count}{stringBoard[i - 1]}";
                            count = 1;
                        }
                    }
                }

                int turn = 0;
                switch (Board.player[Board.playerTurn])
                {
                    case Player.White:
                        turn = 0;
                        break;
                    case Player.Black:
                        turn = 1;
                        break;
                }

                // Deletes saved adjourned game to allow for current game to be adjourned
                Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");
                
                // Updates relevant adjourned game data to reflect data from the current saved game and inserts this into the adjourned database
                if (this.Owner.GetType().Name == "PlayLocalSettings")
                {
                    if (labelWhiteTimer.Visible)
                        Program.database.ExecuteSql($"INSERT INTO Adjourned VALUES('{Program.GetUsername()}', '{compressedStringBoard}', -1, {Board.whiteTime}, {Board.blackTime}, {Board.increment}, {turn})");
                    else
                        Program.database.ExecuteSql($"INSERT INTO Adjourned VALUES('{Program.GetUsername()}', '{compressedStringBoard}', -1, -1, -1, 0, {turn})");
                }
                else if (this.Owner.GetType().Name == "PlayComputerSettings")
                {
                    int difficulty = 0;
                    switch (labelDifficulty.Text)
                    {
                        case "Easy":
                            difficulty = 0;
                            break;
                        case "Medium":
                            difficulty = 1;
                            break;
                        case "Hard":
                            difficulty = 2;
                            break;
                    }

                    Program.database.ExecuteSql($"INSERT INTO Adjourned VALUES('{Program.GetUsername()}', '{compressedStringBoard}', {difficulty}, -1, -1, -1, {turn})");
                }

                MessageBox.Show("This game has been adjourned.");
                this.Hide();
            }
            else
                timer.Enabled = true; // Resumes timer if game is not adjourned
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            timer.Enabled = false; // Stops timer during confirmation for draw

            DialogResult result = MessageBox.Show("Are you sure you would like to agree to a draw?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Updates relevant user statistics and ends the game
                List<Stats> userStats;
                UserStatistics statistics = new UserStatistics();
                userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");
                Program.database.ExecuteSql($"UPDATE UserStatistics SET Draws = {userStats[0].Draws + 1} WHERE Username = '{Program.GetUsername()}'");

                if (Board.adjournedGame)
                    Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

                MessageBox.Show("The game is a draw by agreement.");
                this.Hide();
            }
            else
                timer.Enabled = true; // Resumes timer if game is not drawed
        }
        
        private void buttonResign_Click(object sender, EventArgs e)
        {
            timer.Enabled = false; // Stop timer during confirmation for resignation

            string winner = null;
            DialogResult result = MessageBox.Show("Are you sure you would like to resign?", "", MessageBoxButtons.YesNo);

            switch (Board.player[Board.playerTurn])
            {
                case Player.White:
                    winner = "Black";
                    break;
                case Player.Black:
                    winner = "White";
                    break;
            }

            if (result == DialogResult.Yes)
            {
                // Updates relevant user statistics and ends the game
                List<Stats> userStats;
                UserStatistics statistics = new UserStatistics();
                userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");

                if (Board.adjournedGame)
                    Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

                if (winner == "Black")
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET BlackWins = {userStats[0].BlackWins + 1}, WhiteResigns = {userStats[0].WhiteResigns + 1} WHERE Username = '{Program.GetUsername()}'");
                else
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET WhiteWins = {userStats[0].WhiteWins + 1}, BlackResigns = {userStats[0].BlackResigns + 1} WHERE Username = '{Program.GetUsername()}'");

                MessageBox.Show($"{winner} wins by resignation.");
                this.Hide();
            }
            else
                timer.Enabled = true; // Resumes timer if game is not resigned
        }
    }
}
