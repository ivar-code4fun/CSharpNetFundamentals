using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Hooptie : CarBase
    {
        public Hooptie() : base("Cadillac", "Coupe deVille", 1998, Color.Black )
        {

        }

        //public Color Color { get; set; }

        //public string Make { get { return "Cadillac"; } }

        //public string Model { get { return "Coupe deVille"; } }

        //public int Year { get { return 1998; } }

        public override void PressAccelerate(double howFar)
        {
            if (howFar < 9)
            {
                //nothing!
            }
            else
                Console.WriteLine("Cough!");
        }

        public override void PressBrake(double pressure)
        {
            if (pressure < 5)
                Console.WriteLine("Squeek");
            else
                Console.WriteLine("Griiiiiiinnnnnndddd");
        }

        public new void Start()
        {
            Console.WriteLine("Click, click, click!");
        }
    }
}
