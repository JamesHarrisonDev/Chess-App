using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChessApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (username == "") // No username entered
            {
                MessageBox.Show("Please fill in the username field before attempting to create an account.");
            }
            else if (password == "") // No password entered
            {
                MessageBox.Show("Please fill in the password field before attempting to create an account.");
            }
            else if (confirmPassword == "") // No confirm password entered
            {
                MessageBox.Show("Please fill in the confirm password field before attempting to create an account.");
            }
            else if (password != confirmPassword) // Passwords entered do not match
            {
                MessageBox.Show("Passwords do not match. Please make sure you enter the same password into both the password and confirm password fields.");
            }
            else if (!Program.ValidUsername(username)) // Username entered already has an associated account
            {
                MessageBox.Show("An account already exists with this username. If this is you, please log in. If not, enter a different username.");
            }
            else
            {
                // Creates account with the given username and password
                Program.database.ExecuteSql($"INSERT INTO Users VALUES('{username}', '{password}')");
                Program.database.ExecuteSql($"INSERT INTO UserStatistics VALUES('{username}', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)");

                using (StreamWriter writer = new StreamWriter(Program.UsernameFilePath))
                    writer.Write(username);

                // Displays main menu
                MainMenu mainMenuWindow = new MainMenu();
                mainMenuWindow.Show();
                this.Hide();
            }


        }

        private void buttonLogIn_Click(object sender, EventArgs e) // Displays the log in form
        {
            LogIn logInWindow = new LogIn();
            logInWindow.Show();
            this.Hide();
        }
    }
}
