using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class InternalDemoPrint1
    {
        public String str = "This is Public Access Modifier!!";
        public String Name = "This is Internal Access Modifier";
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
     class internal1
    {
        public static void Main()
        {
            InternalDemoPrint2 p2 = new InternalDemoPrint2();
            p2.Displayage();
        }
    }
}
