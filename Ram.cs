using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The Ram goes gluggluglug! and is {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("RAMS BREAKS DONT WORK IN THE RAM");
        }

        public override void Turn()
        {
            Console.WriteLine("RAMS STEERING WHEELS DONT WORK EITHER IN THE RAM");
        }
        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}