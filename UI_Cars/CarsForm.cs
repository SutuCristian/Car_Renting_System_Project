using CarDataStorage;

using CarLibrary;

using System;
using System.Collections;
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

namespace UI_Cars
{
    public partial class CarsForm : Form
    {
        
        IDataStorageCars adminCars;

        ArrayList selectedOptions = new ArrayList();

        public CarsForm()
        {
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string CarCompleteFileLocation = Path.Combine(CarSolutionFileLocation, fileNameCar);
            adminCars = FactoryStorageCars.GetAdminStorageCar();
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars car = new Cars(0, txtCarBrand.Text, txtCarModel.Text, txtCarYear.Text, txtCarPrice.Text);

            CarColor selectedColor = GetSelectedColor();
            car.Color = selectedColor;

            car.Options = new ArrayList();
            car.Options.AddRange(selectedOptions);

            adminCars.AddCar(car);

            CarsControlReset();
        }

        private void ckbOptions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string selectedOption = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                selectedOptions.Add(selectedOption);
            else
                selectedOptions.Remove(selectedOption);

        }

        private void CarsControlReset()
        {
            txtCarBrand.Text = txtCarModel.Text = txtCarYear.Text = txtCarPrice.Text = string.Empty;

            rdbBlack.Checked = false;
            rdbBlue.Checked = false;
            rdbBrown.Checked = false;
            rdbGray.Checked = false;
            rdbGreen.Checked = false;
            rdbRed.Checked = false;
            rdbSilver.Checked = false;
            rdbWhite.Checked = false;
            rdbYellow.Checked = false;

            ckbAirConditioner.Checked = false;
            ckbAutomaticTransmission.Checked = false;
            ckbCruiseControl.Checked = false;
            ckbFourWheelDrive.Checked = false;
            ckbNavigationSystem.Checked = false;
            ckbSunroof.Checked = false;

            selectedOptions.Clear();
        }

        private CarColor GetSelectedColor()
        {
            if (rdbBlack.Checked)
                return CarColor.Black;
            if (rdbWhite.Checked)
                return CarColor.White;
            if (rdbGray.Checked)
                return CarColor.Gray;
            if (rdbBlue.Checked)
                return CarColor.Blue;
            if (rdbBrown.Checked)
                return CarColor.Brown;
            if (rdbGreen.Checked)
                return CarColor.Green;
            if (rdbYellow.Checked)
                return CarColor.Yellow;
            if (rdbRed.Checked)
                return CarColor.Red;
            if (rdbSilver.Checked)
                return CarColor.Silver;

            return CarColor.Unknown;
        }

        private void btnDisplayCar_Click(object sender, EventArgs e)
        {
            List<Cars> cars = adminCars.GetCars();
            DisplayCarsInControlDataGridView(cars);
        }

        private void DisplayCarsInControlDataGridView(List<Cars> cars)
        {
            dataGridCars.DataSource = null;

            dataGridCars.DataSource = cars;
        }

        private void dataGridCars_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dataGridCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Cars selectedCar = (Cars)dataGridCars.SelectedRows[0].DataBoundItem;
            adminCars.DeleteCars(selectedCar.IdCar);

            // Refresh the DataGridView to show the updated list of cars
            List<Cars> cars = adminCars.GetCars();
            DisplayCarsInControlDataGridView(cars);

            MessageBox.Show("Car deleted successfully.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Cars> cars = adminCars.GetCars();

            // Sort the cars based on IdCar in ascending order
            cars.Sort((car1, car2) => car1.IdCar.CompareTo(car2.IdCar));

            // Update the IdCar values sequentially starting from 1
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].IdCar = i + 1;
            }

            // Save the updated list of cars to the file
            SaveCarsToFile(cars);

            // Refresh the DataGridView to show the updated list of cars
            DisplayCarsInControlDataGridView(cars);

            MessageBox.Show("Cars refreshed successfully.");
        }

        private void SaveCarsToFile(List<Cars> cars)
        {
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string CarCompleteFileLocation = Path.Combine(CarSolutionFileLocation, fileNameCar);

            using (StreamWriter streamWriterTextFile = new StreamWriter(CarCompleteFileLocation, false))
            {
                foreach (Cars car in cars)
                {
                    streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
                }
            }
        }
    }
}
