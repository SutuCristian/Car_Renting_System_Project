using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();

            // Wire up the event handler for the Sign In button
            btnSignInUser.Click += btnSignInUser_Click;
        }

        private void btnSignInUser_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Create a new line in the file with the username and password
            string filePath = ConfigurationManager.AppSettings["UserCredentialsFilePath"];
            string loginData = $"{username}:{password}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(loginData);
                }

                MessageBox.Show("Sign In successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnBackClientMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginMenu = new LoginForm();
            loginMenu.ShowDialog();
            this.Show();
        }
    }
}
