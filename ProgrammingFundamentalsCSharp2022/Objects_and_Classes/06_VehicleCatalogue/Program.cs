using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            this.TypeOfVeichle = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }
        public string TypeOfVeichle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string capitalizedVeichleType = char.ToUpper(TypeOfVeichle.First()) + TypeOfVeichle.Substring(1).ToLower();
            return
                $"Type: {capitalizedVeichleType}" + Environment.NewLine +
                $"Model: {Model}" + Environment.NewLine +
                $"Color: {Color}" + Environment.NewLine +
                $"Horsepower: {HorsePower}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                if (tokens[0] == "End")
                {
                    break;
                }
                string typeOfVehicle = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                double horsePower = double.Parse(tokens[3]);
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                vehicles.Add(model, vehicle);
            }

            while (true)
            {
                string modelOfCar = Console.ReadLine();
                if (modelOfCar == "Close the Catalogue")
                {
                    break;
                }
                Vehicle chosenVeichle = vehicles[modelOfCar];
                Console.WriteLine(chosenVeichle.ToString());
            }
            PrintVehicleHorsepower(vehicles);
        }

        private static void PrintVehicleHorsepower(Dictionary<string, Vehicle> vehicle)
        {
            var cars = vehicle.Where(v => v.Value.TypeOfVeichle == "car");
            var trucks = vehicle.Where(v => v.Value.TypeOfVeichle == "truck");
            if (cars.Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {cars.Average(c => c.Value.HorsePower):F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (trucks.Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucks.Average(t => t.Value.HorsePower):F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
}
