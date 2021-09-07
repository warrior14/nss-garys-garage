using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 100.00;
        public double CurrentTankPercentage { get; set; }
        

        public void RefuelTank()
        {
            // method definition omitted
            Console.WriteLine($"Your {Name} currently has {CurrentTankPercentage}% but now that you refueled, you have {FuelCapacity}!");
            CurrentTankPercentage = FuelCapacity;
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} humans zooms by!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram makes a turn to the {direction}.");
        }


        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram halts.");
        }


    }
}
