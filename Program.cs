using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero bike = new Zero()
            {
                MainColor = "lime",
                MaximumOccupancy = 2,
                BatteryKWh = 20.8
            };
            Tesla car = new Tesla()
            {
                MainColor = "gray",
                MaximumOccupancy = 5,
                BatteryKWh = 40.3
            };
            Cessna plane = new Cessna()
            {
                MainColor = "white",
                MaximumOccupancy = 12,
                FuelCapacity = 100
            };
            Ram truck = new Ram()
            {
                MainColor = "blue",
                MaximumOccupancy = 3,
                FuelCapacity = 24
            };

            bike.Drive();
            bike.Turn("left");
            bike.Stop();
            Console.WriteLine();

            car.Drive();
            car.Turn("right");
            car.Stop();
            Console.WriteLine();

            plane.Drive();
            plane.Turn("left");
            plane.Stop();
            Console.WriteLine();

            truck.Drive();
            truck.Turn("right");
            truck.Stop();
        }
    }
}
