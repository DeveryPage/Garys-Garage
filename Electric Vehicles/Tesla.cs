using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int currentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            currentChargePercentage = 100;
        }

        // public override void Drive()
        // {
        //     Console.WriteLine($"The Tesla goes *silence*! and is");
        // }

        // public override void Stop()
        // {
        //     Console.WriteLine("THE ONLY THING THAT CAN STOP ME IS ELONS COMPANY IN THE TESLA");
        // }

        // public override void Turn()
        // {
        //     Console.WriteLine("HEY SIRI TURN LEFT IN THE TESLA");
        // }

    }
}