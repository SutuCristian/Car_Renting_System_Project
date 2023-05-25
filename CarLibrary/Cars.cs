using System;
using System.Collections;

namespace CarLibrary
{
    public class Cars
    {
        private const char MAIN_FILE_SEPARATOR = ';';
        private const char SECONDARY_FILE_SEPARATOR = ' ';

        private const int ID_CAR = 0;
        private const int BRAND = 1;
        private const int MODEL = 2;
        private const int YEAR = 3;
        private const int PRICE = 4;
        private const int COLOR = 5;
        private const int OPTIONS = 6;

        [Flags]
        public enum CarOptions
        {
            None = 0,
            AirConditioner = 1,
            AutomaticTransmission = 2,
            CruiseControl = 3,
            NavigationSystem = 4,
            Sunroof = 5,
            FourWheelDrive = 6
        }

        public int IdCar { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public CarColor Color { get; set; }
        public ArrayList Options { get; set; }

        public string OptionsAsString
        {
            get
            {
                string cOptions = string.Empty;

                foreach (string option in Options)
                {
                    if (cOptions != string.Empty)
                    {
                        cOptions += SECONDARY_FILE_SEPARATOR;
                    }
                    cOptions += option;
                }

                return cOptions;

            }
        }

        public Cars()
        {
            Brand = Model = string.Empty;
            Year = string.Empty;
            Price = string.Empty;
        }

        public Cars(int idCar, string brand, string model, string year, string price)
        {
            this.IdCar = idCar;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public Cars(string fileLine)
        {
            string[] fileData = fileLine.Split(MAIN_FILE_SEPARATOR);

            IdCar = Convert.ToInt32(fileData[ID_CAR]);
            Brand = fileData[BRAND];
            Model = fileData[MODEL];
            Year = fileData[YEAR];
            Price = fileData[PRICE];
            Color = (CarColor)Enum.Parse(typeof(CarColor), fileData[COLOR], true);
            Options = new ArrayList();
            Options.AddRange(fileData[OPTIONS].Split(SECONDARY_FILE_SEPARATOR));

        }

        public string InfoCar()
        {
            string info = string.Format("IdCar:{0}, Make: {1}, Model: {2}, Year: {3}, Price: {4}",
                IdCar.ToString(),
                (Brand ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                (Year ?? " UNKNOWN "),
                (Price ?? " UNKNOWN "));

            return info;
        }

        public string ConvertToString_ForFile()
        {
            string clientObjectForFile = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                MAIN_FILE_SEPARATOR,
                IdCar.ToString(),
                (Brand ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                (Year ?? " UNKNOWN "),
                (Price ?? " UNKNOWN "),
                Color.ToString(),
                OptionsAsString);

            return clientObjectForFile;
        }

        public override string ToString()
        {
            return ConvertToString_ForFile();
        }

    }



    public enum CarColor
    {
        Unknown,
        Black,
        White,
        Gray,
        Red,
        Blue,
        Green,
        Silver,
        Brown,
        Yellow
    }

}