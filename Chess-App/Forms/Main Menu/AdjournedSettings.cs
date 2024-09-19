using ChessApp.Database;
using ChessApp.Forms.Main_Menu.Play.Computer_Play;
using ChessApp.Forms.Main_Menu.Play.Gameplay;
using ChessApp.Forms.Main_Menu.Play.Local_Play;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp.Forms.Main_Menu
{
    public partial class AdjournedSettings : Form
    {
        public AdjournedSettings()
        {
            InitializeComponent();
        }

        private void UpdateAdjournedSettings()
        {
            List<StoredBoard> adjournedBoard;
            Adjourned adjourned = new Adjourned();
            adjournedBoard = adjourned.GetStoredBoard($"SELECT * FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

            if (adjournedBoard.Count == 0) // No board adjourned for the current account
            {
                labelNoAdjourned.Visible = true; // No adjourned board message displayed
                labelAdjournedSettings.Visible = false;
                labelSettings.Visible = false;
                buttonPlay.Visible = false;
                buttonDelete.Visible = false;
            }
            else // Board adjourned for the current account
            {
                // Statistics/data for adjourned board displayed to the user
                string playerTurn = null;
                string computerTurn = null;
                switch (adjournedBoard[0].Turn)
                {
                    case 0:
                        playerTurn = "White";
                        computerTurn = "Black";
                        break;
                    case 1:
                        playerTurn = "Black";
                        computerTurn = "White";
                        break;
                }

                if (adjournedBoard[0].Difficulty == -1) // Adjourned board is not a computer game
                {
                    string whiteTime = null;
                    string blackTime = null;
                    string increment = null;
                    if (adjournedBoard[0].WhiteTime == -1) // Timers are off
                    {
                        whiteTime = "Off";
                        blackTime = "Off";
                        increment = "Off";
                    }
                    else
                    {
                        whiteTime = Board.FormatTime(adjournedBoard[0].WhiteTime);
                        blackTime = Board.FormatTime(adjournedBoard[0].BlackTime);

                        if (adjournedBoard[0].Increment == 0)
                            increment = "Off";
                        else
                            increment = $"{adjournedBoard[0].Increment.ToString()}s";
                    }

                    labelSettings.Text = $"Game Type: Local Play\nWhite Time: {whiteTime}\nBlack Time: {blackTime}\nIncrement: {increment}\nTurn: {playerTurn}";
                }
                else // Adjourned board is a computer game
                {
                    string mode = null;
                    switch (adjournedBoard[0].Difficulty) // Retrieves difficulty of computer game
                    {
                        case 0:
                            mode = "Easy";
                            break;
                        case 1:
                            mode = "Medium";
                            break;
                        case 2:
                            mode = "Hard";
                            break;
                    }

                    labelSettings.Text = $"Game Type: Computer Play\nDifficulty: {mode}\nUser: {playerTurn}\n AI: {computerTurn}";
                    labelSettings.Location = new Point(260, 215);
                }
            }
        }

        private void AdjournedSettings_Load(object sender, EventArgs e)
        {
            UpdateAdjournedSettings();
        }

        private void buttonPlay_Click(object sender, EventArgs e) // Loads in adjourned board
        {
            List<StoredBoard> adjournedBoard;
            Adjourned adjourned = new Adjourned();
            adjournedBoard = adjourned.GetStoredBoard($"SELECT * FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

            // Creates new play window with saved settings
            ChessApp.Play playWindow = new ChessApp.Play(adjournedBoard[0].BoardState, adjournedBoard[0].Difficulty, adjournedBoard[0].WhiteTime, adjournedBoard[0].BlackTime, adjournedBoard[0].Increment, adjournedBoard[0].Turn, true);

            if (adjournedBoard[0].Difficulty == -1)
                playWindow.Owner = new PlayLocalSettings();
            else
                playWindow.Owner = new PlayComputerSettings();

            MainMenu.OpenChildForm(playWindow);
        }

        private void buttonDelete_Click(object sender, EventArgs e) // Deletes adjourned board from account
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to delete this adjourned board?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'"); // Adjourned board removed from database
                MessageBox.Show("The adjourned board is no longer being stored.");
                UpdateAdjournedSettings();
            }
        }
    }
}
