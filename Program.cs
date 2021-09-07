using System;
using System.Collections.Generic;


namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Zero fxs = new Zero() { CurrentChargePercentage = 55, Name = "fxs"};
            Zero fx = new Zero() { CurrentChargePercentage = 45, Name = "fx"};
            Tesla modelS = new Tesla() { CurrentChargePercentage = 35, Name = "modelS" };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram () { CurrentTankPercentage = 23, Name = "Ram"};
            Cessna cessna150 = new Cessna () { CurrentTankPercentage = 14, Name = "Cessna"};

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("---------------------------");
            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

































            // Using the object initializer to instantiate new class objects of each type!
            // Zero fxs = new Zero() { MainColor = "Goldenrod", MaximumOccupancy = 6, BatteryKWh = 230.50 };
            // Tesla models = new Tesla() { MainColor = "Red", MaximumOccupancy = 4, BatteryKWh = 260.25};
            // Cessna mx410 = new Cessna() { MainColor = "Black", MaximumOccupancy = 6, FuelCapacity = 10.30};
            // Ram Rebel = new Ram() { MainColor = "Blue", MaximumOccupancy = 4, FuelCapacity = 12.25 };

            // // Invoking methods available for each class instance!
            // fxs.Drive();
            // fxs.Turn("left");
            // fxs.Stop();
            // fxs.ChargeBattery();

           
            // modelS.Drive();
            // modelS.Turn("right");
            // modelS.Stop();
            // modelS.ChargeBattery();

            // mx410.Drive();
            // mx410.Turn("right");
            // mx410.Stop();
            // mx410.RefuelTank();

            // trx1500.Drive();
            // trx1500.Turn("left");
            // trx1500.Stop();
            // trx1500.RefuelTank();

            // List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
            
        }
    }
}
