using CarDataStorage;

using CarLibrary;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Forms
{
    public partial class RentForm : Form
    {
        IDataStorageCars adminCars;
        public RentForm()
        {
            InitializeComponent();

            // Retrieve the file name from the configuration
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];

            // Get the parent directory of the solution directory
            string carSolutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            // Combine the solution directory with the file name
            string carCompleteFilePath = Path.Combine(carSolutionDirectory, fileNameCar);

            adminCars = FactoryStorageCars.GetAdminStorageCar();

            // Add columns to the DataGridView
            dataGridAvailableCars.Columns.Add("IdCar", "ID");
            dataGridAvailableCars.Columns.Add("Brand", "Brand");
            dataGridAvailableCars.Columns.Add("Model", "Model");
            dataGridAvailableCars.Columns.Add("Year", "Year");
            dataGridAvailableCars.Columns.Add("Price", "Price");
            dataGridAvailableCars.Columns.Add("Color", "Color");
            dataGridAvailableCars.Columns.Add("Options", "Options");
            dataGridAvailableCars.Columns.Add("IsAvailable", "Availability");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackCarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Show();
        }

        // Search button
        private void button1_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string availability = cmbAvailability.SelectedItem?.ToString();
            bool isAvailable = availability == "Available";

            List<Cars> searchResults = adminCars.SearchCars( isAvailable );

            // Display the search results in the DataGridView
            dataGridAvailableCars.Rows.Clear();

            foreach (Cars car in searchResults)
            {
                string[] row = {
                    car.IdCar.ToString(),
                    car.Brand,
                    car.Model,
                    car.Year,
                    car.Price,
                    car.Color.ToString(),
                    car.OptionsAsString,
                    car.IsAvailable.ToString()
                };

                dataGridAvailableCars.Rows.Add(row);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
