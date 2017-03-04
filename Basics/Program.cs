using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Add(5);
            calc.Add(9);

            Calculator calc2 = new Calculator();
            calc2.Add(19);
            calc2.Add(6);

            Console.WriteLine(calc.Sum);
            Console.WriteLine(calc2.Sum);
            //Console.WriteLine(Calculator.GetUsageCount());
            Console.WriteLine(Calculator.UsageCount);

            //int[] a = null;

            //a = new int[3] { 1, 2, 3 };

            //Array.Resize<int>(ref a, 4);
            //a[3] = 4;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
