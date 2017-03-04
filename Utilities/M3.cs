using System;
using System.Drawing;

namespace Utilities
{
    public class M3 : ICar
    {
        public Color Color
        {
            get; set;
        }

        public string Make
        {
            get
            {
                return "BMW";
            }
        }

        public string Model
        {
            get
            {
                return "M3";
            }
        }

        public int Year
        {
            get
            {
                return 2016;
            }
        }

        public void PressAccelerate(double howFar)
        {
            Console.WriteLine("Vroom vroom!");
        }

        public void PressBrake(double pressure)
        {
            Console.WriteLine("Stopped on a dime!");
        }

        public void Start()
        {
            Console.WriteLine("Roar!");
        }
    }
}
