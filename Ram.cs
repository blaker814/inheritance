using System;

namespace Inheritance
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; } = 70;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram runs you over. Splat!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine("You continue barrelling ahead, running over anything in your path");
        }
    }
}