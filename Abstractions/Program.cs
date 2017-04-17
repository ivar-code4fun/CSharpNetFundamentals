using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = { new M3 { Color = Color.Silver },
                            new Hooptie { Color = Color.Black }
                          };

            foreach (var car in cars)
            {
                PrintInfo(car);
                car.Start();
                car.PressAccelerate(2);
                car.PressAccelerate(10);
                car.PressBrake(2);
                car.PressBrake(10);
            }
        }

        static void PrintInfo(Car car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}",car.Color.Name,car.Year,car.Make,car.Model);
        }
    }
}
