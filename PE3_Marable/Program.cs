using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_Marable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:"); //getting each integer 1 by 1, assigning them to variables, converting said variables, and finally multiplying them all together
            string balls1 = Console.ReadLine();
            int ball1 = Convert.ToInt32(balls1);
            Console.WriteLine("Please enter an integer:");
            string balls2 = Console.ReadLine();
            int ball2 = Convert.ToInt32(balls2);
            Console.WriteLine("Please enter an integer:");
            string balls3 = Console.ReadLine();
            int ball3 = Convert.ToInt32(balls3);
            Console.WriteLine("Please enter an integer:");
            string balls4 = Console.ReadLine();
            int ball4 = Convert.ToInt32(balls4);
            int theSack = (ball1 * ball2 * ball3 * ball4);
            Console.WriteLine("Final product is: " + theSack); //Let 'em hang
            Console.ReadLine(); //console wasn't staying open so I added this

            //before you say anything yes I know this is not the best possible naming convention
        }
    }
}
