using System;

namespace RideShare.Models
{
    public abstract class Vehicle
    {
        internal double DistanceAwayInKm { get; set; }

        public virtual void ReportDistance()
        {
            var className = this.GetType().Name;
            Console.WriteLine($"There is a vehicle (type: {className.ToLower().Replace("_", " ")}) {DistanceAwayInKm}km away.");
        }
    }
}

//note: the derived class cannot inherit the constructor of the base class!