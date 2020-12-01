using System;

namespace Inheritance
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 75;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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