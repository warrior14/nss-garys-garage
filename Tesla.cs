using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // you need a colon between the subclass name and the base/parent class name when inheriting 
    // now with any instance of Tesla will have the same properties and methods from the base/parent class
    {
        public double BatteryKWh { get; set; } = 100.00;
         public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
            Console.WriteLine($"Your {Name} is currently {CurrentChargePercentage}% but now is charged up to {BatteryKWh}% KWh.");
            CurrentChargePercentage = BatteryKWh;
            Console.WriteLine();
        }

    
        

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} passengers zips by you.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla zooms around a {direction} turn!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla abrupty stops.");
        }



    }
}

