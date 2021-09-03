using System;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
   
        public void RefuelTank()
        {
            // method definition omitted
            Console.WriteLine($"You now have refueled your car with {FuelCapacity} gallons.");
            Console.WriteLine();
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} passengers zips by you!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna makes a turn to the {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna drives by and halts.")
        }
    }
}
