using System;
using System.Drawing;

namespace Utilities
{
    public abstract class CarBase : ICar
    {
        public CarBase(string make, string model, int year, Color color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public virtual void Start()
        {
            Console.WriteLine("Roar!");
        }

        public abstract void PressAccelerate(double howFar);
        public abstract void PressBrake(double pressure);

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Color Color { get; set; }
    }

}
