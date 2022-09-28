using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Matrix_Addition
    {
        public static void Main()
        {
            MatrixAddition();
        }
        public static void MatrixAddition()
        {
            int[,] a = new int[,]
            {
                {1, 1},
                {4, 5},
            };
            int[,] b = new int[,]
            {
                {7, 8},
                {8, 9},
            };
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < 2; i++)

            {
                Console.WriteLine();
                for (int k = 0; k < 2; k++)
                {
                    Console.Write("{0}\t", c[i, k]);
                }
            }

        }
    }
}
