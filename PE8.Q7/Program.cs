using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8.Q7
{
    internal class Program
    {
        static void Main(string[] args) //Finn Marable this program is PE8 Q.7 and takes a user inputted string and returns it backwards
        {

            Console.WriteLine("enter a string");
            string myString = Console.ReadLine();
            char[] myChars = myString.ToCharArray();
            foreach (char character in myString)
            {
                //Console.WriteLine("{0}", character);
                for (int i = 0; i < myChars.Length; i++)
                {
                    myChars[i] = myString[myString.Length - i - 1];
                }
            }
            Console.WriteLine(myChars);
        }
    }
}
