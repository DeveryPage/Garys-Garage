using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The Tesla goes *silence*! and is {MainColor}");
        }

        public override void Stop()
        {
            Console.WriteLine("THE ONLY THING THAT CAN STOP ME IS ELONS COMPANY IN THE TESLA");
        }

        public override void Turn()
        {
            Console.WriteLine("HEY SIRI TURN LEFT IN THE TESLA");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}