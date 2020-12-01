using System;

namespace Inheritance
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; } = 50;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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