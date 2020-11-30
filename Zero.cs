using System;

namespace Inheritance
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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