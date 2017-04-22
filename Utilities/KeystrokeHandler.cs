using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public delegate void KeypresssDelegate(char key);
    public delegate void QuitDelegate();

    public class KeystrokeHandler
    {
        public event KeypresssDelegate OnKey;
        public event QuitDelegate OnQuitting;
         
        public void Run()
        {
            Console.WriteLine("Keystroke handler is running. Type \"q\" to quit.");
            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;

                if (key == 'q')
                {
                    if (OnQuitting != null)
                        OnQuitting();
                    break;
                }

                if (OnKey != null)
                {
                    OnKey(key);
                }
            }
        }

    }
}
