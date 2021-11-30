using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }


        public override void Drive()
        {
            Console.WriteLine($"Ther zero goes Skrt! and is {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("CANT STOP THE POP TOP IN THE ZERO");
        }

        public override void Turn()
        {
            Console.WriteLine("ZERO TuRN RADIUS IN THE ZERO");
        }
        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}