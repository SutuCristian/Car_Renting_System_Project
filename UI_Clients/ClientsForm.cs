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

using UI_Forms;

namespace UI_Clients
{
    public partial class ClientsForm : Form
    {
        IDataStorageClients adminClients;

        private Label lblFirstName;
        private Label[] lblsFirstName;

        private Label lblLastName;
        private Label[] lblsLastName;

        private Label lblEmail;
        private Label[] lblsEmail;

        private Label lblPhone_Number;
        private Label[] lblsPhone_Number;

        private const int WIDTH_CONTROL = 100;
        private const int DIMENSION_PAS_Y = 30;
        private const int DIMENSION_PAS_X = 120;
        private const int OFFSET_X = 600;

        private int nextClientId;

        public ClientsForm()
        {
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = Path.Combine(ClientsSolutionFileLocation, fileName);
            adminClients = FactoryStorageClients.GetAdminStorage();

            // Read the NextClientId from the file and set it
            nextClientId = ReadNextClientIdFromFile(ClientsCompleteFileLocation);

            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            List<Clients> clients = adminClients.GetClients();
            DisplayClients(clients);
        }

        private void DisplayClients(List<Clients> clients)
        {
            //add label for 'FirstName'
            lblFirstName = new Label();
            lblFirstName.Width = WIDTH_CONTROL;
            lblFirstName.Text = "First Name";
            lblFirstName.Left = 6 * DIMENSION_PAS_X;
            lblFirstName.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblFirstName);

            //add label for 'LastName'
            lblLastName = new Label();
            lblLastName.Width = WIDTH_CONTROL;
            lblLastName.Text = "Last Name";
            lblLastName.Left = 7 * DIMENSION_PAS_X;
            lblLastName.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblLastName);

            //add label for 'Email'
            lblEmail = new Label();
            lblEmail.Width = WIDTH_CONTROL;
            lblEmail.Text = "Email";
            lblEmail.Left = 8 * DIMENSION_PAS_X;
            lblEmail.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblEmail);

            //add label for 'Phone_number'
            lblPhone_Number = new Label();
            lblPhone_Number.Width = WIDTH_CONTROL;
            lblPhone_Number.Text = "Phone Number";
            lblPhone_Number.Left = 10 * DIMENSION_PAS_X;
            lblPhone_Number.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblPhone_Number);

            int nrClients = clients.Count;
            lblsFirstName = new Label[nrClients];
            lblsLastName = new Label[nrClients];
            lblsEmail = new Label[nrClients];
            lblsPhone_Number = new Label[nrClients];

            int i = 0;
            foreach (Clients client in clients)
            {
                //add Label for Client's first name
                lblsFirstName[i] = new Label();
                lblsFirstName[i].Width = WIDTH_CONTROL;
                lblsFirstName[i].Text = client.First_name;
                lblsFirstName[i].Left = OFFSET_X + DIMENSION_PAS_X;
                lblsFirstName[i].Top = (i + 2) * DIMENSION_PAS_Y;
                this.Controls.Add(lblsFirstName[i]);

                //add Label for Client's last name
                lblsLastName[i] = new Label();
                lblsLastName[i].Width = WIDTH_CONTROL;
                lblsLastName[i].Text = client.Last_name;
                lblsLastName[i].Left = OFFSET_X + 2 * DIMENSION_PAS_X;
                lblsLastName[i].Top = (i + 2) * DIMENSION_PAS_Y;
                this.Controls.Add(lblsLastName[i]);

                //add Label for Client's email
                lblsEmail[i] = new Label();
                lblsEmail[i].Width = 2 * WIDTH_CONTROL;
                lblsEmail[i].Text = client.Email_address;
                lblsEmail[i].Left = OFFSET_X + 3 * DIMENSION_PAS_X;
                lblsEmail[i].Top = (i + 2) * DIMENSION_PAS_Y;
                this.Controls.Add(lblsEmail[i]);

                //add Label for Client's phone number
                lblsPhone_Number[i] = new Label();
                lblsPhone_Number[i].Width = WIDTH_CONTROL;
                lblsPhone_Number[i].Text = client.Phone_number;
                lblsPhone_Number[i].Left = OFFSET_X + 5 * DIMENSION_PAS_X;
                lblsPhone_Number[i].Top = (i + 2) * DIMENSION_PAS_Y;
                this.Controls.Add(lblsPhone_Number[i]);

                i++;
            }
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
            List<Clients> clients = adminClients.GetClients();

            // Sort the clients based on IdClient in ascending order
            clients.Sort((client1, client2) => client1.IdClient.CompareTo(client2.IdClient));

            // Update the IdClient values sequentially starting from 1
            int nextClientId = 1;
            foreach (Clients client in clients)
            {
                client.IdClient = nextClientId;
                nextClientId++;
            }

            // Save the updated list of clients to the file
            SaveClientsToFile(clients);

            // Refresh the labels to show the updated list of clients
            DisplayClientsInControlDataGridView(clients);

            MessageBox.Show("Clients refreshed successfully.");
        }

        private void SaveClientsToFile(List<Clients> clients)
        {
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = Path.Combine(ClientsSolutionFileLocation, fileName);

            using (StreamWriter streamWriterTextFile = new StreamWriter(ClientsCompleteFileLocation, false))
            {
                foreach (Clients client in clients)
                {
                    streamWriterTextFile.WriteLine(client.ConvertToString_ForFile());
                }

                // Update the file with the new IDs
                streamWriterTextFile.WriteLine($"NextClientId={clients.Count + 1}");
            }
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

        private int ReadNextClientIdFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.StartsWith("NextClientId="))
                        {
                            string nextClientIdString = line.Substring("NextClientId=".Length);
                            if (int.TryParse(nextClientIdString, out int nextClientId))
                            {
                                return nextClientId;
                            }
                        }
                    }
                }
            }

            return 1; // Default value if the file doesn't exist or the parsing fails
        }
    }
}
