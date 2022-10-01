using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Inheritance
    {
        public class Bonus
        {
            protected int _bonus = 25000;
            protected void DisplayBonus()
            {


                Console.WriteLine(_bonus);
            }
        }

        public class Staff : Bonus
        {
            public void GetBonus()
            {
                _bonus = 3 * _bonus;
                Console.Write("Bonus for staff: ");
                DisplayBonus();
            }
        }
        public class NonStaff : Bonus
        {
            public void GetBonus()
            {
                _bonus = 2 * _bonus;
                Console.Write("Bonus for Non staff: ");
                DisplayBonus();
            }
        }
        public static void Main()
        {

            Staff s = new Staff();
            s.GetBonus();
            NonStaff n = new NonStaff();
            n.GetBonus();

        }
    }
}
