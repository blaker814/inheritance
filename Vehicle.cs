using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Wow, you turned {direction}!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"Your movement has ceased");
        }
    }
}