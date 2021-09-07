using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle// Electric motorcycle
    {
        public double BatteryKWh { get; set; } = 100.00;
        public double CurrentChargePercentage { get; set; } 
       

        public void ChargeBattery()
        {
            // method definition omitted
            Console.WriteLine($"Your {Name} is currently {CurrentChargePercentage}% but now it is charged to {BatteryKWh}% KWh.");
            CurrentChargePercentage = BatteryKWh;
            Console.WriteLine();
         
        }


    

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero with {MaximumOccupancy} passengers!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero stops!");
        }
    }
}
