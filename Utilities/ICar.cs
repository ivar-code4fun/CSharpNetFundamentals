using System;
using System.Drawing;

namespace Utilities
{
    public interface ICar
    {
        void Start();
        void PressAccelerate(double howFar);
        void PressBrake(double pressure);

        string Make { get; }
        string Model { get; }
        int Year { get; }
        Color Color { get; set; }

        event EventHandler CarStopped;
    }

}
