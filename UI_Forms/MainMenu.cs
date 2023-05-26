using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace UI_Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCarsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsMenu = new CarsForm();
            carsMenu.ShowDialog();
            this.Show();
        }

        private void btnClientsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsForm clientsMenu = new ClientsForm();
            clientsMenu.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginMenu = new LoginForm();
            loginMenu.ShowDialog();
            this.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
