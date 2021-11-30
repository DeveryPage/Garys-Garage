using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The Cessna goes, wait what is a cessna? and is {MainColor}");
        }
        public override void Stop()
        {
            Console.WriteLine("IF WE STOP MID FLIGHT WE AINT GON BE ALRIGHT IN THE CESSNA");
        }

        public override void Turn()
        {
            Console.WriteLine("WATHC ME THREAD THIS NEEDLE IN THE CESSNA");
        }
    }
}