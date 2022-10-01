using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class InternalDemoPrint2
    {
        public int age = 22;


        public void Displayage()
        {
            Console.WriteLine(age);
        }
    }
     class internal2
    {
        public static void Main()
        {
            InternalDemoPrint1 p1 = new InternalDemoPrint1();
            p1.Display();
            Console.WriteLine(p1.str);

        }
    }
}
