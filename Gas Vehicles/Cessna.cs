using System;
namespace Garage
{
    class Cessna : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            int CurrentTankPercentage = 15;
        }

        // public void Drive()
        // {
        //     Console.WriteLine("The cool cardial Cessna zips by. Zoooooom!");
        // }
        // public void Turn()
        // {
        //     Console.WriteLine("The Cessna eases into a left turn on the runway");
        // }
        // public void Stop()
        // {
        //     Console.WriteLine("The cardinal Cessna rolls to a stop after rolling a mile down the runway");
        // }
    }
}