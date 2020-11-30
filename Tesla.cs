using System;

namespace Inheritance
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla stalks silently past. Sssshhhhh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla takes the {direction} turn with ease");
        }
    }
}