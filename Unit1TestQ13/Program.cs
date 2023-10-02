using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1Q12
{
    struct Employee
    {
        public string sName;
        public double dSalary;
    }

    class Program
    {
        static void Main(string[] args) //Finn marable unit 1 test question 13 modification of the salary raise program to use the Employee structure.
        {
            Employee employee;
            employee.dSalary = 30000;
            Console.Write("Please enter your name: ");
            employee.sName = Console.ReadLine();
            bool gotRaise = GiveRaise(ref employee);
            if (gotRaise)
            {
                Console.WriteLine("Congratulations, you got a raise!");
                Console.WriteLine($"Your new salary is: ${employee.dSalary:N2}");
            }
            else
            {
                Console.WriteLine("Sorry, you did not get a raise.");
            }
        }
        static bool GiveRaise(ref Employee employee)
        {
            if (employee.sName.Equals("Finn", StringComparison.OrdinalIgnoreCase))
            {
                employee.dSalary += 19999.99;
                return true;
            }
            return false;
        }
    }
}