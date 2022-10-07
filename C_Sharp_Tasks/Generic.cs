using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Generic
    {
        public delegate T Delegates<T>(T res);

        class Area
        {
            public int AreaOfSquare(int side)
            {
                return (side * side);
            }
            public double AreaOfCircle(double radius)
            {
                return (radius * radius * 3.14);
            }
            public int AreaOfCube(int side)
            {
                return (6 * side * side);
            }
        }
        public static void Main()
        {
            Area area = new Area();
            Delegates<int> d = new Delegates<int>(area.AreaOfSquare);

            Console.WriteLine("Enter the side of square");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:" + d(s));
        

            d = area.AreaOfCube;
            Console.WriteLine("Enter the side of cube");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:" + d(c));
           

            Delegates<double> D = new Delegates<double>(area.AreaOfCircle);
            Console.WriteLine("Enter the radius of circle");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:" + D(C));
         
        }




    }
}
