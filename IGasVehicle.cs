using System;

namespace Garage
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }
        
        void RefuelTank();
    }
}