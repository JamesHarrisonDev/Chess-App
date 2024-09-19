using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp.Forms.Main_Menu.Play.Local_Play
{
    public partial class PlayLocalSettings : Form
    {
        public PlayLocalSettings()
        {
            InitializeComponent();
        }

        private void hScrollBarTimer_ValueChanged(object sender, EventArgs e)
        {
            string timerValue = hScrollBarTimer.Value.ToString();

            // Displays selected timer based on scroll bar position
            switch (timerValue)
            {
                case "0":
                    labelTimerValue.Text = "Value: Off";
                    labelIncrementValue.Text = "Value: Off";
                    hScrollBarIncrement.Enabled = false;
                    hScrollBarIncrement.Value = 0;
                    break;
                case "1":
                    labelTimerValue.Text = "Value: 1 minute";
                    hScrollBarIncrement.Enabled = true;
                    break;
                default:
                    labelTimerValue.Text = $"Value: {timerValue} minutes";
                    hScrollBarIncrement.Enabled = true;
                    break;
            }
        }

        private void hScrollBarIncrement_ValueChanged(object sender, EventArgs e)
        {
            string incrementValue = hScrollBarIncrement.Value.ToString();

            // Displays selected increment based on scroll bar position
            switch (incrementValue)
            {
                case "0":
                    labelIncrementValue.Text = "Value: Off";
                    break;
                case "1":
                    labelIncrementValue.Text = "Value: 1 second";
                    break;
                default:
                    labelIncrementValue.Text = $"Value: {incrementValue} seconds";
                    break;
            }
        }

        public void buttonPlay_Click(object sender, EventArgs e) // Displays new play window for selected local play settings
        {
            ChessApp.Play playWindow = new ChessApp.Play();
            playWindow.Owner = this;
            MainMenu.OpenChildForm(playWindow);
        }

        private void PlayLocalSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
