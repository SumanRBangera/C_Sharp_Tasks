using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Multiplication_Param
    {
        public static void Main()
        {
            Multiplication(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        }
        public static void Multiplication(params int[] numbers)
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = n * numbers[i];
                Console.WriteLine($"{n} x {numbers[i]}  = {res}");
            }

        }
    }
}
