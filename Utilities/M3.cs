using System;
using System.Drawing;

namespace Utilities
{
    public class M3 : Car
    {
        public M3() : base("BMW", "M3", 2008, Color.Silver)
        {

        }

        //public Color Color { get; set; }

        //public string Make { get { return "BMW"; } }

        //public string Model { get { return "M3"; } }

        //public int Year { get { return 2016; } }

        public override void PressAccelerate(double howFar)
        {
            Console.WriteLine("Vroom vroom!");
        }

        public override void PressBrake(double pressure)
        {
            Console.WriteLine("Stopped on a dime!");
        }

    }
}
