using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            string username;

            using (StreamReader reader = new StreamReader(Program.UsernameFilePath))
                username = reader.ReadLine();

            textBoxUsername.Text = username;

            buttonSave.Hide();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e) // Checks that updated username can be used
        {
            string newUsername = textBoxUsername.Text;

            if (newUsername != Program.GetUsername())
            {
                if (newUsername == "") // Empty username is reverted back to original
                {
                    textBoxUsername.Text = Program.GetUsername();
                }
                else if (Program.ValidUsername(newUsername)) // Checks username is valid (i.e. not already used by another account)
                {
                    // Updates account username
                    (this.Owner as MainMenu)!.labelUsername.Text = newUsername;
                    (this.Owner as MainMenu)!.labelUsername.Left = ((this.Owner as MainMenu)!.panelUser.Size.Width / 2) - ((this.Owner as MainMenu)!.labelUsername.Size.Width / 2);

                    Program.database.ExecuteSql($"UPDATE Users SET Username = '{newUsername}' WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"UPDATE Adjourned SET Username = '{newUsername}' WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"UPDATE UserStatistics SET Username = '{newUsername}' WHERE Username = '{Program.GetUsername()}'");
                    Program.ChangeUsername(newUsername);

                    MessageBox.Show($"Your username has been updated to \"{newUsername}\".");
                }
                else // Occurs if username is invalid and has already been used
                {
                    MessageBox.Show($"Your username could not be changed to \"{newUsername}\", as a player with this username already exists.");
                    textBoxUsername.Text = Program.GetUsername();
                }
            }

            buttonSave.Hide();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e) // Displays password change form
        {
            PasswordChange passwordChangeWindow = new PasswordChange();
            passwordChangeWindow.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e) // Displays log in form
        {
            this.Hide();
            (this.Owner as MainMenu)!.Hide();

            LogIn logInWindow = new LogIn();
            logInWindow.Show();
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e) // Displays delete account form
        {
            DeleteAccount deleteAccountWindow = new DeleteAccount();
            deleteAccountWindow.Show();
        }
    }
}
