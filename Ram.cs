using System;

namespace Inheritance
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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