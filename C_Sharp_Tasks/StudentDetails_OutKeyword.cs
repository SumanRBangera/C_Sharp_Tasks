using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class StudentDetails_OutKeyword
    {
        public static void Main()
        {
            int sid;
            String sname;
            String sdept;
            Display(out sid, out sname, out sdept);
            Console.WriteLine("---DETAILS ARE---");
            Console.WriteLine($"Student id : {sid}");
            Console.WriteLine($"Student Name : {sname}");
            Console.WriteLine($"Student Department : {sdept}");
        }
        public static void Display(out int sid, out String sname, out String sdept)
        {
            Console.WriteLine("Enter Student id :");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            sname = Console.ReadLine();
            Console.WriteLine("Enter Student Department :");
            sdept = Console.ReadLine();
        }
    }
}
