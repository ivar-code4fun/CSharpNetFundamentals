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
            //ObjectCasting();

            //CarStoppedDelegate();

            //KeystrokeDelegate();

            //CarInterface();
        }

        private static void ObjectCasting()
        {
            object[] cars =
                        {
                new M3(),
                new Hooptie()
            };

            foreach (ICar car in cars)
            {
                Console.WriteLine(car);
                Is(car);
                As(car);
                Cast(car);
                Console.WriteLine("---------------");
            }
        }

        private static void Cast(object car)
        {
            try
            {
                M3 m3 = (M3)car;
                Console.WriteLine("M3 returned a {0}", m3);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : {0}",ex.Message);
            }
        }

        private static void As(object car)
        {
            M3 m3 = car as M3;
            Console.WriteLine("as M3 returned {0}",m3);
        }

        private static void Is(object car)
        {
            bool isICar = car is ICar;
            Console.WriteLine("is ICar returned {0}",isICar);
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
