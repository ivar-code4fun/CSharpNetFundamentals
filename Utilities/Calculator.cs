using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities
{ 
    [XmlRoot("calc", Namespace="urn:ravi")]
    public class Calculator
    {
        [XmlElement("sum")]
        public double Sum { get; set; }

        //public static int UsageCount;
        public static int UsageCount { get; private set; }

        public Calculator()
        {
            Console.WriteLine("Instance ctor fired!!");
        }

        static Calculator()
        {
            Console.WriteLine("Static ctor fired!!");
        }

        public void Add(double a)
        {
            ++UsageCount;
            Sum += a;
        }

        //public static int GetUsageCount()
        //{
        //    return usageCount;
        //}

    }
}
