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

            var vehicles = FindNearbyCars();

            foreach (var vehicle in vehicles)
            {
                vehicle.ReportDistance();
            }

            ChooseVehicle(vehicles);
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
                new Extra_Large_Car()
            };

            var vehicle1 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            var vehicle2 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            var vehicle3 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];
            var vehicle4 = listOfVehicleTypes[randomNumberGenerator.Next(0, listOfVehicleTypes.Count)];


            //only vehicles within a 5 km range
            vehicle1.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 2);
            vehicle2.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 2);
            vehicle3.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 2);
            vehicle4.DistanceAwayInKm = Math.Round(5 * randomNumberGenerator.NextDouble(), 2);

            var vehicles = new List<Vehicle> { vehicle1, vehicle2, vehicle3, vehicle4 };

            return vehicles;
        }

        static void ChooseVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Which vehicle would you like to choose?");
            //Console.WriteLine("Vehicle 1, Vehicle 2,  ");
            //var UserInput = Console.ReadLine();
        }
    }
}
