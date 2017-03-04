using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Hooptie : ICar
    {
        public Color Color
        {
            get; set;
        }

        public string Make
        {
            get
            {
                return "Cadillac";
            }
        }

        public string Model
        {
            get
            {
                return "Coupe deVille";
            }
        }

        public int Year
        {
            get
            {
                return 1998;
            }
        }

        public void PressAccelerate(double howFar)
        {
            if (howFar < 9)
            {
                //nothing!
            }
            else
                Console.WriteLine("Cough!");
        }

        public void PressBrake(double pressure)
        {
            if (pressure < 5)
                Console.WriteLine("Squeek");
            else
                Console.WriteLine("Griiiiiiinnnnnndddd");
        }

        public void Start()
        {
            Console.WriteLine("Click, click, click!");
        }
    }
}
