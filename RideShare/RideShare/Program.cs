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

            // 2.1. TODO: Create a list that can hold the above cars, extra large cars and luxury cars

            // 2.2. Check for nearby cars, extra large cars and luxury cars
            // by creating a foreach loop that goes through each of the cars, motorbikes and luxury cars created
            // and calls their ReportDistance method
        }

        static void GiveInstructions()
        {
            Console.WriteLine("Welcome to our RideShare App!");
            Console.WriteLine("Press any key to see the cars in your local vicinity");
        }


        static List<Vehicle> FindNearbyCars()
        {
            // Create cars, motorbikes and luxury cars in the user's vicinity
            var car1 = new Car(4.5);
            var car2 = new Car(1.2);
            var luxuryCar1 = new LuxuryCar(0.6);
            var extraLargeCar1 = new Extra_Large_Car(3.0);

            var vehicles = new List<Vehicle> { car1, car2, luxuryCar1, extraLargeCar1 };

            return vehicles;
        }

        static void ChooseVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Which vehicle would you like to choose?");
        }
    }
}
