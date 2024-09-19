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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;

            if (password == "") // No password entered
            {
                MessageBox.Show("Please fill in the password field before attempting to delete your account.");
                return;
            }

            Users users = new Users();
            List<User> usersList = users.GetUsers("SELECT * FROM Users");

            // Removes user with given username from all databases and then exits the application
            foreach (User user in usersList)
            {
                if (user.Username == Program.GetUsername() && user.Password == password)
                {
                    Program.database.ExecuteSql($"DELETE FROM Users WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"DELETE FROM UserStatistics WHERE Username = '{Program.GetUsername()}'");
                    Program.database.ExecuteSql($"DELETE FROM Adjourned WHERE Username = '{Program.GetUsername()}'");

                    this.Hide();
                    Environment.Exit(0);
                }
            }

            MessageBox.Show("Incorrect password entered!"); // No password match found for given username
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
