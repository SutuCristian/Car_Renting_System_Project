using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using CarLibrary;
using System.IO;

namespace CarDataStorage
{
    public class CarAdministration_BinaryFile : IDataStorageCars
    {

        private const int FIRST_CAR_ID = 1;
        private const int INCREMENT_CAR = 1;

        string FileName { get; set; }

        public CarAdministration_BinaryFile(string fileName)
        {
            this.FileName = fileName;
            Stream carBinFile = File.Open(FileName, FileMode.OpenOrCreate);
            carBinFile.Close();
        }

        public void AddCar(Cars carr)
        {
            carr.IdCar = GetIdCar();

            try
            {
                BinaryFormatter b_car = new BinaryFormatter();

                using (Stream carBinFile = File.Open(FileName, FileMode.Append, FileAccess.Write))
                {
                    b_car.Serialize(carBinFile, carr);
                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }

        }

        public List<Cars> GetCars()
        {
            List<Cars> cars = new List<Cars>();
            try
            {
                BinaryFormatter b_car = new BinaryFormatter();
                using (Stream carBinFile = File.Open(FileName, FileMode.Open))
                {
                    int currentId = FIRST_CAR_ID;
                    while (carBinFile.Position < carBinFile.Length)
                    {
                        Cars car = (Cars)b_car.Deserialize(carBinFile);
                        car.IdCar = currentId;
                        cars.Add(car);
                        currentId += INCREMENT_CAR;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
            return cars;
        }

        public Cars GetCar(int idCar)
        {
            try
            {
                List<Cars> cars = GetCars();
                return cars.FirstOrDefault(car => car.IdCar == idCar);
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        public Cars GetCar(string make, string model)
        {
            try
            {
                List<Cars> cars = GetCars();
                return cars.FirstOrDefault(car => car.Brand == make && car.Model == model);
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        public bool UpdateCar(Cars carr)
        {
            try
            {
                List<Cars> cars = GetCars();
                int index = cars.FindIndex(car => car.IdCar == carr.IdCar);

                if (index != -1)
                {
                    cars[index] = carr;
                    SaveCarsToFile(cars);
                    return true;
                }

                return false;
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        public bool DeleteCars(int idCar)
        {
            try
            {
                List<Cars> cars = GetCars();
                int index = cars.FindIndex(car => car.IdCar == idCar);

                if (index != -1)
                {
                    cars.RemoveAt(index);
                    SaveCarsToFile(cars);
                    return true;
                }

                return false;
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        private void SaveCarsToFile(List<Cars> cars)
        {
            try
            {
                using (Stream carBinFile = File.Open(FileName, FileMode.Create))
                {
                    BinaryFormatter b_car = new BinaryFormatter();

                    foreach (Cars car in cars)
                    {
                        b_car.Serialize(carBinFile, car);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
        }

        private int GetIdCar()
        {
            int IdCar = FIRST_CAR_ID;
            try
            {

                using (Stream carBinFile = File.Open(FileName, FileMode.Open))
                {
                    BinaryFormatter b_car = new BinaryFormatter();

                    while (carBinFile.Position < carBinFile.Length)
                    {
                        Cars carr = (Cars)b_car.Deserialize(carBinFile);
                        IdCar = carr.IdCar + INCREMENT_CAR;
                    }

                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Error at file opening. Message: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generic error. Message: " + eGen.Message);
            }
            return IdCar;
        }

    }
}
