using System;

namespace RideShare.Models
{
    public class Luxury_Car : Vehicle
    {
        public Luxury_Car()
        { }

        public override void ReportDistance()
        {
            Console.WriteLine($"You're in for a smooth ride! There is a luxury vehicle {DistanceAwayInKm}km away.");
        }
    }
}