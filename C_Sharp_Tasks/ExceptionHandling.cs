using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public class ExceptionClass
    {
        public void MultipleCatch()
        {
            int[] a = { 5, 10, 7, 5, 9, 1 };
            int[] b = { 0, 1, 2, 4, 0 };
            for (int i = 0; i < a.Length; i++)
            {

                try
                {

                    Console.WriteLine(a[i] / b[i]);
                }
                catch (DivideByZeroException e)
                {


                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {

                    Console.WriteLine(e.Message);
                }


            }

        }

    }
    internal class ExceptionHandling
    {
        public static void Main()
        {
            ExceptionClass ec = new ExceptionClass();
            ec.MultipleCatch();
        }
    }
}
