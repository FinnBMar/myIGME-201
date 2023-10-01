using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.Write("Please enter your name: ");
            sName = Console.ReadLine();

            bool gotRaise = GiveRaise(sName, ref dSalary);

            if (gotRaise)
            {
                Console.WriteLine("Congratulations, you got a raise!");
                Console.WriteLine($"Your new salary is: ${dSalary:N2}");
            }
            else
            {
                Console.WriteLine("Sorry, you did not get a raise.");
            }
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name.Equals("Finn", StringComparison.OrdinalIgnoreCase))
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}