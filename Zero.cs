using System;

namespace Inheritance
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 60;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by. Yeeooww!");
        }
        public override void Stop()
        {
            Console.WriteLine("Movement has stopped, so you plant your feet on the ground.");
        }
    }
}