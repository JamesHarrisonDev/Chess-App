using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessApp.Database;

namespace ChessApp
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string currentPassword = textBoxCurrentPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmNewPassword = textBoxConfirmNewPassword.Text;

            if (currentPassword == "" || newPassword == "" || confirmNewPassword == "") // One of the fields left empty
            {
                MessageBox.Show("Please fill in all required fields before attempting to update your password.");
                return;
            }
            else if (newPassword != confirmNewPassword) // new passsword and confirm new password do not match
            {
                MessageBox.Show("Passwords do not match. Please make sure you enter the same password into both the new password and confirm new password fields.");
                return;
            }
            else if (currentPassword == newPassword) // user attempting to change to the same password
            {
                MessageBox.Show("If you wish to change your password, please enter a different password to your existing one.");
                return;
            }

            Users users = new Users();
            List<User> usersList = users.GetUsers("SELECT * FROM Users");

            foreach (User user in usersList)
            {
                if (user.Username == Program.GetUsername() && user.Password == currentPassword)
                {
                    this.Hide();
                    Program.database.ExecuteSql($"UPDATE Users SET Password = '{newPassword}' WHERE Username = '{Program.GetUsername()}'");
                    MessageBox.Show("Your password has been updated.");

                    return;
                }
            }

            MessageBox.Show("The current password you entered is invalid for your account!"); // No password match found for given username
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
