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

            //CarStoppedDelegate();

            //KeystrokeDelegate();

            //CarInterface();
        }

        private static void CarStoppedDelegate()
        {
            ICar car = new M3();
            car.CarStopped += OnCarStopped;

            car.Start();
            car.PressAccelerate(10);
            car.PressBrake(10);
        }

        private static void OnCarStopped(object sender, EventArgs e)
        {
            Console.WriteLine("Car Stopped!!");
        }

        private static void KeystrokeDelegate()
        {
            QuitTracker bob = new QuitTracker { Name = "Bob" };
            QuitTracker sandy = new QuitTracker { Name = "Sandy" };

            KeystrokeHandler keystrokeHandler = new KeystrokeHandler();
            //keystrokeHandler.OnKey = new KeypresssDelegate(GotKey);
            keystrokeHandler.OnKey += GotKey;
            //keystrokeHandler.OnQuitting = OnQuit;
            keystrokeHandler.OnQuitting += bob.QuitHandler;
            keystrokeHandler.OnQuitting += sandy.QuitHandler;
            keystrokeHandler.OnQuitting += sandy.QuitHandler;
            keystrokeHandler.OnQuitting -= bob.QuitHandler;
            //keystrokeHandler.OnQuitting = null;

            keystrokeHandler.Run();
        }

        static void GotKey(char key)
        {
            Console.WriteLine("Got a key : {0}",key);
        }

        static void OnQuit()
        {
            Console.WriteLine("Quitting !!");
        }

        private static void CarInterface()
        {
            ICar[] cars = { new M3 { Color = Color.Silver },
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

            Console.WriteLine("Here is a new BMW M3");
            ICar m3 = new M3();
            m3.Start();

            Console.WriteLine("Here is a new hooptie!");
            Hooptie hooptie = new Hooptie();
            hooptie.Start();
        }

        static void PrintInfo(ICar car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}",car.Color.Name,car.Year,car.Make,car.Model);
        }
    }

    public class QuitTracker
    {
        public string Name { get; set; }
        public void QuitHandler()
        {
            Console.WriteLine("My name is {0} and i just got a quit notification",Name);
        }
    }
}
