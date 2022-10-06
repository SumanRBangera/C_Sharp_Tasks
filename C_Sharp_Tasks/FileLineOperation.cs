using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class FileLineOperation
    {
        public static void Main()
        {
            string path = "C:\\Users\\EI13098\\Desktop\\blogs\\DotNet\\Task 17\\Multiplication.txt";
            string[] file;

           
            file = File.ReadAllLines(path);

            Console.WriteLine("First line of the Given File is");
            Console.WriteLine(file[0]);
           

            
            int c = File.ReadAllLines(path).Length;
            Console.WriteLine("Total number of lines in the Given file is");
            Console.WriteLine(c);
          

        }
    }
}
