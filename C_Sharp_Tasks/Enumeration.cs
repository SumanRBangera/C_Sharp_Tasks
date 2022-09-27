using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Enumeration
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public static void Main()
        {
            Console.WriteLine("--ENUMERATION CONCEPTS");
            Days days = Days.Monday;
            Console.WriteLine(days);
            int d = (int)Days.Monday;
            Console.WriteLine(d);
        }
    }
}
