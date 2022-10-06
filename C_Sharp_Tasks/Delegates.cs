using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public delegate void BankName(string _bankName, string _interest);
    public class Bank
    {
        public void InterestCalculator(string _bankName, string _interest)
        {
            Console.WriteLine($"Bank Name :{_bankName} \nThe Rate of interest :{_interest} ");
        }
    }
    internal class Delegates
    {
        public static void Main()
        {
                int ch;
                Bank bank = new Bank();
                BankName b = bank.InterestCalculator;
                Console.WriteLine("Enter the option to know the interest rate of the Bank: ");
                Console.WriteLine(" 1: SBI\n 2: HDFC Bank\n 3: Kotak Mahindra Bank\n 4: Axis Bank\n 5: ICICI Bank\n 6:Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        b("SBI", "2.70%");
                        break;
                    case 2:
                        b("HDFC Bank", "3.00 % – 3.50 %");
                        break;
                    case 3:
                        b("Kotak Mahindra Bank", "3.50%");
                        break;
                    case 4:
                        b("Axis Bank", "3.00% – 3.50%");
                        break;
                    case 5:
                        b("ICICI Bank", "3.00% – 3.50%");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
        }
    }
}
