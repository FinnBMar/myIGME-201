using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Marable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control;
            for(control = 0; control < 1;) //loop control variable. If the integers given don't satisfy the requirements, then the code will repeat asking for 2 new integers.
            {
                    Console.WriteLine("Please enter a new integer less than 10:");
                    string firstInput = Console.ReadLine();
                    int firstInteger = Convert.ToInt32(firstInput);
                    Console.WriteLine("Please enter a new second integer less than 10:");
                    string secondInput = Console.ReadLine();
                    int secondInteger = Convert.ToInt32(secondInput);
                    if ((firstInteger<10) ^ (secondInteger<10)) //this if handles the case where one of the integers is less than 10 and another one isn't
                    { 
                        control += 1;
                    }
                    if ((firstInteger < 10) & (secondInteger < 10)) //this if handles the case where both integers are less than 10
                    {
                        control += 1;
                    }
                    Console.WriteLine("Your first integer was: " + firstInteger); //if the integers were both >10 then the code repeats.
                    Console.WriteLine("Your second integer was: " + secondInteger);
                    
            }
        }
    }
}
