using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI_Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Perform login validation
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string credentialsFilePath = ConfigurationManager.AppSettings["UserCredentialsFilePath"];

            // Read the credentials file
            string[] lines = File.ReadAllLines(credentialsFilePath);

            foreach (string line in lines)
            {
                string[] credentials = line.Split(':');
                string storedUsername = credentials[0].Trim();
                string storedPassword = credentials[1].Trim();

                // Compare the provided username and password with the stored credentials
                if (storedUsername == username && storedPassword == password)
                {
                    // Username and password match, login is successful
                    return true;
                }
            }

            // Username or password is incorrect, login is unsuccessful
            return false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm signMenu = new SigninForm();
            signMenu.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
