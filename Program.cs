using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            fxs.Stop();
            fxs.Turn();
            Console.WriteLine();
            modelS.Stop();
            modelS.Drive();
            modelS.Turn();
            Console.WriteLine();
            mx410.Drive();
            mx410.Stop();
            mx410.Turn();
        }
    }
}
