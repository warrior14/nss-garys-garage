using System;

namespace Garage
{
    public interface IElectricVehicle
    {
         double CurrentChargePercentage { get; set; }

         void ChargeBattery();


         public string Name { get; set; }
    }
}