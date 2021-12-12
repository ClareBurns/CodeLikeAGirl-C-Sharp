using System;
using System.Collections.Generic;
using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveInstructions();

            Console.ReadKey();

            while (true)
            {
                var vehicles = FindNearbyCars();

                var i = 1;
                foreach (var vehicle in vehicles)
                {
                    Console.Write($"\tOption {i}: ");
                    vehicle.ReportDistance();
                    i++;
                }

                var didChooseVehicle = ChooseVehicle(vehicles);

                if (didChooseVehicle)
                {
                    break;
                }
            }
        }

        static void GiveInstructions()
        {
            Console.WriteLine("Welcome to our RideShare App!");
            Console.WriteLine("Press any key to see the cars in your local vicinity");
        }


        static List<Vehicle> FindNearbyCars()
        {
            var randomNumberGenerator = new Random();

            var listOfVehicleTypes = new List<Vehicle>
            {
                new Car(),
                new Luxury_Car(),
                new Extra_Large_Car(),
                new Car(),
                new Luxury_Car(),
                new Extra_Large_Car(),
            };

            var vehicle1 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            listOfVehicleTypes.Remove(vehicle1);
            var vehicle2 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            listOfVehicleTypes.Remove(vehicle2);
            var vehicle3 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            listOfVehicleTypes.Remove(vehicle3);
            var vehicle4 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            listOfVehicleTypes.Remove(vehicle4);

            //only vehicles within a 5 km range
            vehicle1.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 1);
            vehicle2.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 1);
            vehicle3.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 1);
            vehicle4.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 1);

            var vehicles = new List<Vehicle> { vehicle1, vehicle2, vehicle3, vehicle4 };

            return vehicles;
        }

        static Boolean ChooseVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Which vehicle would you like to choose?");
            Console.WriteLine("\tType '1' for Option 1");
            Console.WriteLine("\tType '2' for Option 2");
            Console.WriteLine("\tType '3' for Option 3");
            Console.WriteLine("\tType '4' for Option 4");
            Console.WriteLine("\tType '5' to re-search for vehicles");
            Console.WriteLine("\tType 'x' to exit the program");
            var option = Console.ReadLine().Trim().ToLower().Replace("'", "");
            Boolean didChooseVehicle = true;

            switch (option)
            {
                case "1":
                    Console.WriteLine($"Your vehicle is {vehicles[0].DistanceAwayInKm}km away. Safe riding!");
                    break;
                case "2":
                    Console.WriteLine($"Your vehicle is {vehicles[1].DistanceAwayInKm}km away. Safe riding!");
                    break;
                case "3":
                    Console.WriteLine($"Your vehicle is {vehicles[2].DistanceAwayInKm}km away. Safe riding!");
                    break;
                case "4":
                    Console.WriteLine($"Your vehicle is {vehicles[3].DistanceAwayInKm}km away. Safe riding!");
                    break;
                case "5":
                    Console.WriteLine("Searching for more vehicles in your local vicinity");
                    didChooseVehicle = false;
                    break;
                case "x":
                    break;
                default:
                    Console.WriteLine("ERROR: Sorry that option was not avalible. Please try again.");
                    break;
            }

            return didChooseVehicle;
        }
    }
}

