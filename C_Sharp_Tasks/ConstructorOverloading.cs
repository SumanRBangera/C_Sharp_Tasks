using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public class Add
    {


        public Add(int a, int b)
        {

            int sum = a + b;
            Console.WriteLine($"Addition of integer numbers : {sum}");
        }
        public Add(float x, float y)
        {

            float add = x + y;
            Console.WriteLine($"Addition of Floating point numbers : {add}");
        }
        public Add(String str1, String str2)
        {
            String str = str1 + str2;
            Console.WriteLine($"String Concatination : {str}");
        }




    }
    internal class ConstructorOverloading
    {
        public static void Main()
        {
            Add add1 = new Add(10, 20);
            Add add2 = new Add(10.5f, 20.5f);
            Add add3 = new Add("Suman", " Bangera");
        }
    }
}
