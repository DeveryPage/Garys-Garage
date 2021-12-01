using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {

        public Zero(string mainColor, int maxCapacity)
        {
            MainColor = mainColor;
            MaximumOccupancy = maxCapacity;
        }

        public double BatteryKWh { get; set; }
        public int currentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            int CurrentChargePercentage = 30;
        }


        // public override void Drive()
        // {
        //     Console.WriteLine($"Ther zero goes Skrt! and is {MainColor}");
        // }
        // public override void Stop()
        // {
        //     Console.WriteLine("CANT STOP THE POP TOP IN THE ZERO");
        // }

        // public override void Turn()
        // {
        //     Console.WriteLine("ZERO TuRN RADIUS IN THE ZERO");
        // }
    }
}