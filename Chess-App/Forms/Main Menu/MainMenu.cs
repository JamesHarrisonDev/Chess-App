using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessApp.Forms.Main_Menu;
using ChessApp.Forms.Main_Menu.Play.Local_Play;
using ChessApp.Forms.Main_Menu.Play.Computer_Play;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using ChessApp.Pieces;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ChessApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CustomiseDesign();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string username;

            using (StreamReader reader = new StreamReader(Program.UsernameFilePath))
                username = reader.ReadLine();

            // Displays username associated with account in top left corner of main menu screen
            labelUsername.Text = username;
            labelUsername.Left = (panelUser.Size.Width / 2) - (labelUsername.Size.Width / 2);
        }

        private void CustomiseDesign()
        {
            panelAccountSubmenu.Visible = false;
            panelPlaySubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu) // Displays submenu for selected category in side bar and hides all other submenus
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void HideSubmenu() // Hides any opened submenus in the sidebar
        {
            if (panelAccountSubmenu.Visible == true)
                panelAccountSubmenu.Visible = false;
            if (panelPlaySubmenu.Visible == true)
                panelPlaySubmenu.Visible = false;
        }

        public static Form activeForm = null;

        public static void OpenChildForm(Form childForm) // Opens any given form as a child within the bounds of the main menu form
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //-----Account-Submenu-----
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelAccountSubmenu);
        }

        private void buttonAccountStatistics_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new AccountStatistics());
        }

        private void buttonAccountSettings_Click(object sender, EventArgs e)
        {
            HideSubmenu();

            AccountSettings accountSettingsWindow = new AccountSettings();
            accountSettingsWindow.Owner = this;
            OpenChildForm(accountSettingsWindow);
        }



        //-----Play-Submenu-----
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelPlaySubmenu);
        }

        private void buttonPlayLocal_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new PlayLocalSettings());
        }

        private void buttonPlayComputer_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new PlayComputerSettings());
        }



        //-----Puzzles-----
        public static List<int> usedIndexes = new List<int>();

        private void buttonPuzzles_Click(object sender, EventArgs e) // Generates puzzle
        {
            Player[] player = new Player[] { Player.White, Player.Black };
            Random rand = new Random();

            string puzzleBoard;
            int turn;

            do
            {
                usedIndexes.Clear();

                puzzleBoard = ""; // Starts with empty board
                turn = rand.Next(2); // Generates random turn
                Char[] pieces = new Char[] { 'p', 'p', 'p', 'p', 'p', 'p', 'b', 'b', 'n', 'n', 'r', 'r', 'q', 'P', 'P', 'P', 'P', 'P', 'P', 'B', 'B', 'N', 'N', 'R', 'R', 'Q', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }; // Defines probability distribution for pieces in puzzle board
                Char[] listPuzzleBoard = new Char[64];

                // Begins by adding a king for both players to the board in order to make the game valid
                listPuzzleBoard[GetRandInt()] = 'k'; 
                listPuzzleBoard[GetRandInt()] = 'K';

                for (int i = 0; i < rand.Next(5, 25); i++) // Defines the amount of pieces that will be added to the puzzle board
                {
                    int randInt = GetRandInt();
                    char randPiece = pieces[rand.Next(pieces.Length)];

                    if ((randPiece == 'p' || randPiece == 'P') && (randInt < 8 || randInt > 55)) // Prevents pawns from being added to the final rows as these are impossible positions
                        continue;
                    else
                        listPuzzleBoard[randInt] = randPiece;
                }

                foreach (Char character in listPuzzleBoard)
                    puzzleBoard += character; // Creates string board from character board

                Char[,] charPuzzleBoard = new Char[,] // Defines the character array puzzle board from the string puzzle board
                {
                    { puzzleBoard[0], puzzleBoard[1], puzzleBoard[2], puzzleBoard[3], puzzleBoard[4], puzzleBoard[5], puzzleBoard[6], puzzleBoard[7] },
                    { puzzleBoard[8], puzzleBoard[9], puzzleBoard[10], puzzleBoard[11], puzzleBoard[12], puzzleBoard[13], puzzleBoard[14], puzzleBoard[15] },
                    { puzzleBoard[16], puzzleBoard[17], puzzleBoard[18], puzzleBoard[19], puzzleBoard[20], puzzleBoard[21], puzzleBoard[22], puzzleBoard[23] },
                    { puzzleBoard[24], puzzleBoard[25], puzzleBoard[26], puzzleBoard[27], puzzleBoard[28], puzzleBoard[29], puzzleBoard[30], puzzleBoard[31] },
                    { puzzleBoard[32], puzzleBoard[33], puzzleBoard[34], puzzleBoard[35], puzzleBoard[36], puzzleBoard[37], puzzleBoard[38], puzzleBoard[39] },
                    { puzzleBoard[40], puzzleBoard[41], puzzleBoard[42], puzzleBoard[43], puzzleBoard[44], puzzleBoard[45], puzzleBoard[46], puzzleBoard[47] },
                    { puzzleBoard[48], puzzleBoard[49], puzzleBoard[50], puzzleBoard[51], puzzleBoard[52], puzzleBoard[53], puzzleBoard[54], puzzleBoard[55] },
                    { puzzleBoard[56], puzzleBoard[57], puzzleBoard[58], puzzleBoard[59], puzzleBoard[60], puzzleBoard[61], puzzleBoard[62], puzzleBoard[63] },
                };

                // Creates an object/piece board from the character array puzzle board using FEN Notation
                for (int row = 0; row < Board.boardSize; row++)
                {
                    for (int column = 0; column < Board.boardSize; column++)
                    {
                        switch (charPuzzleBoard[row, column])
                        {
                            case 'P':
                                Board.pieceBoard[row, column] = new Pawn(row, column, Player.White);
                                break;
                            case 'B':
                                Board.pieceBoard[row, column] = new Bishop(row, column, Player.White);
                                break;
                            case 'N':
                                Board.pieceBoard[row, column] = new Knight(row, column, Player.White);
                                break;
                            case 'R':
                                Board.pieceBoard[row, column] = new Rook(row, column, Player.White);
                                break;
                            case 'Q':
                                Board.pieceBoard[row, column] = new Queen(row, column, Player.White);
                                break;
                            case 'K':
                                Board.pieceBoard[row, column] = new King(row, column, Player.White);
                                break;
                            case 'p':
                                Board.pieceBoard[row, column] = new Pawn(row, column, Player.Black);
                                break;
                            case 'b':
                                Board.pieceBoard[row, column] = new Bishop(row, column, Player.Black);
                                break;
                            case 'n':
                                Board.pieceBoard[row, column] = new Knight(row, column, Player.Black);
                                break;
                            case 'r':
                                Board.pieceBoard[row, column] = new Rook(row, column, Player.Black);
                                break;
                            case 'q':
                                Board.pieceBoard[row, column] = new Queen(row, column, Player.Black);
                                break;
                            case 'k':
                                Board.pieceBoard[row, column] = new King(row, column, Player.Black);
                                break;
                            default:
                                Board.pieceBoard[row, column] = new Blank(row, column);
                                break;
                        }
                    }
                }
            
            // Verifys the board is valid (i.e. it is not in checkmate or stalemate, both players have a king on the board and the second player does not begin in checkmate) and iterates through until a valid puzzle is created)
            } while (Board.IsCheckmate(Board.pieceBoard, player[turn]) || Board.IsStalemate(Board.pieceBoard, player[turn]) || Board.IsKingVulnerable(Board.pieceBoard, player[turn]) || !puzzleBoard.Contains('k') || !puzzleBoard.Contains('K'));

            // Initialises new play window from created puzzle board
            Play playWindow = new Play(puzzleBoard, turn);
            playWindow.Owner = new PlayLocalSettings();
            OpenChildForm(playWindow);
        }
        public int GetRandInt() // Returns integer/index which has not already been used in the puzzle board (in order to prevent overwriting pieces)
        {
            Random rand = new Random();
            int randInt;

            do
            {
                randInt = rand.Next(64);
            } while (usedIndexes.Contains(randInt));

            usedIndexes.Append(randInt);
            return randInt;
        }



        //-----Adjourned-----
        private void buttonAdjourned_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OpenChildForm(new AdjournedSettings());
        }



        //-----Button-Colour-Change-----
        private void buttonAccount_MouseHover(object sender, EventArgs e)
        {
            buttonAccount.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void buttonAccount_MouseLeave(object sender, EventArgs e)
        {
            buttonAccount.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void buttonPlay_MouseHover(object sender, EventArgs e)
        {
            buttonPlay.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void buttonPuzzles_MouseHover(object sender, EventArgs e)
        {
            buttonPuzzles.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void buttonPuzzles_MouseLeave(object sender, EventArgs e)
        {
            buttonPuzzles.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void buttonAdjourned_MouseHover(object sender, EventArgs e)
        {
            buttonAdjourned.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void buttonAdjourned_MouseLeave(object sender, EventArgs e)
        {
            buttonAdjourned.BackColor = Color.FromArgb(11, 7, 17);
        }
    }
}
