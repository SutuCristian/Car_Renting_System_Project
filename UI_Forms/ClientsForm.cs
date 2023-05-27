using CarLibrary;

using ClientDataStorage;

using ClientLibrary;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class ClientsForm : Form
    {
        IDataStorageClients adminClients;

        public ClientsForm()
        {
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = Path.Combine(ClientsSolutionFileLocation, fileName);
            adminClients = FactoryStorageClients.GetAdminStorage();

            InitializeComponent();
        }


        private void ClientsControlReset()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtPhoneNumber.Text = string.Empty;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            // Validate input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter all client details.");
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Validate phone number length
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a 10-digit phone number.");
                return;
            }

            Clients c = new Clients(0, firstName, lastName, email, phoneNumber);

            adminClients.AddClient(c);

            // Reset controls to add a new client
            ClientsControlReset();
        }

        private bool IsValidEmail(string email)
        {
            // Use a regular expression pattern to validate the email format
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void btnDisplayClient_Click(object sender, EventArgs e)
        {
            List<Clients> clients = adminClients.GetClients();
            DisplayClientsInControlDataGridView(clients);
        }

        private void DisplayClientsInControlDataGridView(List<Clients> clients)
        {
            dataGridClients.DataSource = null;
            dataGridClients.DataSource = clients;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }


        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Clients selectedClient = (Clients)dataGridClients.SelectedRows[0].DataBoundItem;
            adminClients.DeleteClients(selectedClient.IdClient);

            // Refresh the DataGridView to show the updated list of clients
            List<Clients> clients = adminClients.GetClients();
            DisplayClientsInControlDataGridView(clients);

            MessageBox.Show("Client deleted successfully.");
        }

        private void btnBackClientMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
