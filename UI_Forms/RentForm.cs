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
        public RentForm()
        {
            InitializeComponent();
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

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the file name from the configuration
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];

            // Get the parent directory of the solution directory
            string CarSolutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            // Combine the solution directory with the file name
            string CarCompleteFilePath = Path.Combine(CarSolutionDirectory, fileNameCar);

            // Check if the file exists at the specified path
            if (File.Exists(CarCompleteFilePath))
            {
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                string availability = cmbAvailability.SelectedItem?.ToString();
                bool isAvailable = availability == "Available";

                List<Cars> carsList = ReadCarsFromFile(CarCompleteFilePath);

                // Filter the cars based on the search criteria
                List<Cars> searchResults = carsList
                    .Where(car =>
                        car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)
                        && car.Model.Equals(model, StringComparison.OrdinalIgnoreCase)
                        && car.IsAvailable == isAvailable)
                    .ToList();

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
            else
            {
                // Clear the DataGridView
                dataGridAvailableCars.Rows.Clear();

                // Display an error message to the user
                MessageBox.Show("The file does not exist. Please make sure the file is available at the correct location.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        public List<Cars> ReadCarsFromFile(string filePath)
        {
            List<Cars> carsList = new List<Cars>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Cars car = new Cars(line);
                carsList.Add(car);
            }

            return carsList;
        }

    }
}
