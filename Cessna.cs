using System;

namespace Inheritance
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
            Console.WriteLine($"The {MainColor} Cessna flys overhead. Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna crashed into the ground");
        }
    }
}