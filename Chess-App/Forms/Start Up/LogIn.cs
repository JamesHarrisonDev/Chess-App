using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessApp.Database;
using static System.Net.Mime.MediaTypeNames;

namespace ChessApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "") // No username entered
            {
                MessageBox.Show("Please fill in the username field before attempting to log in.");
                return;
            }
            else if (password == "") // No password entered
            {
                MessageBox.Show("Please fill in the password field before attempting to log in.");
                return;
            }

            Users users = new Users();
            List<User> usersList = users.GetUsers("SELECT * FROM Users");

            // Iterates through every user to see if there is a valid match
            foreach (User user in usersList)
            {
                if (username == user.Username && password == user.Password)
                {
                    Program.ChangeUsername(username);

                    MainMenu mainMenuWindow = new MainMenu();
                    mainMenuWindow.Show();
                    this.Hide();

                    return;
                }
            }

            MessageBox.Show("Username or password is invalid!");
        }

        private void buttonRegister_Click(object sender, EventArgs e) // Displays the account creation form
        {
            Register registerWindow = new Register();
            registerWindow.Show();
            this.Hide();
        }
    }
}
