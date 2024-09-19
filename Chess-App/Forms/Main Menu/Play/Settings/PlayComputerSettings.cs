using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp.Forms.Main_Menu.Play.Computer_Play
{
    public partial class PlayComputerSettings : Form
    {
        public PlayComputerSettings()
        {
            InitializeComponent();
        }

        private void hScrollBarTimer_ValueChanged(object sender, EventArgs e)
        {
            string difficultyValue = hScrollBarDifficulty.Value.ToString();

            // Displays selected difficulty based on scroll bar position
            switch (difficultyValue)
            {
                case "0":
                    labelDifficultyValue.Text = "Mode: Easy";
                    labelDifficultyValue.ForeColor = Color.LightGreen;
                    break;
                case "1":
                    labelDifficultyValue.Text = "Mode: Medium";
                    labelDifficultyValue.ForeColor = Color.Yellow;
                    break;
                default:
                    labelDifficultyValue.Text = $"Mode: Hard";
                    labelDifficultyValue.ForeColor = Color.Red;
                    break;
            }
        }

        public void buttonPlay_Click(object sender, EventArgs e) // Displays new play window for selected computer settings
        {
            ChessApp.Play playWindow = new ChessApp.Play();
            playWindow.Owner = this;
            MainMenu.OpenChildForm(playWindow);
        }

        // Only allows checking of a single checkbox at a time

        private void checkBoxWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWhite.Checked)
            {
                checkBoxBlack.Checked = false;
                checkBoxRandom.Checked = false;

                checkBoxWhite.ForeColor = SystemColors.ButtonFace;
                checkBoxBlack.ForeColor = SystemColors.ActiveBorder;
                checkBoxRandom.ForeColor = SystemColors.ActiveBorder;
            }
            else if (!checkBoxBlack.Checked && !checkBoxRandom.Checked)
                checkBoxWhite.Checked = true;
        }

        private void checkBoxBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlack.Checked)
            {
                checkBoxWhite.Checked = false;
                checkBoxRandom.Checked = false;

                checkBoxWhite.ForeColor = SystemColors.ActiveBorder;
                checkBoxBlack.ForeColor = SystemColors.ButtonFace;
                checkBoxRandom.ForeColor = SystemColors.ActiveBorder;
            }
            else if (!checkBoxWhite.Checked && !checkBoxRandom.Checked)
                checkBoxBlack.Checked = true;
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked)
            {
                checkBoxWhite.Checked = false;
                checkBoxBlack.Checked = false;

                checkBoxWhite.ForeColor = SystemColors.ActiveBorder;
                checkBoxBlack.ForeColor = SystemColors.ActiveBorder;
                checkBoxRandom.ForeColor = SystemColors.ButtonFace;
            }
            else if (!checkBoxWhite.Checked && !checkBoxBlack.Checked)
                checkBoxRandom.Checked = true;
        }

        private void PlayComputerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
