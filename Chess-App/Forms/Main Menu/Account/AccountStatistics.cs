using ChessApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp
{
    public partial class AccountStatistics : Form
    {
        public AccountStatistics()
        {
            InitializeComponent();
        }

        private void AccountStatistics_Load(object sender, EventArgs e) // Displays recorded statistics for user account in pie charts
        {
            List<Stats> userStats;
            UserStatistics statistics = new UserStatistics();
            userStats = statistics.GetStats($"SELECT * FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");

            // Wins pie chart data
            chartWins.Titles.Add("Wins Pie Chart");
            chartWins.Series["s1"].IsValueShownAsLabel = true;

            if (userStats[0].WhiteWins != 0)
                chartWins.Series["s1"].Points.AddXY("White Wins", $"{userStats[0].WhiteWins}");
            if (userStats[0].BlackWins != 0)
                chartWins.Series["s1"].Points.AddXY("Black Wins", $"{userStats[0].BlackWins}");
            if (userStats[0].Draws != 0)
                chartWins.Series["s1"].Points.AddXY("Draws", $"{userStats[0].Draws}");

            // Game outcomes pie chart data
            chartOutcomes.Titles.Add("Game Outcomes Pie Chart");
            chartOutcomes.Series["s1"].IsValueShownAsLabel = true;

            if (userStats[0].WhiteCheckmates != 0)
                chartOutcomes.Series["s1"].Points.AddXY("White Checkmates", $"{userStats[0].WhiteCheckmates}");
            if (userStats[0].BlackCheckmates != 0)
                chartOutcomes.Series["s1"].Points.AddXY("Black Checkmates", $"{userStats[0].BlackCheckmates}");
            if (userStats[0].WhiteTimeouts != 0)
                chartOutcomes.Series["s1"].Points.AddXY("White Timeouts", $"{userStats[0].WhiteTimeouts}");
            if (userStats[0].BlackTimeouts != 0)
                chartOutcomes.Series["s1"].Points.AddXY("Black Timeouts", $"{userStats[0].BlackTimeouts}");
            if (userStats[0].WhiteResigns != 0)
                chartOutcomes.Series["s1"].Points.AddXY("White Resigns", $"{userStats[0].WhiteResigns}");
            if (userStats[0].BlackResigns != 0)
                chartOutcomes.Series["s1"].Points.AddXY("Black Resigns", $"{userStats[0].BlackResigns}");

            // Wins against computer opponent pie chart data
            chartComputerWins.Titles.Add("Wins Against Computer Opponent Pie Chart");
            chartComputerWins.Series["s1"].IsValueShownAsLabel = true;

            if (userStats[0].EasyWins != 0)
                chartComputerWins.Series["s1"].Points.AddXY("Easy Wins", $"{userStats[0].EasyWins}");
            if (userStats[0].MediumWins != 0)
                chartComputerWins.Series["s1"].Points.AddXY("Medium Wins", $"{userStats[0].MediumWins}");
            if (userStats[0].HardWins != 0)
                chartComputerWins.Series["s1"].Points.AddXY("Hard Wins", $"{userStats[0].HardWins}");
        }
    }
}
