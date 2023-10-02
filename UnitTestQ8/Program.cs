using System;

namespace MultidimensionalArrayExample
{
    class Program
    {
        delegate double RoundDelegate(double value, int decimals);
        static void Main(string[] args)
        {
            double minY = -1;// Define the ranges and increments
            double maxY = 1;
            double minX = 0;
            double maxX = 4;
            double increment = 0.1;

            int rowCount = (int)Math.Ceiling((maxY - minY) / increment) + 1;// Calculate the array dimensions
            int colCount = (int)Math.Ceiling((maxX - minX) / increment) + 1;

            double[,] resultArray = new double[rowCount, colCount];// Create a multidimensional array to store the results

            RoundDelegate roundFunc = (value, decimals) => Math.Round(value, decimals);// Define a delegate to round values

            for (int i = 0; i < rowCount; i++)// Calculate and store the values of z
            {
                for (int j = 0; j < colCount; j++)
                {
                    double y = minY + i * increment;
                    double x = minX + j * increment;

                    double z = 4 * Math.Pow(roundFunc(y, 1), 3) + 2 * Math.Pow(roundFunc(x, 1), 2) - 8 * roundFunc(x, 1) + 7; // Calculate z using the given formula

                    resultArray[i, j] = roundFunc(z, 3);// Round z to 3 decimal places and store in the array
                }
            }
            for (int i = 0; i < rowCount; i++)// Print the result array
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write($"{resultArray[i, j],8:F3} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}