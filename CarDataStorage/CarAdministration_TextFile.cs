using CarLibrary;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarDataStorage
{
    public class CarAdministration_TextFile : IDataStorageCars
    {
        private const int FIRST_CAR_ID = 1;
        private const int INCREMENT_CAR = 1;

        private string fileNameCar;

        public CarAdministration_TextFile(string fileName)
        {
            this.fileNameCar = fileName;
            Stream streamTextFile = File.Open(fileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public void AddCar(Cars car)
        {
            car.IdCar = GetIdCar();

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, true))
            {
                streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
            }
        }

        public List<Cars> GetCars()
        {
            List<Cars> cars = new List<Cars>();

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    cars.Add(car);
                }
            }

            return cars;
        }

        public Cars GetCar(string brand, string model)
        {
            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    if (car.Brand.Equals(brand) && car.Model.Equals(model))
                        return car;
                }
            }

            return null;
        }

        public Cars GetCar(int idCar)
        {
            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    if (car.IdCar == idCar)
                        return car;
                }
            }

            return null;
        }

        private int GetIdCar()
        {
            int IdCar = FIRST_CAR_ID;

            using (StreamReader streamReader = new StreamReader(fileNameCar))
            {
                string fileLine;

                while ((fileLine = streamReader.ReadLine()) != null)
                {
                    Cars car = new Cars(fileLine);
                    IdCar = car.IdCar + INCREMENT_CAR;
                }
            }

            return IdCar;
        }

        public bool UpdateCar(Cars updatedCar)
        {
            List<Cars> cars = GetCars();
            bool successfullyUpdated = false;

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, false))
            {
                foreach (Cars car in cars)
                {
                    if (car.IdCar == updatedCar.IdCar)
                    {
                        streamWriterTextFile.WriteLine(updatedCar.ConvertToString_ForFile());
                        successfullyUpdated = true;
                    }
                    else
                    {
                        streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
                    }
                }
            }

            return successfullyUpdated;
        }

        public bool DeleteCars(int idCar)
        {
            List<Cars> cars = GetCars();
            bool successfullyDeleted = false;

            using (StreamWriter streamWriterTextFile = new StreamWriter(fileNameCar, false))
            {
                foreach (Cars car in cars)
                {
                    if (car.IdCar != idCar)
                    {
                        streamWriterTextFile.WriteLine(car.ConvertToString_ForFile());
                    }
                    else
                    {
                        successfullyDeleted = true;
                    }
                }
            }

            return successfullyDeleted;
        }
    }
}