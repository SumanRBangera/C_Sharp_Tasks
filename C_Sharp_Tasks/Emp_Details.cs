using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Emp_Details
    {
        public static void Main()
        {
            Console.WriteLine("---Employee Details---");
            StaticFunction();

        }
        public static void StaticFunction()
        {
            int id;
            String name, role;
            Console.WriteLine("Enter the number of employess");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Employee Id : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the Employee Role : ");
                role = Console.ReadLine();
                Emp_Details d = new Emp_Details();
                d.Instanse(id, name, role);

            }




        }
        public void Instanse(int id, String name, String role)
        {
            Console.WriteLine($"Employee ID : {id}");
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Employee Role : {role}");
        }

    }
}
