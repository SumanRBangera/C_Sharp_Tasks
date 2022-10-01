using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class RegularExpression
    {
        public static void Mobile_Validation()
        {
            String mbl = "9362511421";
            var validation = Regex.IsMatch(mbl, @"^[7-9][0-9]{9}$");
            Console.WriteLine(validation);
        }
        public static void Main()
        {
            Mobile_Validation();

        }
    }
}
