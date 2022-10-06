using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public class AgeNotValidException : Exception
    {
        public AgeNotValidException(String message)
            : base(message)
        {

        }
    }
    internal class UserdefinedException
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("Enter the age : ");
            age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age > 22)
                {
                    Console.WriteLine("Age is Valid!!");
                }
                else
                {
                    throw (new AgeNotValidException("AgeNotValidException Generated  "));
                }
            }
            catch (AgeNotValidException aex)
            {
                Console.WriteLine(aex.Message.ToString());

            }
        }
    }
}
