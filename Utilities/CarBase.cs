﻿using System;
using System.Drawing;

namespace Utilities
{
    public abstract class CarBase : ICar
    {
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Color.Name, Year, Make, Model);
        }

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

        public event EventHandler CarStopped;


        protected void FireCarStoppedEvent()
        {
            if (null != CarStopped)
                CarStopped(this,EventArgs.Empty);
        }
    }

}
