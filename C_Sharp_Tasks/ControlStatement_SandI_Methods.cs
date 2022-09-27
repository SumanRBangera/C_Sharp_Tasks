using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class ControlStatement_SandI_Methods
    {
        public static void Main()
        {
            ControlStatement_SandI_Methods p = new ControlStatement_SandI_Methods();
            Console.WriteLine("Enter Your Choice\n 0: Conditional Statements\n 1: Looping Statements");
            int x = Convert.ToInt32(Console.ReadLine());
            //switch case
            switch (x)
            {
                case 0:
                    p.Conditional_Statement();
                    break;
                case 1:
                    Looping_Statement();
                    break;
                default:
                    Console.WriteLine("Invalid!!");
                    break;
            }
        }
        public void Conditional_Statement()
        {
            Console.WriteLine("---CONDITIONAL STATEMENTS USING INSTANSE METHOD---");
            int a = 10;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine("a is larger");
            }
            else
            {
                Console.WriteLine("b is larger");
            }
        }
        public static void Looping_Statement()
        {
            Console.WriteLine("---CONDITIONAL STATEMENTS USING STATIC METHOD---");
            int[] arr = new int[] { 1, 2, 3 };
            Console.WriteLine("---FOR LOOP---");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("---WHILE LOOP---");
            int j = 0;
            while (j < arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
            Console.WriteLine("---FOR EACH LOOP---");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
