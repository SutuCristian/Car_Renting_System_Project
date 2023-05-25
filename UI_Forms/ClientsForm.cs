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
            Clients c = new Clients(0, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text);

            adminClients.AddClient(c);

            //reset controls to add a new client
            ClientsControlReset();
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
    }
}
