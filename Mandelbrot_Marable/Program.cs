using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            Console.WriteLine("Please enter a start value (close to 1.2, incremented by 0.1 in either direction): "); //this asks for the start of the imag loop as an input from the user
            Console.WriteLine("WARNING: Your value must be MORE than -1.2");
            float firstInput = float.Parse(Console.ReadLine()); //this converst the given value into a usable float for conversion 
            int imagStart = Convert.ToInt32(firstInput); //this gets us our first inputed value to be used in imag the loop later


            Console.WriteLine("Please enter an end value (close to -1.2, incremented by 0.1 in either direction): ");
            float secondInput = float.Parse(Console.ReadLine());
            int imagEnd = Convert.ToInt32(secondInput); //this gives us our second inputed value to be used in the imag loop later


            Console.WriteLine("Please enter a second start value (close to -0.6, incremented by 0.1 in either direction): "); //this asks for the value desired by the user for the start of the second loop real
            Console.WriteLine("WARNING: Your value must be LESS than 1.77");
            float thirdInput = float.Parse(Console.ReadLine());
            int realStart = Convert.ToInt32(thirdInput); //this gives us our starting value for real loop 2


            Console.WriteLine("Please enter an end value (close to 1.77, incremented by 0.01 in either direction): ");//this asks the user for the ending value desired for real loop 2
            float fourthInput = float.Parse(Console.ReadLine());
            int realEnd = Convert.ToInt32(fourthInput); //this gives us our enddingf value for real loop 2

            for (imagCoord = imagStart; imagCoord >= imagEnd; imagCoord -= 0.05)
            {
                for (realCoord = realStart; realCoord <= realEnd; realCoord += 0.03)//edited the preset values to the updated ones
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
