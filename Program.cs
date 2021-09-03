using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the object initializer to instantiate new class objects of each type!
            Zero fxs = new Zero() { MainColor = "Goldenrod", MaximumOccupancy = 6, BatteryKWh = 230.50 };
            Tesla models = new Tesla() { MainColor = "Red", MaximumOccupancy = 4, BatteryKWh = 260.25};
            Cessna mx410 = new Cessna() { MainColor = "Black", MaximumOccupancy = 6, FuelCapacity = 10.30};
            Ram Rebel = new Ram() { MainColor = "Blue", MaximumOccupancy = 4, FuelCapacity = 12.25 };

            // Invoking methods available for each class instance!
            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            fxs.ChargeBattery();

           
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            modelS.ChargeBattery();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            mx410.RefuelTank();

            trx1500.Drive();
            trx1500.Turn("left");
            trx1500.Stop();
            trx1500.RefuelTank();

            // List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
            
        }
    }
}
